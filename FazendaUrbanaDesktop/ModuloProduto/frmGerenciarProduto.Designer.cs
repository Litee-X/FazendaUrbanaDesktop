namespace FazendaUrbanaDesktop.ModuloProduto
{
    partial class frmGerenciarProduto
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
            lblNomeProduto = new Label();
            gbGerenciarProduto = new GroupBox();
            btnDeletar = new Button();
            btnAtualizar = new Button();
            btnCadastrar = new Button();
            btnPesquisar = new Button();
            dgGerenciarProdutos = new DataGridView();
            mskDataPlantio = new MaskedTextBox();
            txtQuantidade = new TextBox();
            lblDataPlantio = new Label();
            lblQuantidade = new Label();
            txtNomeProduto = new TextBox();
            gbGerenciarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgGerenciarProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeProduto.Location = new Point(6, 19);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(102, 16);
            lblNomeProduto.TabIndex = 0;
            lblNomeProduto.Text = "Nome Produto:";
            // 
            // gbGerenciarProduto
            // 
            gbGerenciarProduto.Controls.Add(btnDeletar);
            gbGerenciarProduto.Controls.Add(btnAtualizar);
            gbGerenciarProduto.Controls.Add(btnCadastrar);
            gbGerenciarProduto.Controls.Add(btnPesquisar);
            gbGerenciarProduto.Controls.Add(dgGerenciarProdutos);
            gbGerenciarProduto.Controls.Add(mskDataPlantio);
            gbGerenciarProduto.Controls.Add(txtQuantidade);
            gbGerenciarProduto.Controls.Add(lblDataPlantio);
            gbGerenciarProduto.Controls.Add(lblQuantidade);
            gbGerenciarProduto.Controls.Add(txtNomeProduto);
            gbGerenciarProduto.Controls.Add(lblNomeProduto);
            gbGerenciarProduto.Location = new Point(12, 12);
            gbGerenciarProduto.Name = "gbGerenciarProduto";
            gbGerenciarProduto.Size = new Size(776, 426);
            gbGerenciarProduto.TabIndex = 1;
            gbGerenciarProduto.TabStop = false;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(333, 379);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(139, 28);
            btnDeletar.TabIndex = 10;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(184, 379);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(143, 28);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(39, 379);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(139, 28);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(623, 8);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(147, 35);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dgGerenciarProdutos
            // 
            dgGerenciarProdutos.AllowUserToAddRows = false;
            dgGerenciarProdutos.AllowUserToDeleteRows = false;
            dgGerenciarProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgGerenciarProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGerenciarProdutos.Location = new Point(6, 102);
            dgGerenciarProdutos.Name = "dgGerenciarProdutos";
            dgGerenciarProdutos.ReadOnly = true;
            dgGerenciarProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgGerenciarProdutos.Size = new Size(764, 263);
            dgGerenciarProdutos.TabIndex = 6;
            // 
            // mskDataPlantio
            // 
            mskDataPlantio.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskDataPlantio.Location = new Point(114, 70);
            mskDataPlantio.Mask = "00/00/0000";
            mskDataPlantio.Name = "mskDataPlantio";
            mskDataPlantio.Size = new Size(88, 26);
            mskDataPlantio.TabIndex = 5;
            mskDataPlantio.ValidatingType = typeof(DateTime);
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantidade.Location = new Point(114, 41);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 26);
            txtQuantidade.TabIndex = 4;
            // 
            // lblDataPlantio
            // 
            lblDataPlantio.AutoSize = true;
            lblDataPlantio.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataPlantio.Location = new Point(19, 77);
            lblDataPlantio.Name = "lblDataPlantio";
            lblDataPlantio.Size = new Size(89, 16);
            lblDataPlantio.TabIndex = 3;
            lblDataPlantio.Text = "Data Plantio:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(23, 48);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(85, 16);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeProduto.Location = new Point(114, 12);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(486, 26);
            txtNomeProduto.TabIndex = 1;
            // 
            // frmGerenciarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbGerenciarProduto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGerenciarProduto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGerenciarProduto";
            gbGerenciarProduto.ResumeLayout(false);
            gbGerenciarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgGerenciarProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNomeProduto;
        private GroupBox gbGerenciarProduto;
        private MaskedTextBox mskDataPlantio;
        private TextBox txtQuantidade;
        private Label lblDataPlantio;
        private Label lblQuantidade;
        private TextBox txtNomeProduto;
        private Button btnDeletar;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private Button btnPesquisar;
        private DataGridView dgGerenciarProdutos;
    }
}