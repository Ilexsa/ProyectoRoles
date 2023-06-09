﻿using System;
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
using FastReport;
using FastReport.Preview;
using System.Drawing.Printing;

namespace ProyectoRoles
{
    public partial class FormSubirTrabajadores : Form
    {
        public FormSubirTrabajadores()
        {
            InitializeComponent();
            txtNombre.TextChanged += new EventHandler(txtFiltro_TextChanged);
            FastReport.Report reporte = new FastReport.Report();
            PrintPreviewControl previewControl = new PrintPreviewControl();
            reporte.Load("C:\\Users\\jayala\\Documents\\ReportTrabajadores.frx");
        }
        SqlConnection conexion = new SqlConnection(ConexionBase.cadenaConexion);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DateTime fecha = Convert.ToDateTime(dgvConsultaTabla.SelectedCells[4].Value.ToString());
                txtCedula.Text = dgvConsultaTabla.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvConsultaTabla.SelectedCells[3].Value.ToString();
                txtCargo.Text = dgvConsultaTabla.SelectedCells[5].Value.ToString();
                txtSueldo.Text = dgvConsultaTabla.SelectedCells[6].Value.ToString();
                txtDiscapacidad.Text = dgvConsultaTabla.SelectedCells[7].Value.ToString();
                txtCorreo.Text = dgvConsultaTabla.SelectedCells[8].Value.ToString();
                dtpFechaI.Value = fecha;
                cmbLocalidad.SelectedValue = dgvConsultaTabla.SelectedCells[1].Value.ToString();
                cmbDepartamento.SelectedValue = dgvConsultaTabla.SelectedCells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No hay datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            try
            {
                double sueldo = Convert.ToDouble(txtSueldo.Text);
                string add = "insert into TRABAJADORES values (@CEDULA, @IdLocalidad, @IdDepartamento, @NOMBRES, @FECHA_INGRESO, @CARGO, @SUELDO_BASE, @PER_DISCAPACIDAD, @CORREO)";
                SqlCommand comando = new SqlCommand(add, conexion);
                comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                comando.Parameters.AddWithValue("@IdLocalidad", cmbLocalidad.SelectedValue);
                comando.Parameters.AddWithValue("@IdDepartamento", cmbDepartamento.SelectedValue);
                comando.Parameters.AddWithValue("@NOMBRES", txtNombre.Text.ToUpper());
                comando.Parameters.AddWithValue("@FECHA_INGRESO", dtpFechaI.Value);
                comando.Parameters.AddWithValue("@CARGO", txtCargo.Text.ToUpper());
                comando.Parameters.AddWithValue("@SUELDO_BASE", sueldo);
                comando.Parameters.AddWithValue("@PER_DISCAPACIDAD", txtDiscapacidad.Text.ToUpper());
                comando.Parameters.AddWithValue("@CORREO", txtCorreo.Text.ToLower());
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                double sueldo = Convert.ToDouble(txtSueldo.Text);
                int flag = 0;
                string mod = "update TRABAJADORES set Idlocalidad=@Idlocalidad, IdDepartamento=@IdDepartamento, NOMBRES=@NOMBRES," +
                "FECHA_INGRESO=@FECHA_INGRESO, CARGO=@CARGO, SUELDO_BASE=@SUELDO_BASE, PER_DISCAPACIDAD=@PER_DISCAPACIDAD, CORREO=@CORREO " +
                "where CEDULA=@CEDULA";
                SqlCommand comando = new SqlCommand(mod, conexion);
                comando.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                comando.Parameters.AddWithValue("@IdLocalidad", cmbLocalidad.SelectedValue);
                comando.Parameters.AddWithValue("@IdDepartamento", cmbDepartamento.SelectedValue);
                comando.Parameters.AddWithValue("@NOMBRES", txtNombre.Text);
                comando.Parameters.AddWithValue("@FECHA_INGRESO", dtpFechaI.Value);
                comando.Parameters.AddWithValue("@CARGO", txtCargo.Text);
                comando.Parameters.AddWithValue("@SUELDO_BASE", sueldo);
                comando.Parameters.AddWithValue("@PER_DISCAPACIDAD", txtDiscapacidad.Text.ToUpper());
                comando.Parameters.AddWithValue("@CORREO", txtCorreo.Text.ToLower());
                flag = comando.ExecuteNonQuery(); // 1 es que funko 0 es que no funko
                // Buscamos la fila que deseamos actualizar
                string consulta = "select count(*) from TRABAJADORES where CEDULA=@CEDULA";
                SqlCommand comandoConsulta = new SqlCommand(consulta, conexion);
                comandoConsulta.Parameters.AddWithValue("@CEDULA", txtCedula.Text);
                int count = Convert.ToInt32(comandoConsulta.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("La cédula no existe en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            conexion.Open();
            if (txtCedula.Text == "")
            {
                MessageBox.Show("No se puede eliminar un registro sin el numero de cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtCedula.Text != "")
            {
                try
                {
                    int flag = 0;
                    string cedula = txtCedula.Text;
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?",
                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        string consultaBorrar = "DELETE FROM TRABAJADORES WHERE CEDULA=@CEDULA";
                        SqlCommand comando = new SqlCommand(consultaBorrar, conexion);
                        comando.Parameters.AddWithValue("@CEDULA", cedula);
                        flag = comando.ExecuteNonQuery(); // 1 es que funko 0 es que no funko
                    }

                    if (flag == 1)
                    {
                        MessageBox.Show("Registro eliminado con exito", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (flag == 0)
                    {
                        //MessageBox.Show("No se pudo borrar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    recargarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conexion.Close();

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
            txtCorreo.Clear();
        }

        private void chkDiscapacidad_CheckedChanged(object sender, EventArgs e)
        {
            txtDiscapacidad.Enabled = chkDiscapacidad.Checked;
            label8.Enabled = chkDiscapacidad.Checked;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNombre.Text.Trim(); // Obtener el texto del TextBox y quitar espacios en blanco

            // Obtener la tabla que se utiliza como fuente de datos del DataGridView
            DataTable tabla = ((DataTable)dgvConsultaTabla.DataSource);

            // Si el filtro está vacío, se quita el filtro y se muestran todos los datos
            if (string.IsNullOrEmpty(filtro))
            {
                tabla.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                // Se ajusta el filtro según la columna que quieras filtrar, en este ejemplo se filtra por la columna "Nombre"
                tabla.DefaultView.RowFilter = $"NOMBRES LIKE '%{filtro}%'";
            }

            // Actualizar el DataGridView
            dgvConsultaTabla.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FastReport.Report reporte =new FastReport.Report())
            {
                reporte.Load("C:\\Users\\jayala\\Documents\\ReportTrabajadores.frx");
                reporte.RegisterData(DataTable,"TRABAJADORES");
            }
        }
    }
}