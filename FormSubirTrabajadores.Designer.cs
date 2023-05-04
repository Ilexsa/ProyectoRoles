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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubirTrabajadores));
            dgvConsultaTabla = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            btnAgg = new Button();
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
            btnLimpiar = new Button();
            chkDiscapacidad = new CheckBox();
            label9 = new Label();
            txtCorreo = new TextBox();
            btnMod = new Button();
            btnEli = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaTabla).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultaTabla
            // 
            dgvConsultaTabla.AllowUserToAddRows = false;
            dgvConsultaTabla.AllowUserToDeleteRows = false;
            dgvConsultaTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultaTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaTabla.Location = new Point(533, 13);
            dgvConsultaTabla.Margin = new Padding(3, 4, 3, 4);
            dgvConsultaTabla.Name = "dgvConsultaTabla";
            dgvConsultaTabla.RowTemplate.Height = 25;
            dgvConsultaTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaTabla.Size = new Size(921, 382);
            dgvConsultaTabla.TabIndex = 0;
            dgvConsultaTabla.CellClick += dataGridView1_CellContentClick;
            dgvConsultaTabla.CellContentClick += dgvConsultaTabla_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 54);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 1;
            label1.Text = "Cedula :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 86);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 119);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 3;
            label3.Text = "Cargo :";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = SystemColors.Control;
            txtCedula.Location = new Point(107, 50);
            txtCedula.Margin = new Padding(3, 4, 3, 4);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(302, 24);
            txtCedula.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 82);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(302, 24);
            txtNombre.TabIndex = 5;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(107, 115);
            txtCargo.Margin = new Padding(3, 4, 3, 4);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(302, 24);
            txtCargo.TabIndex = 6;
            // 
            // btnAgg
            // 
            btnAgg.FlatAppearance.BorderSize = 0;
            btnAgg.FlatStyle = FlatStyle.Flat;
            btnAgg.Image = Properties.Resources.agregar_usuario__1_;
            btnAgg.Location = new Point(82, 4);
            btnAgg.Margin = new Padding(0);
            btnAgg.Name = "btnAgg";
            btnAgg.Size = new Size(43, 43);
            btnAgg.TabIndex = 7;
            btnAgg.UseVisualStyleBackColor = true;
            btnAgg.Click += btnAgg_Click;
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Location = new Point(107, 231);
            cmbLocalidad.Margin = new Padding(3, 4, 3, 4);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(138, 25);
            cmbLocalidad.TabIndex = 10;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(387, 231);
            cmbDepartamento.Margin = new Padding(3, 4, 3, 4);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(138, 25);
            cmbDepartamento.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 234);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 12;
            label4.Text = "Localidad :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 234);
            label5.Name = "label5";
            label5.Size = new Size(108, 17);
            label5.TabIndex = 13;
            label5.Text = "Departamento :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 285);
            label6.Name = "label6";
            label6.Size = new Size(119, 17);
            label6.TabIndex = 14;
            label6.Text = "Fecha de Ingreso :";
            // 
            // dtpFechaI
            // 
            dtpFechaI.Format = DateTimePickerFormat.Custom;
            dtpFechaI.Location = new Point(129, 285);
            dtpFechaI.Margin = new Padding(3, 4, 3, 4);
            dtpFechaI.Name = "dtpFechaI";
            dtpFechaI.Size = new Size(228, 24);
            dtpFechaI.TabIndex = 15;
            dtpFechaI.Value = new DateTime(2023, 4, 26, 16, 6, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 150);
            label7.Name = "label7";
            label7.Size = new Size(57, 17);
            label7.TabIndex = 16;
            label7.Text = "Sueldo :";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(107, 148);
            txtSueldo.Margin = new Padding(3, 4, 3, 4);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(125, 24);
            txtSueldo.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new Point(6, 365);
            label8.Name = "label8";
            label8.Size = new Size(96, 17);
            label8.TabIndex = 18;
            label8.Text = "Discapacidad :";
            // 
            // txtDiscapacidad
            // 
            txtDiscapacidad.Enabled = false;
            txtDiscapacidad.Location = new Point(109, 361);
            txtDiscapacidad.Margin = new Padding(3, 4, 3, 4);
            txtDiscapacidad.Name = "txtDiscapacidad";
            txtDiscapacidad.Size = new Size(273, 24);
            txtDiscapacidad.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = Properties.Resources.limpio;
            btnLimpiar.Location = new Point(387, 4);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(47, 43);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // chkDiscapacidad
            // 
            chkDiscapacidad.AutoSize = true;
            chkDiscapacidad.Location = new Point(14, 333);
            chkDiscapacidad.Margin = new Padding(3, 4, 3, 4);
            chkDiscapacidad.Name = "chkDiscapacidad";
            chkDiscapacidad.Size = new Size(296, 21);
            chkDiscapacidad.TabIndex = 21;
            chkDiscapacidad.Text = "¿El colaborador poseé alguna discapacidad?";
            chkDiscapacidad.UseVisualStyleBackColor = true;
            chkDiscapacidad.CheckedChanged += chkDiscapacidad_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 183);
            label9.Name = "label9";
            label9.Size = new Size(58, 17);
            label9.TabIndex = 22;
            label9.Text = "Correo :";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(107, 180);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(302, 24);
            txtCorreo.TabIndex = 23;
            // 
            // btnMod
            // 
            btnMod.FlatAppearance.BorderSize = 0;
            btnMod.FlatStyle = FlatStyle.Flat;
            btnMod.Image = Properties.Resources.boton_editar;
            btnMod.Location = new Point(182, 4);
            btnMod.Margin = new Padding(3, 4, 3, 4);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(50, 43);
            btnMod.TabIndex = 8;
            btnMod.TextAlign = ContentAlignment.BottomCenter;
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnEli
            // 
            btnEli.FlatAppearance.BorderSize = 0;
            btnEli.FlatStyle = FlatStyle.Flat;
            btnEli.Image = Properties.Resources.quitar_usuario;
            btnEli.Location = new Point(279, 4);
            btnEli.Margin = new Padding(3, 4, 3, 4);
            btnEli.Name = "btnEli";
            btnEli.Size = new Size(47, 43);
            btnEli.TabIndex = 9;
            btnEli.UseVisualStyleBackColor = true;
            btnEli.Click += btnEli_Click;
            // 
            // FormSubirTrabajadores
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1467, 409);
            Controls.Add(txtCorreo);
            Controls.Add(label9);
            Controls.Add(chkDiscapacidad);
            Controls.Add(btnLimpiar);
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
            Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormSubirTrabajadores";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Trabajadores";
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
        private Button btnLimpiar;
        private CheckBox chkDiscapacidad;
        private Label label9;
        private TextBox txtCorreo;
        private Button btnMod;
        private Button btnEli;
    }
}