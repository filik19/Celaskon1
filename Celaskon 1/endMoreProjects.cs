using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celaskon_1
{
    public partial class endMoreProjects : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        public endMoreProjects()
        {
            InitializeComponent();
        }

        private void iexpresstodis_Click(object sender, EventArgs e)
        {
            int response1 = MessageBox(IntPtr.Zero, "Are you sure you wan tto use the builtin version of internet explorer to display this webpage?\n This version is very old and bugy.", "Are you sure?", 0x00000004);


            // 6 = Yes
            // 7 = No
            // 2 = Cancel i think
            switch (response1)
            {
                case 6:
                    Console.WriteLine("yes from iexAsk");
                    Console.WriteLine("Trying to open builtin iex..");
                    iexProjectDis iex = new iexProjectDis();
                    iex.Show();
                    break;
                case 7:
                    Console.WriteLine("no from iexAsk");
                    break;
            }

        }
    }
}
