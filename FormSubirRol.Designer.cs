﻿namespace ProyectoRoles
{
    partial class FormSubirRol
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
            label1 = new Label();
            txtRutaArchivo = new TextBox();
            btnBuscarArchivo = new Button();
            label2 = new Label();
            cboHojas = new ComboBox();
            btnMostrarHojas = new Button();
            dgvDatos = new DataGridView();
            btnSubirDatos = new Button();
            menuStrip1 = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 57);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Ruta del Archivo :";
            // 
            // txtRutaArchivo
            // 
            txtRutaArchivo.Location = new Point(196, 57);
            txtRutaArchivo.Name = "txtRutaArchivo";
            txtRutaArchivo.Size = new Size(277, 23);
            txtRutaArchivo.TabIndex = 1;
            // 
            // btnBuscarArchivo
            // 
            btnBuscarArchivo.Location = new Point(479, 57);
            btnBuscarArchivo.Name = "btnBuscarArchivo";
            btnBuscarArchivo.Size = new Size(75, 23);
            btnBuscarArchivo.TabIndex = 2;
            btnBuscarArchivo.Text = "Buscar";
            btnBuscarArchivo.UseVisualStyleBackColor = true;
            btnBuscarArchivo.Click += btnBuscarArchivo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 126);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 3;
            label2.Text = "Hojas Encontradas :";
            // 
            // cboHojas
            // 
            cboHojas.FormattingEnabled = true;
            cboHojas.Location = new Point(196, 123);
            cboHojas.Name = "cboHojas";
            cboHojas.Size = new Size(277, 23);
            cboHojas.TabIndex = 4;
            // 
            // btnMostrarHojas
            // 
            btnMostrarHojas.Location = new Point(479, 123);
            btnMostrarHojas.Name = "btnMostrarHojas";
            btnMostrarHojas.Size = new Size(75, 23);
            btnMostrarHojas.TabIndex = 5;
            btnMostrarHojas.Text = "Mostrar";
            btnMostrarHojas.UseVisualStyleBackColor = true;
            btnMostrarHojas.Click += btnMostrarHojas_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(12, 152);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(859, 308);
            dgvDatos.TabIndex = 6;
            // 
            // btnSubirDatos
            // 
            btnSubirDatos.Location = new Point(796, 491);
            btnSubirDatos.Name = "btnSubirDatos";
            btnSubirDatos.Size = new Size(75, 23);
            btnSubirDatos.TabIndex = 7;
            btnSubirDatos.Text = "Subir";
            btnSubirDatos.UseVisualStyleBackColor = true;
            btnSubirDatos.Click += btnSubirDatos_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(883, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // FormSubirRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 526);
            Controls.Add(btnSubirDatos);
            Controls.Add(dgvDatos);
            Controls.Add(btnMostrarHojas);
            Controls.Add(cboHojas);
            Controls.Add(label2);
            Controls.Add(btnBuscarArchivo);
            Controls.Add(txtRutaArchivo);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormSubirRol";
            Text = "FormSubirRol";
            Load += FormSubirRol_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRutaArchivo;
        private Button btnBuscarArchivo;
        private Label label2;
        private ComboBox cboHojas;
        private Button btnMostrarHojas;
        private DataGridView dgvDatos;
        private Button btnSubirDatos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}