﻿
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
            this.welcome_Label = new System.Windows.Forms.Label();
            this.login_Button = new System.Windows.Forms.Button();
            this.id_Box = new System.Windows.Forms.TextBox();
            this.pass_Box = new System.Windows.Forms.TextBox();
            this.id_Label = new System.Windows.Forms.Label();
            this.pass_Label = new System.Windows.Forms.Label();
            this.udb_Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.udb_Pic)).BeginInit();
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
            this.welcome_Label.TabIndex = 1;
            this.welcome_Label.Text = "Bienvenido";
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(160, 162);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(113, 42);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Iniciar Sesion";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // id_Box
            // 
            this.id_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.id_Box.Location = new System.Drawing.Point(116, 59);
            this.id_Box.Name = "id_Box";
            this.id_Box.Size = new System.Drawing.Size(158, 23);
            this.id_Box.TabIndex = 3;
            // 
            // pass_Box
            // 
            this.pass_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pass_Box.Location = new System.Drawing.Point(116, 104);
            this.pass_Box.Name = "pass_Box";
            this.pass_Box.PasswordChar = '*';
            this.pass_Box.Size = new System.Drawing.Size(158, 23);
            this.pass_Box.TabIndex = 4;
            // 
            // id_Label
            // 
            this.id_Label.AutoSize = true;
            this.id_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.id_Label.ForeColor = System.Drawing.Color.White;
            this.id_Label.Location = new System.Drawing.Point(16, 62);
            this.id_Label.Name = "id_Label";
            this.id_Label.Size = new System.Drawing.Size(94, 17);
            this.id_Label.TabIndex = 7;
            this.id_Label.Text = "ID de Usuario";
            // 
            // pass_Label
            // 
            this.pass_Label.AutoSize = true;
            this.pass_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pass_Label.ForeColor = System.Drawing.Color.White;
            this.pass_Label.Location = new System.Drawing.Point(29, 110);
            this.pass_Label.Name = "pass_Label";
            this.pass_Label.Size = new System.Drawing.Size(81, 17);
            this.pass_Label.TabIndex = 8;
            this.pass_Label.Text = "Contraseña";
            // 
            // udb_Pic
            // 
            this.udb_Pic.BackColor = System.Drawing.Color.Transparent;
            this.udb_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.udb_Pic.Image = global::Proyecto_PE_Ciclo_I.Properties.Resources.udb;
            this.udb_Pic.Location = new System.Drawing.Point(12, 162);
            this.udb_Pic.Name = "udb_Pic";
            this.udb_Pic.Size = new System.Drawing.Size(121, 42);
            this.udb_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.udb_Pic.TabIndex = 6;
            this.udb_Pic.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(286, 214);
            this.Controls.Add(this.pass_Label);
            this.Controls.Add(this.id_Label);
            this.Controls.Add(this.udb_Pic);
            this.Controls.Add(this.pass_Box);
            this.Controls.Add(this.id_Box);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.welcome_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Iniciar Sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udb_Pic)).EndInit();
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
    }
}