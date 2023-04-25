using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace ProyectoRoles
{
    public partial class FormConsultarBases : Form
    {
        public FormConsultarBases()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Text = dgvConsultaTabla.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvConsultaTabla.SelectedCells[1].Value.ToString();
            txtCargo.Text = dgvConsultaTabla.SelectedCells[2].Value.ToString();
        }
        private void recargarTabla()
        {
            // generamos un string que tiene los valores del select par la base 
            string consultaBase = "select * from TRABAJADORES";
            // vamos a generar un adaptador para que adapte la tablas y columnas de la base,usa como parametros la consulta
            //y la conexion para ver en que base se tiene que conectar
            SqlDataAdapter adptador = new SqlDataAdapter(consultaBase, conexion);
            // se debe guardar todo en una tabla virtual, todos los datos que el select ha traido de la tabla 
            DataTable dtTRABAJADORES = new DataTable();
            //Utilizando el adaptador antes declarado, lo vamos a llenar con los datos de la tabla virtual llamada tbNomina
            adptador.Fill(dtTRABAJADORES);
            //y ahora le vamos a dar el origen de los datos a dgv.
            dgvConsultaTabla.DataSource = dtTRABAJADORES;
        }
        private void FormConsultarBases_Load(object sender, EventArgs e)
        {
            // generamos un string que tiene los valores del select par la base 
            string consultaBase = "select * from TRABAJADORES";
            // vamos a generar un adaptador para que adapte la tablas y columnas de la base,usa como parametros la consulta
            //y la conexion para ver en que base se tiene que conectar
            SqlDataAdapter adaptador = new SqlDataAdapter(consultaBase, conexion);
            // se debe guardar todo en una tabla virtual, todos los datos que el select ha traido de la tabla 
            DataTable dtTRABAJADORES = new DataTable();
            //Utilizando el adaptador antes declarado, lo vamos a llenar con los datos de la tabla virtual llamada tbNomina
            adaptador.Fill(dtTRABAJADORES);
            //y ahora le vamos a dar el origen de los datos a dgv.
            dgvConsultaTabla.DataSource = dtTRABAJADORES;

            //rellenar combo_box
            DataTable dtLocalidades =new DataTable();
            string llenarcmb = "select ID,LOCALIDAD from <LOCALIDADES>";
            SqlDataAdapter adaptadorLoc =new SqlDataAdapter(llenarcmb, conexion);
            adaptadorLoc.Fill(dtLocalidades);
            cmbLocalidad.DisplayMember = "LOCALIDAD";
            cmbLocalidad.ValueMember = "ID";
            cmbLocalidad.DataSource = dtLocalidades;
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            conexion.Open();
            //Inserta los datos a la base dejando en claro el query a traves del string
            string add = "insert into Nomina values('" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtCargo.Text + "')";
            SqlCommand comando = new SqlCommand(add, conexion);
            //ahora declarado el objet comando que obtiene comoparametros el string add que tiene el query, y el string conexion   
            //que tiene las llaves de conexion
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Exitoso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            recargarTabla();
            conexion.Close();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string consultaBorrar = "delete from TRABAJADORES where CEDULA";
        }

        private void dgvConsultaTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
