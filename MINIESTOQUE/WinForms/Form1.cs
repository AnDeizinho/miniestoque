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
        int indiceSelect = -1;
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

        
        private void txtCor_Enter(object sender, EventArgs e)
        {
            txtCor.Text = "";
            txtCor.ForeColor = Color.Black;
        }
        private void txtTip_Enter(object sender, EventArgs e)
        {
            txtTip.Text = "";
            txtTip.ForeColor = Color.Black;
        }


        private void txtCor_Validated(object sender, EventArgs e)
        {
            if (txtCor.Text=="")
            {
                txtCor.Text = "Cor...";
                txtCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            }
        }
        private void txtTip_Validated(object sender, EventArgs e)
        {
            if (txtTip.Text=="")
            {
                txtTip.Text = "Tipo...";
                txtTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            }
        }

        private void txtDesc_Enter(object sender, EventArgs e)
        {
            txtDesc.Text = "";
            txtDesc.ForeColor = Color.Black;
        }

        private void txtDesc_Validated(object sender, EventArgs e)
        {
            if (txtDesc.Text=="")
            {
                txtDesc.Text = "Descrição...";
                txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bs.DataSource = null;
            Condicional(txtDesc.Text, txtCor.Text, txtTip.Text);
        }
        private void Condicional(string Desc, string cor, string tip)
        {
            bool descvasio = Desc == "Descrição..." || Desc=="";
            bool corvasio = cor == "Cor...";
            bool tipvasio = tip == "Tipo...";
            if (descvasio && corvasio && tipvasio)
            {
                bs.DataSource = Lista;
                
            }
            else if (!descvasio && corvasio && tipvasio)
                Filtro(Desc);
            else if (descvasio && !corvasio && tipvasio)
                FiltroCor(cor);
            else if (descvasio && corvasio && !tipvasio)
                FiltroTipo(tip);
            else if (!descvasio && !corvasio && tipvasio)
                Filtro(Desc, cor);
            else if (!descvasio && corvasio && !tipvasio)
                FiltroDescTipo(Desc, tip);
            else if (descvasio && !corvasio && !tipvasio)
                FiltroCorTip(cor, tip);
            else if (!descvasio && !corvasio && !tipvasio)
                Filtro(Desc, cor, tip);
            else
                bs.DataSource = Lista;
        }
        private void Filtro(string Desc)
        {
            bs.DataSource = Lista.Where((ENTIDADE.Item x) => { return x.Descricao.Conains(Desc,StringComparison.OrdinalIgnoreCase); }).ToList();
        }
        private void Filtro(string Desc, string Cor)
        {
            bs.DataSource = Lista.Where((ENTIDADE.Item x) => {
                if (x.Descricao.Conains(Desc,StringComparison.OrdinalIgnoreCase) && x.Cor.Conains(Cor,StringComparison.OrdinalIgnoreCase))
                    return true;
                else
                    return false;
            });
        }
        private void Filtro(string Desc, string Cor, string Tipo)
        {
            bs.DataSource = Lista.Where((ENTIDADE.Item x) => {
                if (x.Descricao.Conains(Desc,StringComparison.OrdinalIgnoreCase) && x.Cor.Conains(Cor,StringComparison.OrdinalIgnoreCase) && x.Linha.Conains(Tipo,StringComparison.OrdinalIgnoreCase))
                    return true;
                else
                    return false;
            }).ToList();
        }
        private void FiltroDescTipo(string Desc, string Tipo)
        {
            bs.DataSource = Lista.Where((x) => {
                if (x.Descricao.Conains(Desc,StringComparison.OrdinalIgnoreCase) && x.Linha.Conains(Tipo,StringComparison.OrdinalIgnoreCase))
                    return true;
                else
                    return false;
            }).ToList();
        }
        private void FiltroCorTip(string Cor, string Tip)
        {
            bs.DataSource = Lista.Where((x) =>
            {
                if (x.Cor.Conains(Cor,StringComparison.OrdinalIgnoreCase) && x.Linha.Conains(Tip, StringComparison.OrdinalIgnoreCase))
                    return true;
                else
                    return false;
            }).ToList();
        }
        private void FiltroCor(string cor)
        {
            bs.DataSource = Lista.Where((x) =>
            {
                if (x.Cor.Conains(cor, StringComparison.OrdinalIgnoreCase))
                    return true;
                else
                    return false;
            }).ToList();
        }
        private void FiltroTipo(string tipo)
        {
            bs.DataSource = Lista.Where((x) =>
            {
                if ( x.Linha.Conains(tipo, StringComparison.OrdinalIgnoreCase))
                    return true;
                else
                    return false;
            }).ToList();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bs.DataSource = null;
            bs.DataSource = Lista;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmNovoItem novo = new frmNovoItem(Lista);
            novo.ShowDialog();
            bs.DataSource = Lista;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmNovoItem novo = new frmNovoItem(Lista, e.RowIndex);
                novo.ShowDialog();
                
                bs.DataSource = Lista;
                
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete&& indiceSelect>=0)
            {
                if (MessageBox.Show(string.Format("Tem certeza que deseja remover o {0}", Lista[indiceSelect].ToString()), "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    int ind = Lista.IndexOf(Lista.Find((x)=> x.Equals(Lista[indiceSelect])));
                    Lista.RemoveAt(ind);
                }
                bs.DataSource = Lista;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bs;
            }

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indiceSelect = e.RowIndex;
            }
        }

        
    }
}
