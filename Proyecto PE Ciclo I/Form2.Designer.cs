﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.info_Button = new System.Windows.Forms.Button();
            this.github_Button = new System.Windows.Forms.Button();
            this.cash_Button = new System.Windows.Forms.Button();
            this.inventory_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arvo", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Luis";
            // 
            // info_Button
            // 
            this.info_Button.BackColor = System.Drawing.Color.Transparent;
            this.info_Button.ForeColor = System.Drawing.Color.Black;
            this.info_Button.Location = new System.Drawing.Point(340, 10);
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
            this.github_Button.Location = new System.Drawing.Point(302, 10);
            this.github_Button.Name = "github_Button";
            this.github_Button.Size = new System.Drawing.Size(32, 32);
            this.github_Button.TabIndex = 2;
            this.github_Button.UseVisualStyleBackColor = false;
            this.github_Button.Click += new System.EventHandler(this.github_Button_Click);
            // 
            // cash_Button
            // 
            this.cash_Button.Location = new System.Drawing.Point(57, 74);
            this.cash_Button.Name = "cash_Button";
            this.cash_Button.Size = new System.Drawing.Size(115, 97);
            this.cash_Button.TabIndex = 3;
            this.cash_Button.Text = "Facturar";
            this.cash_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cash_Button.UseVisualStyleBackColor = true;
            // 
            // inventory_Button
            // 
            this.inventory_Button.Location = new System.Drawing.Point(210, 74);
            this.inventory_Button.Name = "inventory_Button";
            this.inventory_Button.Size = new System.Drawing.Size(115, 97);
            this.inventory_Button.TabIndex = 4;
            this.inventory_Button.Text = "Inventariar";
            this.inventory_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inventory_Button.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.inventory_Button);
            this.Controls.Add(this.cash_Button);
            this.Controls.Add(this.github_Button);
            this.Controls.Add(this.info_Button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Inicio: Sistema de Facturacion e Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button info_Button;
        private System.Windows.Forms.Button github_Button;
        private System.Windows.Forms.Button cash_Button;
        private System.Windows.Forms.Button inventory_Button;
    }
}