using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProyectoRoles
{
    public partial class FormSubirRol : Form
    {
        private DataSet dtsTablas = new DataSet();

        public FormSubirRol()
        {
            InitializeComponent();
        }
        private void FormSubirRol_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
            oOpenFileDialog.Title = "Seleccione el archivo de Excel";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                cboHojas.Items.Clear();
                dgvDatos.DataSource = null;

                txtRutaArchivo.Text = oOpenFileDialog.FileName;

                using (FileStream fsSource = new FileStream(oOpenFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fsSource, new ExcelReaderConfiguration()
                    {
                        FallbackEncoding = Encoding.GetEncoding(1252)
                    });

                    dtsTablas = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    foreach (DataTable tabla in dtsTablas.Tables)
                    {
                        cboHojas.Items.Add(tabla.TableName);
                    }
                    cboHojas.SelectedIndex = 0;
                    reader.Close();
                }
            }
        }

        private void btnMostrarHojas_Click(object sender, EventArgs e)
        {
            if (cboHojas.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una hoja");
                return;
            }
            dgvDatos.DataSource = dtsTablas.Tables[cboHojas.SelectedIndex];
        }

        private void btnSubirDatos_Click(object sender, EventArgs e)
        {
            // Aquí va la funcion de subir datos a la base de datos
            DataTable data = (DataTable)(dgvDatos.DataSource);

            bool resultado = new Operaciones().SubirDatos(data);

            if (resultado)
            {
                MessageBox.Show("Se registro la data");
            }
            else
            {
                MessageBox.Show("Hubo un problema al registrar");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Advertencia",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
