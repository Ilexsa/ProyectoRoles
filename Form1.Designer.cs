namespace ProyectoRoles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRuta = new Label();
            txtRuta = new TextBox();
            btnBuscarArchvo = new Button();
            menuStrip1 = new MenuStrip();
            procesosToolStripMenuItem = new ToolStripMenuItem();
            correosMasivosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            correoIndividualToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            basesToolStripMenuItem = new ToolStripMenuItem();
            subirRolesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            consultarBaseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(53, 66);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(97, 15);
            lblRuta.TabIndex = 0;
            lblRuta.Text = "Ruta de Archivo :";
            lblRuta.Click += label1_Click;
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(156, 63);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(315, 23);
            txtRuta.TabIndex = 1;
            txtRuta.TextChanged += textBox1_TextChanged;
            // 
            // btnBuscarArchvo
            // 
            btnBuscarArchvo.Location = new Point(477, 63);
            btnBuscarArchvo.Name = "btnBuscarArchvo";
            btnBuscarArchvo.Size = new Size(75, 23);
            btnBuscarArchvo.TabIndex = 2;
            btnBuscarArchvo.Text = "Buscar";
            btnBuscarArchvo.UseVisualStyleBackColor = true;
            btnBuscarArchvo.Click += btnBuscarArchvo_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { procesosToolStripMenuItem, basesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { correosMasivosToolStripMenuItem, toolStripSeparator1, correoIndividualToolStripMenuItem, toolStripSeparator2 });
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(66, 20);
            procesosToolStripMenuItem.Text = "Procesos";
            procesosToolStripMenuItem.Click += procesosToolStripMenuItem_Click;
            // 
            // correosMasivosToolStripMenuItem
            // 
            correosMasivosToolStripMenuItem.Name = "correosMasivosToolStripMenuItem";
            correosMasivosToolStripMenuItem.Size = new Size(180, 22);
            correosMasivosToolStripMenuItem.Text = "Correos Masivos";
            correosMasivosToolStripMenuItem.Click += correosMasivosToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // correoIndividualToolStripMenuItem
            // 
            correoIndividualToolStripMenuItem.Name = "correoIndividualToolStripMenuItem";
            correoIndividualToolStripMenuItem.Size = new Size(180, 22);
            correoIndividualToolStripMenuItem.Text = "Correo Individual";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // basesToolStripMenuItem
            // 
            basesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { subirRolesToolStripMenuItem, toolStripSeparator3, consultarBaseToolStripMenuItem, toolStripSeparator4 });
            basesToolStripMenuItem.Name = "basesToolStripMenuItem";
            basesToolStripMenuItem.Size = new Size(43, 20);
            basesToolStripMenuItem.Text = "Base";
            // 
            // subirRolesToolStripMenuItem
            // 
            subirRolesToolStripMenuItem.Name = "subirRolesToolStripMenuItem";
            subirRolesToolStripMenuItem.Size = new Size(152, 22);
            subirRolesToolStripMenuItem.Text = "Subir roles";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(149, 6);
            // 
            // consultarBaseToolStripMenuItem
            // 
            consultarBaseToolStripMenuItem.Name = "consultarBaseToolStripMenuItem";
            consultarBaseToolStripMenuItem.Size = new Size(152, 22);
            consultarBaseToolStripMenuItem.Text = "Consultar Base";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(149, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarArchvo);
            Controls.Add(txtRuta);
            Controls.Add(lblRuta);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRuta;
        private TextBox txtRuta;
        private Button btnBuscarArchvo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem correosMasivosToolStripMenuItem;
        private ToolStripMenuItem basesToolStripMenuItem;
        private ToolStripMenuItem subirRolesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem correoIndividualToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem consultarBaseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}