
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome_Label
            // 
            this.welcome_Label.AutoSize = true;
            this.welcome_Label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_Label.Font = new System.Drawing.Font("Arvo", 20F);
            this.welcome_Label.ForeColor = System.Drawing.Color.White;
            this.welcome_Label.Location = new System.Drawing.Point(12, 9);
            this.welcome_Label.Name = "welcome_Label";
            this.welcome_Label.Size = new System.Drawing.Size(165, 33);
            this.welcome_Label.TabIndex = 0;
            this.welcome_Label.Text = "Bienvenido";
            // 
            // info_Button
            // 
            this.info_Button.BackColor = System.Drawing.Color.Transparent;
            this.info_Button.ForeColor = System.Drawing.Color.Black;
            this.info_Button.Location = new System.Drawing.Point(378, 163);
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
            this.github_Button.Location = new System.Drawing.Point(416, 163);
            this.github_Button.Name = "github_Button";
            this.github_Button.Size = new System.Drawing.Size(32, 32);
            this.github_Button.TabIndex = 2;
            this.github_Button.UseVisualStyleBackColor = false;
            this.github_Button.Click += new System.EventHandler(this.github_Button_Click);
            // 
            // cash_Button
            // 
            this.cash_Button.Location = new System.Drawing.Point(12, 48);
            this.cash_Button.Name = "cash_Button";
            this.cash_Button.Size = new System.Drawing.Size(115, 97);
            this.cash_Button.TabIndex = 3;
            this.cash_Button.Text = "Facturar";
            this.cash_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cash_Button.UseVisualStyleBackColor = true;
            // 
            // inventory_Button
            // 
            this.inventory_Button.Location = new System.Drawing.Point(12, 151);
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
            this.pictureBox1.Location = new System.Drawing.Point(327, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // billLocation_Button
            // 
            this.billLocation_Button.Location = new System.Drawing.Point(133, 48);
            this.billLocation_Button.Name = "billLocation_Button";
            this.billLocation_Button.Size = new System.Drawing.Size(115, 47);
            this.billLocation_Button.TabIndex = 6;
            this.billLocation_Button.Text = "Abrir Ubicacion de las Facturas Guardadas";
            this.billLocation_Button.UseVisualStyleBackColor = true;
            this.billLocation_Button.Click += new System.EventHandler(this.billLocation_Button_Click);
            // 
            // lastBill_Button
            // 
            this.lastBill_Button.Location = new System.Drawing.Point(133, 98);
            this.lastBill_Button.Name = "lastBill_Button";
            this.lastBill_Button.Size = new System.Drawing.Size(115, 47);
            this.lastBill_Button.TabIndex = 7;
            this.lastBill_Button.Text = "Ver la Ultima Factura Guardada";
            this.lastBill_Button.UseVisualStyleBackColor = true;
            this.lastBill_Button.Click += new System.EventHandler(this.lastBill_Button_Click);
            // 
            // invlocation_Button
            // 
            this.invlocation_Button.Location = new System.Drawing.Point(133, 201);
            this.invlocation_Button.Name = "invlocation_Button";
            this.invlocation_Button.Size = new System.Drawing.Size(115, 47);
            this.invlocation_Button.TabIndex = 8;
            this.invlocation_Button.Text = "Abrir archivo de inventario";
            this.invlocation_Button.UseVisualStyleBackColor = true;
            this.invlocation_Button.Click += new System.EventHandler(this.invlocation_Button_Click);
            // 
            // logout_Button
            // 
            this.logout_Button.Location = new System.Drawing.Point(378, 98);
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
            this.exit_Button.Location = new System.Drawing.Point(378, 48);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(70, 47);
            this.exit_Button.TabIndex = 10;
            this.exit_Button.Text = "SALIR";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(460, 262);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Inicio: Sistema de Facturacion e Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}