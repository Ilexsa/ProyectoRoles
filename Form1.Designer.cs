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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            menuStrip1.BackColor = Color.Azure;
            menuStrip1.Items.AddRange(new ToolStripItem[] { procesosToolStripMenuItem, basesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1424, 32);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.CheckOnClick = true;
            procesosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { correosMasivosToolStripMenuItem, toolStripSeparator1, correoIndividualToolStripMenuItem, toolStripSeparator2 });
            procesosToolStripMenuItem.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(80, 26);
            procesosToolStripMenuItem.Text = "Procesos";
            procesosToolStripMenuItem.Click += procesosToolStripMenuItem_Click;
            // 
            // correosMasivosToolStripMenuItem
            // 
            correosMasivosToolStripMenuItem.Name = "correosMasivosToolStripMenuItem";
            correosMasivosToolStripMenuItem.Size = new Size(199, 26);
            correosMasivosToolStripMenuItem.Text = "Correos Masivos";
            correosMasivosToolStripMenuItem.Click += correosMasivosToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(196, 6);
            // 
            // correoIndividualToolStripMenuItem
            // 
            correoIndividualToolStripMenuItem.Name = "correoIndividualToolStripMenuItem";
            correoIndividualToolStripMenuItem.Size = new Size(199, 26);
            correoIndividualToolStripMenuItem.Text = "Correo Individual";
            correoIndividualToolStripMenuItem.Click += correoIndividualToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(196, 6);
            // 
            // basesToolStripMenuItem
            // 
            basesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarBaseToolStripMenuItem, toolStripSeparator3, subirRolesToolStripMenuItem, toolStripSeparator4, subirIndividualToolStripMenuItem, toolStripSeparator5 });
            basesToolStripMenuItem.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            basesToolStripMenuItem.Name = "basesToolStripMenuItem";
            basesToolStripMenuItem.Size = new Size(53, 26);
            basesToolStripMenuItem.Text = "Base";
            // 
            // consultarBaseToolStripMenuItem
            // 
            consultarBaseToolStripMenuItem.Name = "consultarBaseToolStripMenuItem";
            consultarBaseToolStripMenuItem.Size = new Size(209, 26);
            consultarBaseToolStripMenuItem.Text = "Subir Trabajadores";
            consultarBaseToolStripMenuItem.Click += consultarBaseToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(206, 6);
            // 
            // subirRolesToolStripMenuItem
            // 
            subirRolesToolStripMenuItem.Name = "subirRolesToolStripMenuItem";
            subirRolesToolStripMenuItem.Size = new Size(209, 26);
            subirRolesToolStripMenuItem.Text = "Subir roles";
            subirRolesToolStripMenuItem.Click += subirRolesToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(206, 6);
            // 
            // subirIndividualToolStripMenuItem
            // 
            subirIndividualToolStripMenuItem.Name = "subirIndividualToolStripMenuItem";
            subirIndividualToolStripMenuItem.Size = new Size(209, 26);
            subirIndividualToolStripMenuItem.Text = "Subir Individual";
            subirIndividualToolStripMenuItem.Click += subirIndividualToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(206, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(53, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = Properties.Resources._18771_scaled__1_;
            ClientSize = new Size(1424, 835);
            Controls.Add(menuStrip1);
            Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
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