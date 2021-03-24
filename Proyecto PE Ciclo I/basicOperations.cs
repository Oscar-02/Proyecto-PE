using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Proyecto_PE_Ciclo_I
{
    class basicOperations
    {
        public static void About()
        {
            Form form4 = new Form4();
            form4.Show();
        }
        public static void Exit()
        {
            Application.Exit();
        }
        public static void Repository()
        {
            Process.Start("https://github.com/Oscar-02/Proyecto-PE");
        }
    }
}
