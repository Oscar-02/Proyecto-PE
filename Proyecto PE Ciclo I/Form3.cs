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

namespace Proyecto_PE_Ciclo_I
{
    public partial class Form3 : Form
    {
        static public string id, password, userinfo, idRead, userRead, passRead;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            StreamReader Reader = new StreamReader("users.txt", true);
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
                        MessageBox.Show("Ocurrio un error al obtener la lista de usuarios." + err.Message, "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                idRead = userinfo.Substring(0, 4);
                userRead = userinfo.Substring(userinfo.IndexOf(',') + 1, userinfo.IndexOf(".") - userinfo.IndexOf(','));
                passRead = userinfo.Substring(userinfo.IndexOf(".") + 1);
                if (idRead == id && passRead == password)
                {
                    Form form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario y/o la contraseña no coinciden.", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error inesperado.", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
