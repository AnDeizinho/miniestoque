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
    public partial class frmNovoItem : Form
    {
        List<ENTIDADE.Item> lista;
        ENTIDADE.Item Novo;
        ENTIDADE.Tipo tip;
        int ind;
        public frmNovoItem(List<ENTIDADE.Item> lis)
        {
            tip = ENTIDADE.Tipo.Novo;
            Novo = new ENTIDADE.Item();
            lista = lis;
            InitializeComponent();
            AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            txtid.Text = lista[lista.Count - 1].Id +1 + "";
        }
        public frmNovoItem(List<ENTIDADE.Item> lis, int indice)
        {
            ind = indice;
            tip = ENTIDADE.Tipo.Alterar;
            Novo = lis[indice];
            lista = lis;
            InitializeComponent();
            AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            CarregaCampos(Novo);
            
        }
        void CarregaCampos(ENTIDADE.Item i)
        {
            txtid.Text = i.Id.ToString();
            txtDesc.Text = i.Descricao;
            txtcor.Text = i.Cor;
            txtlarg.Text = i.Largura.ToString();
            cblinha.Text = i.Linha;
            cbund.Text = i.UND;
            txtforn.Text = i.Fornecedor;
            txtend.Text = i.Endereco;
            cxplano.Checked = i.Plano;
            txtCodig.Text = i.Codg.ToString();
            txtqtd.Text = i.Quantidade.ToString();
            this.ValidateChildren();
        }
        private void btnsalv_Click(object sender, EventArgs e)
        {
            if (tip == ENTIDADE.Tipo.Novo)
            {
                if (this.ValidateChildren())
                {
                    lista.Add(Novo);
                    MessageBox.Show("Cadastrado com sucesso!!!");
                    Close();
                }
                else
                    MessageBox.Show("alguns campos são obrigatório!!");
            }
            else
            {
                if (this.ValidateChildren())
                {
                    lista[ind] = Novo;
                    MessageBox.Show("Salvo com Sucesso!!!");
                    Close();
                }
                else
                    MessageBox.Show("alguns campos são obrigatório!!");
            }

        }

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ((TextBox)sender).BackColor = Color.Red;
                ((TextBox)sender).ForeColor = Color.White;
                
                e.Cancel = true;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.White;
                ((TextBox)sender).ForeColor = Color.Black;
                e.Cancel = false;
            }
           
        }

        private void validaCombos(object sender, CancelEventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == -1)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void validaTamanhos(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ((TextBox)sender).BackColor = Color.Red;
                ((TextBox)sender).ForeColor = Color.White;
                e.Cancel = true;
            }
            else
            {
                double retorno;
                if (!double.TryParse(((TextBox)sender).Text, out retorno))
                {
                    ((TextBox)sender).Text = "";
                    ((TextBox)sender).BackColor = Color.Red;
                    ((TextBox)sender).ForeColor = Color.White;

                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    ((TextBox)sender).Text = retorno.ToString("0,0.000");
                   
                    ((TextBox)sender).BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                    ((TextBox)sender).ForeColor = Color.Green;
                }

            }

        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            lista = null;
            Novo = null;
            
            Close();
            
        }

        private void txtid_Validated(object sender, EventArgs e)
        {
            Novo.Id = int.Parse(txtid.Text);
        }

        private void txtDesc_Validated(object sender, EventArgs e)
        {
            Novo.Descricao = txtDesc.Text;
        }

        private void cblinha_Validated(object sender, EventArgs e)
        {
            Novo.Linha = cblinha.Text;
        }

        private void txtcor_Validated(object sender, EventArgs e)
        {
            Novo.Cor = txtcor.Text;
        }

        private void txtCodig_Validated(object sender, EventArgs e)
        {
            int ret;
            int.TryParse(txtCodig.Text,out ret);
            Novo.Codg = ret;
        }

        private void txtlarg_Validated(object sender, EventArgs e)
        {
            Novo.Largura = double.Parse(txtlarg.Text);

        }

        private void txtforn_Validated(object sender, EventArgs e)
        {
            Novo.Fornecedor = txtforn.Text;
        }

        private void cxplano_Validated(object sender, EventArgs e)
        {
            Novo.Plano = cxplano.Checked;
        }

        private void txtqtd_Validated(object sender, EventArgs e)
        {
            Novo.Quantidade = double.Parse(txtqtd.Text);
        }

        private void cbund_Validated(object sender, EventArgs e)
        {
            Novo.UND = cbund.Text;
        }

        private void txtend_Validated(object sender, EventArgs e)
        {
            Novo.Endereco = txtend.Text;
        }
    }
}
