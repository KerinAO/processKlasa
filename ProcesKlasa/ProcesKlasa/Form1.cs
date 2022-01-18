using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesKlasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {

        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }
    }
}
