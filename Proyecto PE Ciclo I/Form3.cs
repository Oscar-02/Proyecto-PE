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
using System.Reflection;

namespace Proyecto_PE_Ciclo_I
{
    public partial class Form3 : Form
    {
        static public string id, password, userinfo, idRead, userRead, passRead;

        private void pass_Box_TextChanged(object sender, EventArgs e)
        {
        }

        private void pass_Box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                object obj = null;
                EventArgs eventArgs = null;
                login_Button_Click(obj, eventArgs);
            }
        }

        private void welcome_Label_Click(object sender, EventArgs e)
        {

        }

        private void pass_Box_Enter(object sender, EventArgs e)
        {
        }

        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            StreamReader Reader = new StreamReader(Path.Combine(Application.StartupPath, @"databases\\users.txt"), true);
            id = id_Box.Text;
            password = pass_Box.Text;
            bool contains = false;
            do
            {
                userinfo = Reader.ReadLine();
                if (userinfo != null)
                {
                    try
                    {
                        contains = userinfo.Contains(id);
                    }
                    catch (ArgumentNullException err)
                    {
                        MessageBox.Show("Ocurrio un error al obtener la lista de usuarios." + err.Message, "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    contains = true;
                }
            }
            while (contains == false);
            if (userinfo != null)
            {
                idRead = userinfo.Substring(0, userinfo.IndexOf(','));
                userRead = userinfo.Substring(userinfo.IndexOf(',') + 1, userinfo.IndexOf(".") - userinfo.IndexOf(','));
                passRead = userinfo.Substring(userinfo.IndexOf(".") + 1);
                if (idRead == id && passRead == password)
                {
                    MessageBox.Show("Inicio de Sesion exitoso. Hola " + userRead, "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario y/o la contraseña no coinciden.", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El usuario no se encuentra en nuestra base de datos.", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
