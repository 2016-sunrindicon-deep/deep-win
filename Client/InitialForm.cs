using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class InitialForm : Form
    {
        private static string cachepath = Application.StartupPath + @"\cache\";
        public InitialForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitialForm_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(cachepath);
        }
    }
}
