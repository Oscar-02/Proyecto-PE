using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PE_Ciclo_I
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            info_Button.Image = new Bitmap(SystemIcons.Information.ToBitmap(), 23, 23);
            github_Button.Image = new Bitmap(Proyecto_PE_Ciclo_I.Properties.Resources.github_icon, 20,20);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void info_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
