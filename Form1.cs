using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagrid2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EredmenyRepository.Path = "osztaly.csv";
            EredmenyRepository.SkipHeader = true;
            dataGridView1.DataSource = EredmenyRepository.FindAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
