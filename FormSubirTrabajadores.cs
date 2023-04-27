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
    public partial class FormSubirTrabajadores : Form
    {
        public FormSubirTrabajadores()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Text = dgvConsultaTabla.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvConsultaTabla.SelectedCells[3].Value.ToString();
            txtCargo.Text = dgvConsultaTabla.SelectedCells[5].Value.ToString();
            txtSueldo.Text = dgvConsultaTabla.SelectedCells[6].Value.ToString();
            txtDiscapacidad.Text = dgvConsultaTabla.SelectedCells[7].Value.ToString();
            dtpFechaI.Value = Convert.ToDateTime(dgvConsultaTabla.SelectedCells[4].Value.ToString());
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

            //rellenar combo_box Localidad
            DataTable dtLocalidades = new DataTable();
            string llenarcmbL = "select ID,LOCALIDAD from LOCALIDADES";
            SqlDataAdapter adaptadorLoc = new SqlDataAdapter(llenarcmbL, conexion);
            adaptadorLoc.Fill(dtLocalidades);
            cmbLocalidad.DataSource = dtLocalidades;
            cmbLocalidad.DisplayMember = "LOCALIDAD";
            cmbLocalidad.ValueMember = "ID";

            //rellenar combo_box Departamento
            DataTable dtDepartamentos = new DataTable();
            string llenarcmbD = "select ID,DEPARTAMENTO from DEPARTAMENTOS";
            SqlDataAdapter adptadorDep = new SqlDataAdapter(llenarcmbD, conexion);
            adptadorDep.Fill(dtDepartamentos);
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.DataSource = dtDepartamentos;
            cmbDepartamento.DisplayMember = "DEPARTAMENTO";
            cmbDepartamento.ValueMember = "ID";
            //CAMBIAR FORMATO DATETIMEPICKER
            //dtpFechaI.Format = DateTimePickerFormat.Custom;
            dtpFechaI.CustomFormat = "dd-MM-yyyy";
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            conexion.Open();
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            string add = "insert into TRABAJADORES values (@CEDULA, @IdLocalidad, @IdDepartamento, @NOMBRES, @FECHA_INGRESO, @CARGO, @SUELDO_BASE, @PER_DISCAPACIDAD)";
            SqlCommand comando = new SqlCommand(add, conexion);
            comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
            comando.Parameters.AddWithValue("@IdLocalidad", cmbLocalidad.SelectedValue);
            comando.Parameters.AddWithValue("@IdDepartamento", cmbDepartamento.SelectedValue);
            comando.Parameters.AddWithValue("@NOMBRES", txtNombre.Text.ToUpper());
            comando.Parameters.AddWithValue("@FECHA_INGRESO", dtpFechaI.Value);
            comando.Parameters.AddWithValue("@CARGO", txtCargo.Text.ToUpper());
            comando.Parameters.AddWithValue("@SUELDO_BASE", sueldo);
            comando.Parameters.AddWithValue("@PER_DISCAPACIDAD", txtDiscapacidad.Text.ToUpper());
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Exitoso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            recargarTabla();
            conexion.Close();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            conexion.Open();
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            int flag = 0;
            string mod = "update TRABAJADORES set CEDULA=@CEDULA,Idlocalidad=@Idlocalidad, IdDepartamento=@IdDepartamento, NOMBRES=@NOMBRES," +
                "FECHA_INGRESO=@FECHA_INGRESO, CARGO=@CARGO, SUELDO_BASE=@SUELDO_BASE, PER_DISCAPACIDAD=@PER_DISCAPACIDAD";
            SqlCommand comando = new SqlCommand(mod, conexion);
            comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
            comando.Parameters.AddWithValue("@IdLocalidad", cmbLocalidad.SelectedValue);
            comando.Parameters.AddWithValue("@IdDepartamento", cmbDepartamento.SelectedValue);
            comando.Parameters.AddWithValue("@NOMBRES",txtNombre.Text);
            comando.Parameters.AddWithValue("@FECHA_INGRESO",dtpFechaI.Value);
            comando.Parameters.AddWithValue("@CARGO", txtCargo.Text);
            comando.Parameters.AddWithValue("@SUELDO_BASE", sueldo);
            comando.Parameters.AddWithValue("@PER_DISCAPACIDAD", txtDiscapacidad.Text.ToUpper());
            flag = comando.ExecuteNonQuery(); // 1 es que funko 0 es que no funko

            if (flag == 1)
            {
                MessageBox.Show("Registro modificado con exito", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (flag == 0)
            {
                MessageBox.Show("No se pudo modificar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            recargarTabla();
            conexion.Close();

        }

        private void dgvConsultaTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            int flag =0;
            conexion.Open();
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string consultaBorrar = "delete from TRABAJADORES where CEDULA = CEDULA";
            SqlCommand  comando = new SqlCommand(consultaBorrar, conexion);
            comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
            flag = comando.ExecuteNonQuery(); // 1 es que funko 0 es que no funko

            if (flag == 1)
            {
                MessageBox.Show("Registro eliminado con exito","Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (flag == 0) {
                MessageBox.Show("No se pudo borrar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                recargarTabla();
                conexion.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCargo.Clear();
            txtDiscapacidad.Clear();
            txtNombre.Clear();
            txtCargo.Clear();
            txtNombre.Clear();
            txtSueldo.Clear();
            txtCedula.Clear();
        }
    }
}