using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

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
            cash_Button.Image = new Bitmap(Proyecto_PE_Ciclo_I.Properties.Resources.cashier, 75, 75);
            inventory_Button.Image = new Bitmap(Proyecto_PE_Ciclo_I.Properties.Resources.inventory, 50, 50);
            welcome_Label.Text = "Bienvenido, " + Form3.userRead;

            string id = Form3.id;
            string id_class = id.Substring(0, 2);
            if (id_class.Contains("10") == true)
            {
                inventory_Button.Enabled = true;
                lastBill_Button.Enabled = true;
                billLocation_Button.Enabled = true;
                invlocation_Button.Enabled = true;
            }
            if (id_class.Contains("20") == true)
            {
                inventory_Button.Enabled = false;
                lastBill_Button.Enabled = false;
                billLocation_Button.Enabled = false;
                invlocation_Button.Enabled = false;
            }
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
            basicOperations.About();
        }

        private void github_Button_Click(object sender, EventArgs e)
        {
            basicOperations.Repository();
        }

        private void invlocation_Button_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(Application.StartupPath, @"databases\\product.txt");
            Process.Start(ruta);
        }

        private void logout_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form3 = new Form3();
            form3.Show();
        }

        private void billLocation_Button_Click(object sender, EventArgs e)
        {
            string ruta = "C:\\facturas";
            if (!Directory.Exists(ruta))
            {
                MessageBox.Show("La ruta de guardado de las facturas no existe.\nEs muy necesario que exista, por lo tanto, esta se creará.", "Abrir ubicacion de facturas",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DirectoryInfo di = Directory.CreateDirectory(ruta);
            }
            Process.Start("explorer.exe", ruta);
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lastBill_Button_Click(object sender, EventArgs e)
        {

        }

        private void userlocation_Button_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(Application.StartupPath, @"databases\\users.txt");
            Process.Start(ruta);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void verUbicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = "C:\\facturas";
            if (!Directory.Exists(ruta))
            {
                MessageBox.Show("La ruta de guardado de las facturas no existe.\nEs muy necesario que exista, por lo tanto, esta se creará.", "Abrir ubicacion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DirectoryInfo di = Directory.CreateDirectory(ruta);
            }
            Process.Start("explorer.exe", ruta);
        }

        private void abrirArchivoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(Application.StartupPath, @"databases\\product.txt");
            Process.Start(ruta);
        }

        private void abrirArchivoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(Application.StartupPath, @"databases\\users.txt");
            Process.Start(ruta);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basicOperations.About();
        }

        private void verRepositorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basicOperations.Repository();
        }
    }
}
