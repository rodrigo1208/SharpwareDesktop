namespace TelasSharpWare
{
    partial class PesquisarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cpfMbx = new System.Windows.Forms.MaskedTextBox();
            this.botaoAcessarPesquisaCliente1 = new TelasSharpWare.View.Botoes.BotaoAcessarPesquisaCliente();
            this.nomeTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pesquisaClienteDgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoPesquisaGbx = new System.Windows.Forms.GroupBox();
            this.cpfRb = new System.Windows.Forms.RadioButton();
            this.nomeRb = new System.Windows.Forms.RadioButton();
            this.idRb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.idTbx = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizarBtn = new System.Windows.Forms.Button();
            this.fecharBtn = new System.Windows.Forms.Button();
            this.adicionarClienteBtn = new TelasSharpWare.View.Botoes.BotaoAdicionarClienteVenda();
            this.sairBtn = new TelasSharpWare.Botoes.BotaoSair();
            this.inativarClienteBtn = new TelasSharpWare.Botoes.BotaoInativarCliente();
            this.editarCliente = new TelasSharpWare.Botoes.BotaoEditarCliente();
            this.cadastrarClienteBtn = new TelasSharpWare.Botoes.BotaoCadCliente();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaClienteDgv)).BeginInit();
            this.tipoPesquisaGbx.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cpfMbx);
            this.panel1.Controls.Add(this.botaoAcessarPesquisaCliente1);
            this.panel1.Controls.Add(this.nomeTbx);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pesquisaClienteDgv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tipoPesquisaGbx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.idTbx);
            this.panel1.Location = new System.Drawing.Point(72, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 495);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(546, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Gerar Relatorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cpfMbx
            // 
            this.cpfMbx.Enabled = false;
            this.cpfMbx.Location = new System.Drawing.Point(17, 156);
            this.cpfMbx.Mask = "000,000,000-00";
            this.cpfMbx.Name = "cpfMbx";
            this.cpfMbx.Size = new System.Drawing.Size(291, 25);
            this.cpfMbx.TabIndex = 20;
            // 
            // botaoAcessarPesquisaCliente1
            // 
            this.botaoAcessarPesquisaCliente1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAcessarPesquisaCliente1.BackgroundImage")));
            this.botaoAcessarPesquisaCliente1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoAcessarPesquisaCliente1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAcessarPesquisaCliente1.Location = new System.Drawing.Point(328, 153);
            this.botaoAcessarPesquisaCliente1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botaoAcessarPesquisaCliente1.Name = "botaoAcessarPesquisaCliente1";
            this.botaoAcessarPesquisaCliente1.Size = new System.Drawing.Size(102, 28);
            this.botaoAcessarPesquisaCliente1.TabIndex = 19;
            this.botaoAcessarPesquisaCliente1.Click += new System.EventHandler(this.botaoAcessarPesquisaCliente1_Click);
            // 
            // nomeTbx
            // 
            this.nomeTbx.Location = new System.Drawing.Point(17, 100);
            this.nomeTbx.Name = "nomeTbx";
            this.nomeTbx.Size = new System.Drawing.Size(291, 25);
            this.nomeTbx.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "CPF";
            // 
            // pesquisaClienteDgv
            // 
            this.pesquisaClienteDgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pesquisaClienteDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pesquisaClienteDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pesquisaClienteDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.CPF,
            this.situacao});
            this.pesquisaClienteDgv.Location = new System.Drawing.Point(17, 184);
            this.pesquisaClienteDgv.Name = "pesquisaClienteDgv";
            this.pesquisaClienteDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pesquisaClienteDgv.Size = new System.Drawing.Size(654, 262);
            this.pesquisaClienteDgv.TabIndex = 13;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 150;
            // 
            // situacao
            // 
            this.situacao.HeaderText = "Situacao";
            this.situacao.Name = "situacao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pesquisar cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(333, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código";
            // 
            // tipoPesquisaGbx
            // 
            this.tipoPesquisaGbx.Controls.Add(this.cpfRb);
            this.tipoPesquisaGbx.Controls.Add(this.nomeRb);
            this.tipoPesquisaGbx.Controls.Add(this.idRb);
            this.tipoPesquisaGbx.ForeColor = System.Drawing.Color.White;
            this.tipoPesquisaGbx.Location = new System.Drawing.Point(442, 71);
            this.tipoPesquisaGbx.Name = "tipoPesquisaGbx";
            this.tipoPesquisaGbx.Size = new System.Drawing.Size(219, 107);
            this.tipoPesquisaGbx.TabIndex = 6;
            this.tipoPesquisaGbx.TabStop = false;
            this.tipoPesquisaGbx.Text = "Pesquisar Por :";
            // 
            // cpfRb
            // 
            this.cpfRb.AutoSize = true;
            this.cpfRb.Location = new System.Drawing.Point(18, 80);
            this.cpfRb.Name = "cpfRb";
            this.cpfRb.Size = new System.Drawing.Size(47, 21);
            this.cpfRb.TabIndex = 5;
            this.cpfRb.Text = "CPF";
            this.cpfRb.UseVisualStyleBackColor = true;
            this.cpfRb.CheckedChanged += new System.EventHandler(this.cpfRb_CheckedChanged);
            // 
            // nomeRb
            // 
            this.nomeRb.AutoSize = true;
            this.nomeRb.Checked = true;
            this.nomeRb.Location = new System.Drawing.Point(18, 24);
            this.nomeRb.Name = "nomeRb";
            this.nomeRb.Size = new System.Drawing.Size(62, 21);
            this.nomeRb.TabIndex = 3;
            this.nomeRb.TabStop = true;
            this.nomeRb.Text = "Nome";
            this.nomeRb.UseVisualStyleBackColor = true;
            this.nomeRb.CheckedChanged += new System.EventHandler(this.nomeRb_CheckedChanged);
            // 
            // idRb
            // 
            this.idRb.AutoSize = true;
            this.idRb.Location = new System.Drawing.Point(18, 51);
            this.idRb.Name = "idRb";
            this.idRb.Size = new System.Drawing.Size(69, 21);
            this.idRb.TabIndex = 4;
            this.idRb.Text = "Código";
            this.idRb.UseVisualStyleBackColor = true;
            this.idRb.CheckedChanged += new System.EventHandler(this.idRb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // idTbx
            // 
            this.idTbx.Enabled = false;
            this.idTbx.Location = new System.Drawing.Point(336, 100);
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(80, 25);
            this.idTbx.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.minimizarBtn);
            this.panel3.Controls.Add(this.fecharBtn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 37);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(301, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 35);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // minimizarBtn
            // 
            this.minimizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizarBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimizarBtn.Location = new System.Drawing.Point(725, 1);
            this.minimizarBtn.Name = "minimizarBtn";
            this.minimizarBtn.Size = new System.Drawing.Size(38, 32);
            this.minimizarBtn.TabIndex = 6;
            this.minimizarBtn.Text = "-";
            this.minimizarBtn.UseVisualStyleBackColor = true;
            // 
            // fecharBtn
            // 
            this.fecharBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fecharBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fecharBtn.Location = new System.Drawing.Point(769, 1);
            this.fecharBtn.Name = "fecharBtn";
            this.fecharBtn.Size = new System.Drawing.Size(38, 32);
            this.fecharBtn.TabIndex = 5;
            this.fecharBtn.Text = "X";
            this.fecharBtn.UseVisualStyleBackColor = true;
            this.fecharBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // adicionarClienteBtn
            // 
            this.adicionarClienteBtn.BackgroundImage = global::TelasSharpWare.Properties.Resources.BotaoAdicionarClienteVenda11;
            this.adicionarClienteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adicionarClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicionarClienteBtn.Location = new System.Drawing.Point(34, 564);
            this.adicionarClienteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adicionarClienteBtn.Name = "adicionarClienteBtn";
            this.adicionarClienteBtn.Size = new System.Drawing.Size(150, 50);
            this.adicionarClienteBtn.TabIndex = 11;
            this.adicionarClienteBtn.Click += new System.EventHandler(this.adicionarClienteBtn_Click);
            // 
            // sairBtn
            // 
            this.sairBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sairBtn.BackgroundImage")));
            this.sairBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sairBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sairBtn.Location = new System.Drawing.Point(658, 568);
            this.sairBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(150, 50);
            this.sairBtn.TabIndex = 10;
            this.sairBtn.Click += new System.EventHandler(this.botaoSair1_Click);
            // 
            // inativarClienteBtn
            // 
            this.inativarClienteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inativarClienteBtn.BackgroundImage")));
            this.inativarClienteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inativarClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inativarClienteBtn.Location = new System.Drawing.Point(346, 564);
            this.inativarClienteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inativarClienteBtn.Name = "inativarClienteBtn";
            this.inativarClienteBtn.Size = new System.Drawing.Size(150, 50);
            this.inativarClienteBtn.TabIndex = 9;
            this.inativarClienteBtn.Click += new System.EventHandler(this.botaoInativarCliente1_Click);
            // 
            // editarCliente
            // 
            this.editarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editarCliente.BackgroundImage")));
            this.editarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarCliente.Location = new System.Drawing.Point(502, 568);
            this.editarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editarCliente.Name = "editarCliente";
            this.editarCliente.Size = new System.Drawing.Size(150, 50);
            this.editarCliente.TabIndex = 8;
            this.editarCliente.Click += new System.EventHandler(this.botaoEditarCliente1_Click);
            // 
            // cadastrarClienteBtn
            // 
            this.cadastrarClienteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.cadastrarClienteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cadastrarClienteBtn.BackgroundImage")));
            this.cadastrarClienteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cadastrarClienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarClienteBtn.Location = new System.Drawing.Point(190, 564);
            this.cadastrarClienteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cadastrarClienteBtn.Name = "cadastrarClienteBtn";
            this.cadastrarClienteBtn.Size = new System.Drawing.Size(150, 50);
            this.cadastrarClienteBtn.TabIndex = 6;
            this.cadastrarClienteBtn.Click += new System.EventHandler(this.botaoCadCliente1_Click);
            // 
            // PesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(812, 627);
            this.Controls.Add(this.adicionarClienteBtn);
            this.Controls.Add(this.sairBtn);
            this.Controls.Add(this.inativarClienteBtn);
            this.Controls.Add(this.editarCliente);
            this.Controls.Add(this.cadastrarClienteBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PesquisarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PesquisarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaClienteDgv)).EndInit();
            this.tipoPesquisaGbx.ResumeLayout(false);
            this.tipoPesquisaGbx.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox tipoPesquisaGbx;
        private System.Windows.Forms.RadioButton nomeRb;
        private System.Windows.Forms.RadioButton idRb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTbx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button minimizarBtn;
        private System.Windows.Forms.Button fecharBtn;
        private System.Windows.Forms.DataGridView pesquisaClienteDgv;
        private Botoes.BotaoCadCliente cadastrarClienteBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Botoes.BotaoEditarCliente editarCliente;
        private Botoes.BotaoInativarCliente inativarClienteBtn;
        private Botoes.BotaoSair sairBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton cpfRb;
        private View.Botoes.BotaoAdicionarClienteVenda adicionarClienteBtn;
        private System.Windows.Forms.TextBox nomeTbx;
        private View.Botoes.BotaoAcessarPesquisaCliente botaoAcessarPesquisaCliente1;
        private System.Windows.Forms.MaskedTextBox cpfMbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.Button button1;
    }
}