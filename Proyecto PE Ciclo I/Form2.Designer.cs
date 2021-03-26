
namespace Proyecto_PE_Ciclo_I
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.welcome_Label = new System.Windows.Forms.Label();
            this.info_Button = new System.Windows.Forms.Button();
            this.github_Button = new System.Windows.Forms.Button();
            this.cash_Button = new System.Windows.Forms.Button();
            this.inventory_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.billLocation_Button = new System.Windows.Forms.Button();
            this.lastBill_Button = new System.Windows.Forms.Button();
            this.invlocation_Button = new System.Windows.Forms.Button();
            this.logout_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUbicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUltimaFacturaGuardadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userlocation_Button = new System.Windows.Forms.Button();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRepositorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verManualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome_Label
            // 
            this.welcome_Label.AutoSize = true;
            this.welcome_Label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_Label.Font = new System.Drawing.Font("Arvo", 20F);
            this.welcome_Label.ForeColor = System.Drawing.Color.White;
            this.welcome_Label.Location = new System.Drawing.Point(12, 34);
            this.welcome_Label.Name = "welcome_Label";
            this.welcome_Label.Size = new System.Drawing.Size(165, 33);
            this.welcome_Label.TabIndex = 0;
            this.welcome_Label.Text = "Bienvenido";
            // 
            // info_Button
            // 
            this.info_Button.BackColor = System.Drawing.Color.Transparent;
            this.info_Button.ForeColor = System.Drawing.Color.Black;
            this.info_Button.Location = new System.Drawing.Point(378, 188);
            this.info_Button.Name = "info_Button";
            this.info_Button.Size = new System.Drawing.Size(32, 32);
            this.info_Button.TabIndex = 1;
            this.info_Button.UseVisualStyleBackColor = false;
            this.info_Button.Click += new System.EventHandler(this.info_Button_Click);
            // 
            // github_Button
            // 
            this.github_Button.BackColor = System.Drawing.Color.Transparent;
            this.github_Button.ForeColor = System.Drawing.Color.Black;
            this.github_Button.Location = new System.Drawing.Point(416, 188);
            this.github_Button.Name = "github_Button";
            this.github_Button.Size = new System.Drawing.Size(32, 32);
            this.github_Button.TabIndex = 2;
            this.github_Button.UseVisualStyleBackColor = false;
            this.github_Button.Click += new System.EventHandler(this.github_Button_Click);
            // 
            // cash_Button
            // 
            this.cash_Button.Location = new System.Drawing.Point(12, 73);
            this.cash_Button.Name = "cash_Button";
            this.cash_Button.Size = new System.Drawing.Size(115, 97);
            this.cash_Button.TabIndex = 3;
            this.cash_Button.Text = "Facturar";
            this.cash_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cash_Button.UseVisualStyleBackColor = true;
            // 
            // inventory_Button
            // 
            this.inventory_Button.Location = new System.Drawing.Point(12, 176);
            this.inventory_Button.Name = "inventory_Button";
            this.inventory_Button.Size = new System.Drawing.Size(115, 97);
            this.inventory_Button.TabIndex = 4;
            this.inventory_Button.Text = "Inventariar";
            this.inventory_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inventory_Button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Proyecto_PE_Ciclo_I.Properties.Resources.udb;
            this.pictureBox1.Location = new System.Drawing.Point(327, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // billLocation_Button
            // 
            this.billLocation_Button.Location = new System.Drawing.Point(133, 73);
            this.billLocation_Button.Name = "billLocation_Button";
            this.billLocation_Button.Size = new System.Drawing.Size(115, 47);
            this.billLocation_Button.TabIndex = 6;
            this.billLocation_Button.Text = "Abrir Ubicacion de las Facturas Guardadas";
            this.billLocation_Button.UseVisualStyleBackColor = true;
            this.billLocation_Button.Click += new System.EventHandler(this.billLocation_Button_Click);
            // 
            // lastBill_Button
            // 
            this.lastBill_Button.Location = new System.Drawing.Point(133, 123);
            this.lastBill_Button.Name = "lastBill_Button";
            this.lastBill_Button.Size = new System.Drawing.Size(115, 47);
            this.lastBill_Button.TabIndex = 7;
            this.lastBill_Button.Text = "Ver la Ultima Factura Guardada";
            this.lastBill_Button.UseVisualStyleBackColor = true;
            this.lastBill_Button.Click += new System.EventHandler(this.lastBill_Button_Click);
            // 
            // invlocation_Button
            // 
            this.invlocation_Button.Location = new System.Drawing.Point(133, 226);
            this.invlocation_Button.Name = "invlocation_Button";
            this.invlocation_Button.Size = new System.Drawing.Size(115, 47);
            this.invlocation_Button.TabIndex = 8;
            this.invlocation_Button.Text = "Abrir archivo de inventario";
            this.invlocation_Button.UseVisualStyleBackColor = true;
            this.invlocation_Button.Click += new System.EventHandler(this.invlocation_Button_Click);
            // 
            // logout_Button
            // 
            this.logout_Button.Location = new System.Drawing.Point(378, 123);
            this.logout_Button.Name = "logout_Button";
            this.logout_Button.Size = new System.Drawing.Size(70, 47);
            this.logout_Button.TabIndex = 9;
            this.logout_Button.Text = "Cerrar Sesion";
            this.logout_Button.UseVisualStyleBackColor = true;
            this.logout_Button.Click += new System.EventHandler(this.logout_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.ForeColor = System.Drawing.Color.Red;
            this.exit_Button.Location = new System.Drawing.Point(378, 73);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(70, 47);
            this.exit_Button.TabIndex = 10;
            this.exit_Button.Text = "SALIR";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.archivosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 11;
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
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
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
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verUbicacionToolStripMenuItem,
            this.verUltimaFacturaGuardadaToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoDeInventarioToolStripMenuItem,
            this.abrirArchivoDeUsuariosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // verUbicacionToolStripMenuItem
            // 
            this.verUbicacionToolStripMenuItem.Name = "verUbicacionToolStripMenuItem";
            this.verUbicacionToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.verUbicacionToolStripMenuItem.Text = "Ver ubicacion";
            this.verUbicacionToolStripMenuItem.Click += new System.EventHandler(this.verUbicacionToolStripMenuItem_Click);
            // 
            // verUltimaFacturaGuardadaToolStripMenuItem
            // 
            this.verUltimaFacturaGuardadaToolStripMenuItem.Name = "verUltimaFacturaGuardadaToolStripMenuItem";
            this.verUltimaFacturaGuardadaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.verUltimaFacturaGuardadaToolStripMenuItem.Text = "Ver ultima factura guardada";
            // 
            // abrirArchivoDeInventarioToolStripMenuItem
            // 
            this.abrirArchivoDeInventarioToolStripMenuItem.Name = "abrirArchivoDeInventarioToolStripMenuItem";
            this.abrirArchivoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.abrirArchivoDeInventarioToolStripMenuItem.Text = "Abrir Archivo de Inventario";
            this.abrirArchivoDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoDeInventarioToolStripMenuItem_Click);
            // 
            // abrirArchivoDeUsuariosToolStripMenuItem
            // 
            this.abrirArchivoDeUsuariosToolStripMenuItem.Name = "abrirArchivoDeUsuariosToolStripMenuItem";
            this.abrirArchivoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.abrirArchivoDeUsuariosToolStripMenuItem.Text = "Abrir Archivo de Usuarios";
            this.abrirArchivoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoDeUsuariosToolStripMenuItem_Click);
            // 
            // userlocation_Button
            // 
            this.userlocation_Button.Location = new System.Drawing.Point(133, 176);
            this.userlocation_Button.Name = "userlocation_Button";
            this.userlocation_Button.Size = new System.Drawing.Size(115, 47);
            this.userlocation_Button.TabIndex = 12;
            this.userlocation_Button.Text = "Abrir archivo de Usuarios";
            this.userlocation_Button.UseVisualStyleBackColor = true;
            this.userlocation_Button.Click += new System.EventHandler(this.userlocation_Button_Click);
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
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(460, 281);
            this.Controls.Add(this.userlocation_Button);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.logout_Button);
            this.Controls.Add(this.invlocation_Button);
            this.Controls.Add(this.lastBill_Button);
            this.Controls.Add(this.billLocation_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inventory_Button);
            this.Controls.Add(this.cash_Button);
            this.Controls.Add(this.github_Button);
            this.Controls.Add(this.info_Button);
            this.Controls.Add(this.welcome_Label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Inicio: Sistema de Facturacion e Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_Label;
        private System.Windows.Forms.Button info_Button;
        private System.Windows.Forms.Button github_Button;
        private System.Windows.Forms.Button cash_Button;
        private System.Windows.Forms.Button inventory_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button billLocation_Button;
        private System.Windows.Forms.Button lastBill_Button;
        private System.Windows.Forms.Button invlocation_Button;
        private System.Windows.Forms.Button logout_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUbicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUltimaFacturaGuardadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button userlocation_Button;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRepositorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verManualDeUsuarioToolStripMenuItem;
    }
}