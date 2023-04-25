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
            menuStrip1 = new MenuStrip();
            procesosToolStripMenuItem = new ToolStripMenuItem();
            correosMasivosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            correoIndividualToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            basesToolStripMenuItem = new ToolStripMenuItem();
            consultarBaseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            subirRolesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            subirIndividualToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 255, 255);
            menuStrip1.Items.AddRange(new ToolStripItem[] { procesosToolStripMenuItem, basesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.CheckOnClick = true;
            procesosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { correosMasivosToolStripMenuItem, toolStripSeparator1, correoIndividualToolStripMenuItem, toolStripSeparator2 });
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(66, 20);
            procesosToolStripMenuItem.Text = "Procesos";
            procesosToolStripMenuItem.Click += procesosToolStripMenuItem_Click;
            // 
            // correosMasivosToolStripMenuItem
            // 
            correosMasivosToolStripMenuItem.Name = "correosMasivosToolStripMenuItem";
            correosMasivosToolStripMenuItem.Size = new Size(165, 22);
            correosMasivosToolStripMenuItem.Text = "Correos Masivos";
            correosMasivosToolStripMenuItem.Click += correosMasivosToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(162, 6);
            // 
            // correoIndividualToolStripMenuItem
            // 
            correoIndividualToolStripMenuItem.Name = "correoIndividualToolStripMenuItem";
            correoIndividualToolStripMenuItem.Size = new Size(165, 22);
            correoIndividualToolStripMenuItem.Text = "Correo Individual";
            correoIndividualToolStripMenuItem.Click += correoIndividualToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(162, 6);
            // 
            // basesToolStripMenuItem
            // 
            basesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarBaseToolStripMenuItem, toolStripSeparator3, subirRolesToolStripMenuItem, toolStripSeparator4, subirIndividualToolStripMenuItem, toolStripSeparator5 });
            basesToolStripMenuItem.Name = "basesToolStripMenuItem";
            basesToolStripMenuItem.Size = new Size(43, 20);
            basesToolStripMenuItem.Text = "Base";
            // 
            // consultarBaseToolStripMenuItem
            // 
            consultarBaseToolStripMenuItem.Name = "consultarBaseToolStripMenuItem";
            consultarBaseToolStripMenuItem.Size = new Size(180, 22);
            consultarBaseToolStripMenuItem.Text = "Subir Trabajadores";
            consultarBaseToolStripMenuItem.Click += consultarBaseToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // subirRolesToolStripMenuItem
            // 
            subirRolesToolStripMenuItem.Name = "subirRolesToolStripMenuItem";
            subirRolesToolStripMenuItem.Size = new Size(180, 22);
            subirRolesToolStripMenuItem.Text = "Subir roles";
            subirRolesToolStripMenuItem.Click += subirRolesToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // subirIndividualToolStripMenuItem
            // 
            subirIndividualToolStripMenuItem.Name = "subirIndividualToolStripMenuItem";
            subirIndividualToolStripMenuItem.Size = new Size(180, 22);
            subirIndividualToolStripMenuItem.Text = "Subir Individual";
            subirIndividualToolStripMenuItem.Click += subirIndividualToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(177, 6);
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
            AutoSize = true;
            BackgroundImage = Properties.Resources.Untitled_1_min_2;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Sistema Roles";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private ToolStripMenuItem subirIndividualToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
    }
}