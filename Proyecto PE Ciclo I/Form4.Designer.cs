
namespace Proyecto_PE_Ciclo_I
{
    partial class Form4
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
            this.ccLicense_Pic = new System.Windows.Forms.PictureBox();
            this.udb_Pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.team_Label = new System.Windows.Forms.Label();
            this.people_Label = new System.Windows.Forms.Label();
            this.separator_Bar = new System.Windows.Forms.ProgressBar();
            this.ccDesc_Label = new System.Windows.Forms.Label();
            this.ver_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ccLicense_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udb_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // ccLicense_Pic
            // 
            this.ccLicense_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ccLicense_Pic.Image = global::Proyecto_PE_Ciclo_I.Properties.Resources.by_nc_sa;
            this.ccLicense_Pic.Location = new System.Drawing.Point(348, 224);
            this.ccLicense_Pic.Name = "ccLicense_Pic";
            this.ccLicense_Pic.Size = new System.Drawing.Size(114, 39);
            this.ccLicense_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ccLicense_Pic.TabIndex = 0;
            this.ccLicense_Pic.TabStop = false;
            // 
            // udb_Pic
            // 
            this.udb_Pic.Image = global::Proyecto_PE_Ciclo_I.Properties.Resources.udb;
            this.udb_Pic.Location = new System.Drawing.Point(12, 210);
            this.udb_Pic.Name = "udb_Pic";
            this.udb_Pic.Size = new System.Drawing.Size(146, 53);
            this.udb_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.udb_Pic.TabIndex = 1;
            this.udb_Pic.TabStop = false;
            this.udb_Pic.Click += new System.EventHandler(this.udb_Pic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Facturacion e Inventario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // team_Label
            // 
            this.team_Label.AutoSize = true;
            this.team_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.team_Label.ForeColor = System.Drawing.Color.White;
            this.team_Label.Location = new System.Drawing.Point(8, 37);
            this.team_Label.Name = "team_Label";
            this.team_Label.Size = new System.Drawing.Size(150, 60);
            this.team_Label.TabIndex = 3;
            this.team_Label.Text = "Aplicacion diseñada\r\npor el Grupo 2 con-\r\nformado por:";
            this.team_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // people_Label
            // 
            this.people_Label.AutoSize = true;
            this.people_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.people_Label.ForeColor = System.Drawing.Color.White;
            this.people_Label.Location = new System.Drawing.Point(9, 113);
            this.people_Label.Name = "people_Label";
            this.people_Label.Size = new System.Drawing.Size(130, 80);
            this.people_Label.TabIndex = 4;
            this.people_Label.Text = "■Rebeca Alvarenga\r\n■Oscar Cañas\r\n■Hugo Ortiz\r\n■Geovany Pineda\r\n■Jefferson Menjiva" +
    "r";
            // 
            // separator_Bar
            // 
            this.separator_Bar.Location = new System.Drawing.Point(164, 37);
            this.separator_Bar.MarqueeAnimationSpeed = 0;
            this.separator_Bar.Name = "separator_Bar";
            this.separator_Bar.Size = new System.Drawing.Size(11, 226);
            this.separator_Bar.Step = 100;
            this.separator_Bar.TabIndex = 5;
            this.separator_Bar.Value = 100;
            // 
            // ccDesc_Label
            // 
            this.ccDesc_Label.AutoSize = true;
            this.ccDesc_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccDesc_Label.ForeColor = System.Drawing.Color.White;
            this.ccDesc_Label.Location = new System.Drawing.Point(181, 157);
            this.ccDesc_Label.Name = "ccDesc_Label";
            this.ccDesc_Label.Size = new System.Drawing.Size(281, 64);
            this.ccDesc_Label.TabIndex = 6;
            this.ccDesc_Label.Text = "Tanto las imagenes y los iconos utilizados en \r\neste proyecto cuentan con licenci" +
    "a de \r\nCreative Commons de clase CC BY-NC-SA y\r\nCC BY-NC con permiso de sus auto" +
    "res/";
            this.ccDesc_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ver_Label
            // 
            this.ver_Label.AutoSize = true;
            this.ver_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ver_Label.ForeColor = System.Drawing.Color.White;
            this.ver_Label.Location = new System.Drawing.Point(220, 34);
            this.ver_Label.Name = "ver_Label";
            this.ver_Label.Size = new System.Drawing.Size(242, 119);
            this.ver_Label.TabIndex = 7;
            this.ver_Label.Text = "v0.5 Stable \r\n(Programa en proceso de desarrollo)\r\n\r\nNOTA. Las versiones se toman" +
    " en \r\ncuenta basandose en el numero de \r\ncommit que existen en el\r\nrepositorio d" +
    "e GitHub.";
            this.ver_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(470, 275);
            this.Controls.Add(this.ver_Label);
            this.Controls.Add(this.ccDesc_Label);
            this.Controls.Add(this.separator_Bar);
            this.Controls.Add(this.people_Label);
            this.Controls.Add(this.team_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udb_Pic);
            this.Controls.Add(this.ccLicense_Pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.Text = "Acerca De...";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ccLicense_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udb_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ccLicense_Pic;
        private System.Windows.Forms.PictureBox udb_Pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label team_Label;
        private System.Windows.Forms.Label people_Label;
        private System.Windows.Forms.ProgressBar separator_Bar;
        private System.Windows.Forms.Label ccDesc_Label;
        private System.Windows.Forms.Label ver_Label;
    }
}