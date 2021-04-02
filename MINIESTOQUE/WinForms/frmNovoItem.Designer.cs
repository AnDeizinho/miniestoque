namespace MINIESTOQUE
{
    partial class frmNovoItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtCodig = new System.Windows.Forms.TextBox();
            this.txtforn = new System.Windows.Forms.TextBox();
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.cxplano = new System.Windows.Forms.CheckBox();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsalv = new System.Windows.Forms.Button();
            this.btncanc = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtend = new System.Windows.Forms.TextBox();
            this.cblinha = new System.Windows.Forms.ComboBox();
            this.cbund = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(93, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(54, 20);
            this.txtid.TabIndex = 0;
            this.txtid.Validated += new System.EventHandler(this.txtid_Validated);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(228, 25);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(185, 20);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            this.txtDesc.Validated += new System.EventHandler(this.txtDesc_Validated);
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(94, 51);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(156, 20);
            this.txtcor.TabIndex = 3;
            this.txtcor.Validated += new System.EventHandler(this.txtcor_Validated);
            // 
            // txtCodig
            // 
            this.txtCodig.Location = new System.Drawing.Point(302, 51);
            this.txtCodig.Name = "txtCodig";
            this.txtCodig.Size = new System.Drawing.Size(111, 20);
            this.txtCodig.TabIndex = 4;
            this.txtCodig.Validated += new System.EventHandler(this.txtCodig_Validated);
            // 
            // txtforn
            // 
            this.txtforn.Location = new System.Drawing.Point(93, 78);
            this.txtforn.Name = "txtforn";
            this.txtforn.Size = new System.Drawing.Size(185, 20);
            this.txtforn.TabIndex = 6;
            this.txtforn.Validated += new System.EventHandler(this.txtforn_Validated);
            // 
            // txtlarg
            // 
            this.txtlarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlarg.Location = new System.Drawing.Point(486, 51);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(137, 20);
            this.txtlarg.TabIndex = 5;
            this.txtlarg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtlarg.Validating += new System.ComponentModel.CancelEventHandler(this.validaTamanhos);
            this.txtlarg.Validated += new System.EventHandler(this.txtlarg_Validated);
            // 
            // cxplano
            // 
            this.cxplano.AutoSize = true;
            this.cxplano.Location = new System.Drawing.Point(302, 81);
            this.cxplano.Name = "cxplano";
            this.cxplano.Size = new System.Drawing.Size(127, 17);
            this.cxplano.TabIndex = 7;
            this.cxplano.Text = "Este Tecido é plano?";
            this.cxplano.UseVisualStyleBackColor = true;
            this.cxplano.Validated += new System.EventHandler(this.cxplano_Validated);
            // 
            // txtqtd
            // 
            this.txtqtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtqtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtd.ForeColor = System.Drawing.Color.Green;
            this.txtqtd.Location = new System.Drawing.Point(94, 118);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(184, 29);
            this.txtqtd.TabIndex = 8;
            this.txtqtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtqtd.Validating += new System.ComponentModel.CancelEventHandler(this.validaTamanhos);
            this.txtqtd.Validated += new System.EventHandler(this.txtqtd_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descrição :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Linha :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Codig :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fornecedor :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Largura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Qtd :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "UND :";
            // 
            // btnsalv
            // 
            this.btnsalv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsalv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsalv.Location = new System.Drawing.Point(330, 118);
            this.btnsalv.Name = "btnsalv";
            this.btnsalv.Size = new System.Drawing.Size(141, 86);
            this.btnsalv.TabIndex = 11;
            this.btnsalv.Text = "Salvar";
            this.btnsalv.UseVisualStyleBackColor = false;
            this.btnsalv.Click += new System.EventHandler(this.btnsalv_Click);
            // 
            // btncanc
            // 
            this.btncanc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncanc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncanc.Location = new System.Drawing.Point(486, 118);
            this.btncanc.Name = "btncanc";
            this.btncanc.Size = new System.Drawing.Size(137, 86);
            this.btncanc.TabIndex = 12;
            this.btncanc.Text = "Cancelar";
            this.btncanc.UseVisualStyleBackColor = false;
            this.btncanc.Click += new System.EventHandler(this.btncanc_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Endereço :";
            // 
            // txtend
            // 
            this.txtend.Location = new System.Drawing.Point(94, 184);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(128, 20);
            this.txtend.TabIndex = 10;
            this.txtend.Validated += new System.EventHandler(this.txtend_Validated);
            // 
            // cblinha
            // 
            this.cblinha.AutoCompleteCustomSource.AddRange(new string[] {
            "Camisaria",
            "Malharia",
            "Brim Leve",
            "Brim Pesado",
            "Colete Salva Vidas"});
            this.cblinha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cblinha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cblinha.FormattingEnabled = true;
            this.cblinha.Items.AddRange(new object[] {
            "CAMISARIA",
            "MALHARIA",
            "BRIM LEVE",
            "BRIM PESADO",
            "COLETE SV"});
            this.cblinha.Location = new System.Drawing.Point(477, 24);
            this.cblinha.Name = "cblinha";
            this.cblinha.Size = new System.Drawing.Size(146, 21);
            this.cblinha.TabIndex = 2;
            this.cblinha.Validating += new System.ComponentModel.CancelEventHandler(this.validaCombos);
            this.cblinha.Validated += new System.EventHandler(this.cblinha_Validated);
            // 
            // cbund
            // 
            this.cbund.AutoCompleteCustomSource.AddRange(new string[] {
            "MT",
            "KL"});
            this.cbund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbund.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbund.FormattingEnabled = true;
            this.cbund.Items.AddRange(new object[] {
            "MT",
            "KL"});
            this.cbund.Location = new System.Drawing.Point(93, 156);
            this.cbund.Name = "cbund";
            this.cbund.Size = new System.Drawing.Size(129, 21);
            this.cbund.TabIndex = 9;
            this.cbund.Validating += new System.ComponentModel.CancelEventHandler(this.validaCombos);
            this.cbund.Validated += new System.EventHandler(this.cbund_Validated);
            // 
            // frmNovoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(649, 234);
            this.Controls.Add(this.cbund);
            this.Controls.Add(this.cblinha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.btncanc);
            this.Controls.Add(this.btnsalv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtqtd);
            this.Controls.Add(this.cxplano);
            this.Controls.Add(this.txtlarg);
            this.Controls.Add(this.txtforn);
            this.Controls.Add(this.txtCodig);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNovoItem";
            this.Text = "Novo Item";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.validaTamanhos);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtCodig;
        private System.Windows.Forms.TextBox txtforn;
        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.CheckBox cxplano;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnsalv;
        private System.Windows.Forms.Button btncanc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.ComboBox cblinha;
        private System.Windows.Forms.ComboBox cbund;
    }
}