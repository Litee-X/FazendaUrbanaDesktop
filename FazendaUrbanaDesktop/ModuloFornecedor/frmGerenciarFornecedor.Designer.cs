namespace FazendaUrbanaDesktop.ModuloFornecedor
{
    partial class frmGerenciarFornecedor
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
            gbGerenciarFornecedor = new GroupBox();
            btnPesquisar = new Button();
            btnDeletar = new Button();
            btnAtualizar = new Button();
            btnCadastrar = new Button();
            dgGerenciarFornecedor = new DataGridView();
            txtEndereco = new TextBox();
            txtEmail = new TextBox();
            txtNomeFornecedor = new TextBox();
            mskCnpj = new MaskedTextBox();
            lblEndereco = new Label();
            lblEmail = new Label();
            lblCnpj = new Label();
            lblNomeFornecedor = new Label();
            gbGerenciarFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgGerenciarFornecedor).BeginInit();
            SuspendLayout();
            // 
            // gbGerenciarFornecedor
            // 
            gbGerenciarFornecedor.Controls.Add(btnPesquisar);
            gbGerenciarFornecedor.Controls.Add(btnDeletar);
            gbGerenciarFornecedor.Controls.Add(btnAtualizar);
            gbGerenciarFornecedor.Controls.Add(btnCadastrar);
            gbGerenciarFornecedor.Controls.Add(dgGerenciarFornecedor);
            gbGerenciarFornecedor.Controls.Add(txtEndereco);
            gbGerenciarFornecedor.Controls.Add(txtEmail);
            gbGerenciarFornecedor.Controls.Add(txtNomeFornecedor);
            gbGerenciarFornecedor.Controls.Add(mskCnpj);
            gbGerenciarFornecedor.Controls.Add(lblEndereco);
            gbGerenciarFornecedor.Controls.Add(lblEmail);
            gbGerenciarFornecedor.Controls.Add(lblCnpj);
            gbGerenciarFornecedor.Controls.Add(lblNomeFornecedor);
            gbGerenciarFornecedor.Location = new Point(12, 12);
            gbGerenciarFornecedor.Name = "gbGerenciarFornecedor";
            gbGerenciarFornecedor.Size = new Size(776, 426);
            gbGerenciarFornecedor.TabIndex = 0;
            gbGerenciarFornecedor.TabStop = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(624, 20);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(135, 28);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(308, 366);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(135, 28);
            btnDeletar.TabIndex = 7;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(167, 366);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(135, 28);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(26, 366);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(135, 28);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dgGerenciarFornecedor
            // 
            dgGerenciarFornecedor.AllowUserToAddRows = false;
            dgGerenciarFornecedor.AllowUserToDeleteRows = false;
            dgGerenciarFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgGerenciarFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGerenciarFornecedor.Location = new Point(6, 165);
            dgGerenciarFornecedor.MultiSelect = false;
            dgGerenciarFornecedor.Name = "dgGerenciarFornecedor";
            dgGerenciarFornecedor.ReadOnly = true;
            dgGerenciarFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgGerenciarFornecedor.Size = new Size(764, 150);
            dgGerenciarFornecedor.TabIndex = 8;
            dgGerenciarFornecedor.CellContentClick += dgGerenciarFornecedor_CellContentClick;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.Location = new Point(157, 118);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(422, 26);
            txtEndereco.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(157, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(422, 26);
            txtEmail.TabIndex = 3;
            // 
            // txtNomeFornecedor
            // 
            txtNomeFornecedor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeFornecedor.Location = new Point(157, 22);
            txtNomeFornecedor.Name = "txtNomeFornecedor";
            txtNomeFornecedor.Size = new Size(422, 26);
            txtNomeFornecedor.TabIndex = 1;
            // 
            // mskCnpj
            // 
            mskCnpj.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskCnpj.Location = new Point(157, 54);
            mskCnpj.Mask = "00,000,000/0000-00";
            mskCnpj.Name = "mskCnpj";
            mskCnpj.Size = new Size(153, 26);
            mskCnpj.TabIndex = 2;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(80, 123);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(71, 16);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(104, 91);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 16);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCnpj.Location = new Point(106, 59);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(45, 16);
            lblCnpj.TabIndex = 1;
            lblCnpj.Text = "CNPJ:";
            // 
            // lblNomeFornecedor
            // 
            lblNomeFornecedor.AutoSize = true;
            lblNomeFornecedor.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeFornecedor.Location = new Point(26, 27);
            lblNomeFornecedor.Name = "lblNomeFornecedor";
            lblNomeFornecedor.Size = new Size(125, 16);
            lblNomeFornecedor.TabIndex = 0;
            lblNomeFornecedor.Text = "Nome Fornecedor:";
            // 
            // frmGerenciarFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbGerenciarFornecedor);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGerenciarFornecedor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "GerenciarFornecedor";
            gbGerenciarFornecedor.ResumeLayout(false);
            gbGerenciarFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgGerenciarFornecedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbGerenciarFornecedor;
        private TextBox txtEndereco;
        private TextBox txtEmail;
        private TextBox txtNomeFornecedor;
        private MaskedTextBox mskCnpj;
        private Label lblEndereco;
        private Label lblEmail;
        private Label lblCnpj;
        private Label lblNomeFornecedor;
        private Button btnPesquisar;
        private Button btnDeletar;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private DataGridView dgGerenciarFornecedor;
    }
}