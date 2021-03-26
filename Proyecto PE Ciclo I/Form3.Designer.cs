
namespace Proyecto_PE_Ciclo_I
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.welcome_Label = new System.Windows.Forms.Label();
            this.login_Button = new System.Windows.Forms.Button();
            this.id_Box = new System.Windows.Forms.TextBox();
            this.pass_Box = new System.Windows.Forms.TextBox();
            this.id_Label = new System.Windows.Forms.Label();
            this.pass_Label = new System.Windows.Forms.Label();
            this.udb_Pic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRepositorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verManualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.udb_Pic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome_Label
            // 
            this.welcome_Label.AutoSize = true;
            this.welcome_Label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_Label.Font = new System.Drawing.Font("Arvo", 30F);
            this.welcome_Label.ForeColor = System.Drawing.Color.White;
            this.welcome_Label.Location = new System.Drawing.Point(31, 29);
            this.welcome_Label.Name = "welcome_Label";
            this.welcome_Label.Size = new System.Drawing.Size(242, 48);
            this.welcome_Label.TabIndex = 1;
            this.welcome_Label.Text = "Bienvenido";
            this.welcome_Label.Click += new System.EventHandler(this.welcome_Label_Click);
            // 
            // login_Button
            // 
            this.login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.login_Button.Location = new System.Drawing.Point(69, 186);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(158, 42);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Iniciar Sesion";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // id_Box
            // 
            this.id_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_Box.Location = new System.Drawing.Point(69, 98);
            this.id_Box.Name = "id_Box";
            this.id_Box.Size = new System.Drawing.Size(158, 26);
            this.id_Box.TabIndex = 3;
            // 
            // pass_Box
            // 
            this.pass_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pass_Box.Location = new System.Drawing.Point(69, 154);
            this.pass_Box.Name = "pass_Box";
            this.pass_Box.PasswordChar = '*';
            this.pass_Box.Size = new System.Drawing.Size(158, 26);
            this.pass_Box.TabIndex = 4;
            this.pass_Box.TextChanged += new System.EventHandler(this.pass_Box_TextChanged);
            this.pass_Box.Enter += new System.EventHandler(this.pass_Box_Enter);
            this.pass_Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_Box_KeyDown);
            // 
            // id_Label
            // 
            this.id_Label.AutoSize = true;
            this.id_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.id_Label.ForeColor = System.Drawing.Color.White;
            this.id_Label.Location = new System.Drawing.Point(88, 71);
            this.id_Label.Name = "id_Label";
            this.id_Label.Size = new System.Drawing.Size(123, 24);
            this.id_Label.TabIndex = 7;
            this.id_Label.Text = "ID de Usuario";
            // 
            // pass_Label
            // 
            this.pass_Label.AutoSize = true;
            this.pass_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pass_Label.ForeColor = System.Drawing.Color.White;
            this.pass_Label.Location = new System.Drawing.Point(93, 127);
            this.pass_Label.Name = "pass_Label";
            this.pass_Label.Size = new System.Drawing.Size(106, 24);
            this.pass_Label.TabIndex = 8;
            this.pass_Label.Text = "Contraseña";
            // 
            // udb_Pic
            // 
            this.udb_Pic.BackColor = System.Drawing.Color.Transparent;
            this.udb_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.udb_Pic.Image = global::Proyecto_PE_Ciclo_I.Properties.Resources.udb;
            this.udb_Pic.Location = new System.Drawing.Point(71, 234);
            this.udb_Pic.Name = "udb_Pic";
            this.udb_Pic.Size = new System.Drawing.Size(156, 57);
            this.udb_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.udb_Pic.TabIndex = 6;
            this.udb_Pic.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.verRepositorioToolStripMenuItem,
            this.verManualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // verRepositorioToolStripMenuItem
            // 
            this.verRepositorioToolStripMenuItem.Name = "verRepositorioToolStripMenuItem";
            this.verRepositorioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.verRepositorioToolStripMenuItem.Text = "Ver Repositorio";
            this.verRepositorioToolStripMenuItem.Click += new System.EventHandler(this.verRepositorioToolStripMenuItem_Click);
            // 
            // verManualDeUsuarioToolStripMenuItem
            // 
            this.verManualDeUsuarioToolStripMenuItem.Name = "verManualDeUsuarioToolStripMenuItem";
            this.verManualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.verManualDeUsuarioToolStripMenuItem.Text = "Ver Manual de Usuario";
            this.verManualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.verManualDeUsuarioToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(300, 303);
            this.Controls.Add(this.pass_Label);
            this.Controls.Add(this.id_Label);
            this.Controls.Add(this.udb_Pic);
            this.Controls.Add(this.pass_Box);
            this.Controls.Add(this.id_Box);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.welcome_Label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Iniciar Sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udb_Pic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_Label;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.TextBox id_Box;
        private System.Windows.Forms.TextBox pass_Box;
        private System.Windows.Forms.PictureBox udb_Pic;
        private System.Windows.Forms.Label id_Label;
        private System.Windows.Forms.Label pass_Label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRepositorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verManualDeUsuarioToolStripMenuItem;
    }
}