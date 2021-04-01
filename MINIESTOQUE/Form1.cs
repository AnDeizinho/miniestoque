using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MINIESTOQUE
{
    public partial class Form1 : Form
    {
        List<ENTIDADE.Item> Lista;
        ENTIDADE.Model mod = new ENTIDADE.Model();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lista = mod.CarregaItensSalvos();
            bs.DataSource = Lista;
            dataGridView1.DataSource = bs;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mod.SalvarItens(Lista);
        }
    }
}
