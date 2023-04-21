namespace ProyectoRoles
{
    partial class FormConsultarBases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvConsultaTabla = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            btnAgg = new Button();
            btnMod = new Button();
            btnEli = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaTabla).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultaTabla
            // 
            dgvConsultaTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaTabla.Location = new Point(102, 192);
            dgvConsultaTabla.Name = "dgvConsultaTabla";
            dgvConsultaTabla.ReadOnly = true;
            dgvConsultaTabla.RowTemplate.Height = 25;
            dgvConsultaTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaTabla.Size = new Size(581, 246);
            dgvConsultaTabla.TabIndex = 0;
            dgvConsultaTabla.CellClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Cedula :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 56);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 85);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Cargo :";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(177, 24);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(265, 23);
            txtCedula.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(177, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(177, 82);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(265, 23);
            txtCargo.TabIndex = 6;
            // 
            // btnAgg
            // 
            btnAgg.Location = new Point(102, 124);
            btnAgg.Name = "btnAgg";
            btnAgg.Size = new Size(75, 23);
            btnAgg.TabIndex = 7;
            btnAgg.Text = "Agregar";
            btnAgg.UseVisualStyleBackColor = true;
            btnAgg.Click += btnAgg_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(367, 124);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 23);
            btnMod.TabIndex = 8;
            btnMod.Text = "Modificar";
            btnMod.TextAlign = ContentAlignment.BottomCenter;
            btnMod.UseVisualStyleBackColor = true;
            // 
            // btnEli
            // 
            btnEli.Location = new Point(608, 124);
            btnEli.Name = "btnEli";
            btnEli.Size = new Size(75, 23);
            btnEli.TabIndex = 9;
            btnEli.Text = "Eliminar";
            btnEli.UseVisualStyleBackColor = true;
            // 
            // FormConsultarBases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEli);
            Controls.Add(btnMod);
            Controls.Add(btnAgg);
            Controls.Add(txtCargo);
            Controls.Add(txtNombre);
            Controls.Add(txtCedula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvConsultaTabla);
            Name = "FormConsultarBases";
            Text = "Consulta de Bases";
            Load += FormConsultarBases_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultaTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConsultaTabla;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private TextBox txtCargo;
        private Button btnAgg;
        private Button btnMod;
        private Button btnEli;
    }
}