namespace TelasSharpWare
{
    partial class PesquisarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tipoPesquisaGbx = new System.Windows.Forms.GroupBox();
            this.nomeProdutoRb = new System.Windows.Forms.RadioButton();
            this.marcaRb = new System.Windows.Forms.RadioButton();
            this.tipoRb = new System.Windows.Forms.RadioButton();
            this.codigoRb = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tipoProdutoCbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeProdutoTbx = new System.Windows.Forms.TextBox();
            this.idProdutoTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.marcaProdutoTbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pesquisaProdutosDgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fecharBtn = new System.Windows.Forms.Button();
            this.pesquisarProdutosBtn = new TelasSharpWare.Botoes.BotaoPesqProduto();
            this.finalizarPesquisaProdutoBtn = new TelasSharpWare.Botoes.BotaoFinalizarPesquisa();
            this.panel2.SuspendLayout();
            this.tipoPesquisaGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaProdutosDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(753, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 227);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tipoPesquisaGbx);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tipoProdutoCbx);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nomeProdutoTbx);
            this.panel2.Controls.Add(this.idProdutoTbx);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.marcaProdutoTbx);
            this.panel2.Location = new System.Drawing.Point(200, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 227);
            this.panel2.TabIndex = 1;
            // 
            // tipoPesquisaGbx
            // 
            this.tipoPesquisaGbx.Controls.Add(this.nomeProdutoRb);
            this.tipoPesquisaGbx.Controls.Add(this.marcaRb);
            this.tipoPesquisaGbx.Controls.Add(this.tipoRb);
            this.tipoPesquisaGbx.Controls.Add(this.codigoRb);
            this.tipoPesquisaGbx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tipoPesquisaGbx.Location = new System.Drawing.Point(346, 13);
            this.tipoPesquisaGbx.Name = "tipoPesquisaGbx";
            this.tipoPesquisaGbx.Size = new System.Drawing.Size(168, 192);
            this.tipoPesquisaGbx.TabIndex = 10;
            this.tipoPesquisaGbx.TabStop = false;
            this.tipoPesquisaGbx.Text = "Tipo de pesquisa";
            // 
            // nomeProdutoRb
            // 
            this.nomeProdutoRb.AutoSize = true;
            this.nomeProdutoRb.Location = new System.Drawing.Point(22, 139);
            this.nomeProdutoRb.Name = "nomeProdutoRb";
            this.nomeProdutoRb.Size = new System.Drawing.Size(107, 17);
            this.nomeProdutoRb.TabIndex = 3;
            this.nomeProdutoRb.TabStop = true;
            this.nomeProdutoRb.Text = "Nome do produto";
            this.nomeProdutoRb.UseVisualStyleBackColor = true;
            this.nomeProdutoRb.CheckedChanged += new System.EventHandler(this.nomeProdutoRb_CheckedChanged);
            // 
            // marcaRb
            // 
            this.marcaRb.AutoSize = true;
            this.marcaRb.Location = new System.Drawing.Point(22, 104);
            this.marcaRb.Name = "marcaRb";
            this.marcaRb.Size = new System.Drawing.Size(55, 17);
            this.marcaRb.TabIndex = 2;
            this.marcaRb.TabStop = true;
            this.marcaRb.Text = "Marca";
            this.marcaRb.UseVisualStyleBackColor = true;
            this.marcaRb.CheckedChanged += new System.EventHandler(this.marcaRb_CheckedChanged);
            // 
            // tipoRb
            // 
            this.tipoRb.AutoSize = true;
            this.tipoRb.Location = new System.Drawing.Point(22, 67);
            this.tipoRb.Name = "tipoRb";
            this.tipoRb.Size = new System.Drawing.Size(46, 17);
            this.tipoRb.TabIndex = 1;
            this.tipoRb.TabStop = true;
            this.tipoRb.Text = "Tipo";
            this.tipoRb.UseVisualStyleBackColor = true;
            this.tipoRb.CheckedChanged += new System.EventHandler(this.tipoRb_CheckedChanged);
            // 
            // codigoRb
            // 
            this.codigoRb.AutoSize = true;
            this.codigoRb.Location = new System.Drawing.Point(22, 32);
            this.codigoRb.Name = "codigoRb";
            this.codigoRb.Size = new System.Drawing.Size(58, 17);
            this.codigoRb.TabIndex = 0;
            this.codigoRb.TabStop = true;
            this.codigoRb.Text = "Codigo";
            this.codigoRb.UseVisualStyleBackColor = true;
            this.codigoRb.CheckedChanged += new System.EventHandler(this.codigoRb_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(31, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo";
            // 
            // tipoProdutoCbx
            // 
            this.tipoProdutoCbx.FormattingEnabled = true;
            this.tipoProdutoCbx.Items.AddRange(new object[] {
            "CorridaCaminhada",
            "CorridaPerformance",
            "Skate",
            "Surf",
            "ChuteiraSalao",
            "ChuteiraCampo",
            "Volei",
            "Fitness",
            "Basquete"});
            this.tipoProdutoCbx.Location = new System.Drawing.Point(35, 84);
            this.tipoProdutoCbx.Name = "tipoProdutoCbx";
            this.tipoProdutoCbx.Size = new System.Drawing.Size(305, 21);
            this.tipoProdutoCbx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome do produto";
            // 
            // nomeProdutoTbx
            // 
            this.nomeProdutoTbx.Location = new System.Drawing.Point(35, 185);
            this.nomeProdutoTbx.Name = "nomeProdutoTbx";
            this.nomeProdutoTbx.Size = new System.Drawing.Size(305, 20);
            this.nomeProdutoTbx.TabIndex = 4;
            // 
            // idProdutoTbx
            // 
            this.idProdutoTbx.Location = new System.Drawing.Point(35, 37);
            this.idProdutoTbx.Name = "idProdutoTbx";
            this.idProdutoTbx.Size = new System.Drawing.Size(128, 20);
            this.idProdutoTbx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(31, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // marcaProdutoTbx
            // 
            this.marcaProdutoTbx.FormattingEnabled = true;
            this.marcaProdutoTbx.Items.AddRange(new object[] {
            "NIKE",
            "ADIDAS",
            "PUMA",
            "MIZUNO",
            "ASICS",
            "OAKLEY",
            "OLIMPIKUS",
            "TIMBERLAND"});
            this.marcaProdutoTbx.Location = new System.Drawing.Point(35, 137);
            this.marcaProdutoTbx.Name = "marcaProdutoTbx";
            this.marcaProdutoTbx.Size = new System.Drawing.Size(305, 21);
            this.marcaProdutoTbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(264, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(822, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "PESQUISAR PRODUTO";
            // 
            // pesquisaProdutosDgv
            // 
            this.pesquisaProdutosDgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pesquisaProdutosDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pesquisaProdutosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pesquisaProdutosDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.marca,
            this.nome,
            this.observacao,
            this.tamanho,
            this.valor,
            this.quant});
            this.pesquisaProdutosDgv.Location = new System.Drawing.Point(190, 366);
            this.pesquisaProdutosDgv.Name = "pesquisaProdutosDgv";
            this.pesquisaProdutosDgv.Size = new System.Drawing.Size(931, 191);
            this.pesquisaProdutosDgv.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "Codigo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome do produto";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // observacao
            // 
            this.observacao.HeaderText = "Descrição";
            this.observacao.Name = "observacao";
            this.observacao.ReadOnly = true;
            this.observacao.Width = 220;
            // 
            // tamanho
            // 
            this.tamanho.HeaderText = "Tamanho";
            this.tamanho.Name = "tamanho";
            this.tamanho.ReadOnly = true;
            this.tamanho.Width = 70;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 70;
            // 
            // quant
            // 
            this.quant.HeaderText = "Quantidade em estoque";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            this.quant.Width = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(279, 593);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(703, 139);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fecharBtn
            // 
            this.fecharBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fecharBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecharBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.fecharBtn.Location = new System.Drawing.Point(1313, 3);
            this.fecharBtn.Name = "fecharBtn";
            this.fecharBtn.Size = new System.Drawing.Size(38, 32);
            this.fecharBtn.TabIndex = 6;
            this.fecharBtn.Text = "X";
            this.fecharBtn.UseVisualStyleBackColor = true;
            this.fecharBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pesquisarProdutosBtn
            // 
            this.pesquisarProdutosBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pesquisarProdutosBtn.BackgroundImage")));
            this.pesquisarProdutosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pesquisarProdutosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisarProdutosBtn.Location = new System.Drawing.Point(1122, 604);
            this.pesquisarProdutosBtn.Name = "pesquisarProdutosBtn";
            this.pesquisarProdutosBtn.Size = new System.Drawing.Size(220, 67);
            this.pesquisarProdutosBtn.TabIndex = 7;
            this.pesquisarProdutosBtn.Click += new System.EventHandler(this.pesquisarProdutosBtn_Click);
            // 
            // finalizarPesquisaProdutoBtn
            // 
            this.finalizarPesquisaProdutoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finalizarPesquisaProdutoBtn.BackgroundImage")));
            this.finalizarPesquisaProdutoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finalizarPesquisaProdutoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalizarPesquisaProdutoBtn.Location = new System.Drawing.Point(1122, 687);
            this.finalizarPesquisaProdutoBtn.Name = "finalizarPesquisaProdutoBtn";
            this.finalizarPesquisaProdutoBtn.Size = new System.Drawing.Size(220, 60);
            this.finalizarPesquisaProdutoBtn.TabIndex = 5;
            this.finalizarPesquisaProdutoBtn.Click += new System.EventHandler(this.finalizarPesquisaProdutoBtn_Click);
            // 
            // PesquisarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1354, 759);
            this.ControlBox = false;
            this.Controls.Add(this.pesquisarProdutosBtn);
            this.Controls.Add(this.fecharBtn);
            this.Controls.Add(this.finalizarPesquisaProdutoBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pesquisaProdutosDgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PesquisarProduto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tipoPesquisaGbx.ResumeLayout(false);
            this.tipoPesquisaGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaProdutosDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomeProdutoTbx;
        private System.Windows.Forms.TextBox idProdutoTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox marcaProdutoTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pesquisaProdutosDgv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Botoes.BotaoFinalizarPesquisa finalizarPesquisaProdutoBtn;
        private System.Windows.Forms.Button fecharBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipoProdutoCbx;
        private Botoes.BotaoPesqProduto pesquisarProdutosBtn;
        private System.Windows.Forms.GroupBox tipoPesquisaGbx;
        private System.Windows.Forms.RadioButton nomeProdutoRb;
        private System.Windows.Forms.RadioButton marcaRb;
        private System.Windows.Forms.RadioButton tipoRb;
        private System.Windows.Forms.RadioButton codigoRb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
    }
}