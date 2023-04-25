namespace ProyectoRoles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void correosMasivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCmasivos formCmasivos = new FormCmasivos();
            formCmasivos.ShowDialog();
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el sistema?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void correoIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCIndividual formCIndividual = new FormCIndividual();
            formCIndividual.ShowDialog();
        }

        private void consultarBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarBases formConsultarBases = new FormConsultarBases();
            formConsultarBases.ShowDialog();
        }

        private void subirRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubirRol formSubirRoles = new FormSubirRol();
            formSubirRoles.ShowDialog();
        }

        private void subirIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubirIndividdual formSubirIndividdual = new FormSubirIndividdual();
            formSubirIndividdual.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConexionBase conexion = new ConexionBase();
            //conexion.abrir();
        }

        private void subirTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}