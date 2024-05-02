using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100_legmagasabb_GUI
{
    public partial class Form1 : Form
    {
        List<Epulet> epuletek = new List<Epulet>();
        public Form1()
        {
            InitializeComponent();
            beolvas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = epuletek;
        }

        private void beolvas()
        {
            ConnectToDatabase conn = new ConnectToDatabase();
            epuletek = conn.EpuletekSelect();
        }
    }
}
