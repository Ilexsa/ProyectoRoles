namespace ProyectoRoles
{
    partial class FormSubirTrabajadores
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
            cmbLocalidad = new ComboBox();
            cmbDepartamento = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpFechaI = new DateTimePicker();
            label7 = new Label();
            txtSueldo = new TextBox();
            label8 = new Label();
            txtDiscapacidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaTabla).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultaTabla
            // 
            dgvConsultaTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaTabla.Location = new Point(12, 192);
            dgvConsultaTabla.Name = "dgvConsultaTabla";
            dgvConsultaTabla.ReadOnly = true;
            dgvConsultaTabla.RowTemplate.Height = 25;
            dgvConsultaTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaTabla.Size = new Size(776, 246);
            dgvConsultaTabla.TabIndex = 0;
            dgvConsultaTabla.CellClick += dataGridView1_CellContentClick;
            dgvConsultaTabla.CellContentClick += dgvConsultaTabla_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Cedula :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 56);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 85);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Cargo :";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(68, 24);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(265, 23);
            txtCedula.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(68, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(68, 82);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(265, 23);
            txtCargo.TabIndex = 6;
            // 
            // btnAgg
            // 
            btnAgg.Location = new Point(5, 163);
            btnAgg.Name = "btnAgg";
            btnAgg.Size = new Size(75, 23);
            btnAgg.TabIndex = 7;
            btnAgg.Text = "Agregar";
            btnAgg.UseVisualStyleBackColor = true;
            btnAgg.Click += btnAgg_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(377, 163);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 23);
            btnMod.TabIndex = 8;
            btnMod.Text = "Modificar";
            btnMod.TextAlign = ContentAlignment.BottomCenter;
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnEli
            // 
            btnEli.Location = new Point(713, 163);
            btnEli.Name = "btnEli";
            btnEli.Size = new Size(75, 23);
            btnEli.TabIndex = 9;
            btnEli.Text = "Eliminar";
            btnEli.UseVisualStyleBackColor = true;
            btnEli.Click += btnEli_Click;
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Location = new Point(472, 29);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(121, 23);
            cmbLocalidad.TabIndex = 10;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(472, 82);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(121, 23);
            cmbDepartamento.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 32);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 12;
            label4.Text = "Localidad :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 90);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 13;
            label5.Text = "Departamento :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(364, 130);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 14;
            label6.Text = "Fecha de Ingreso :";
            label6.Click += label6_Click;
            // 
            // dtpFechaI
            // 
            dtpFechaI.Format = DateTimePickerFormat.Custom;
            dtpFechaI.Location = new Point(472, 124);
            dtpFechaI.Name = "dtpFechaI";
            dtpFechaI.Size = new Size(200, 23);
            dtpFechaI.TabIndex = 15;
            dtpFechaI.Value = new DateTime(2023, 4, 26, 16, 6, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 113);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 16;
            label7.Text = "Sueldo :";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(68, 110);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(70, 23);
            txtSueldo.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 142);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 18;
            label8.Text = "Discapacidad :";
            // 
            // txtDiscapacidad
            // 
            txtDiscapacidad.Location = new Point(94, 139);
            txtDiscapacidad.Name = "txtDiscapacidad";
            txtDiscapacidad.Size = new Size(239, 23);
            txtDiscapacidad.TabIndex = 19;
            // 
            // FormSubirTrabajadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDiscapacidad);
            Controls.Add(label8);
            Controls.Add(txtSueldo);
            Controls.Add(label7);
            Controls.Add(dtpFechaI);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbDepartamento);
            Controls.Add(cmbLocalidad);
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
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormSubirTrabajadores";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resgristrar Trabajadores";
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
        private ComboBox cmbLocalidad;
        private ComboBox cmbDepartamento;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpFechaI;
        private Label label7;
        private TextBox txtSueldo;
        private Label label8;
        private TextBox txtDiscapacidad;
    }
}