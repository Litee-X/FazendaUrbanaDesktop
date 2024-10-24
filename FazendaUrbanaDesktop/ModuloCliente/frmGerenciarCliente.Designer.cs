namespace FazendaUrbanaDesktop.ModuloCliente
{
    partial class frmGerenciarCliente
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
            gbGerenciarCliente = new GroupBox();
            btnDeletar = new Button();
            btnAlterar = new Button();
            btnCadastrar = new Button();
            mskCnpj = new MaskedTextBox();
            txtEndereco = new TextBox();
            txtEmail = new TextBox();
            lblEndereco = new Label();
            lblEmail = new Label();
            lblCnpj = new Label();
            btnPesquisar = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            dgGerenciarCliente = new DataGridView();
            lblId = new Label();
            lblClienteId = new Label();
            gbGerenciarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgGerenciarCliente).BeginInit();
            SuspendLayout();
            // 
            // gbGerenciarCliente
            // 
            gbGerenciarCliente.Controls.Add(btnDeletar);
            gbGerenciarCliente.Controls.Add(btnAlterar);
            gbGerenciarCliente.Controls.Add(btnCadastrar);
            gbGerenciarCliente.Controls.Add(mskCnpj);
            gbGerenciarCliente.Controls.Add(txtEndereco);
            gbGerenciarCliente.Controls.Add(txtEmail);
            gbGerenciarCliente.Controls.Add(lblEndereco);
            gbGerenciarCliente.Controls.Add(lblEmail);
            gbGerenciarCliente.Controls.Add(lblCnpj);
            gbGerenciarCliente.Controls.Add(btnPesquisar);
            gbGerenciarCliente.Controls.Add(txtNome);
            gbGerenciarCliente.Controls.Add(lblNome);
            gbGerenciarCliente.Controls.Add(dgGerenciarCliente);
            gbGerenciarCliente.Controls.Add(lblId);
            gbGerenciarCliente.Controls.Add(lblClienteId);
            gbGerenciarCliente.Location = new Point(12, 12);
            gbGerenciarCliente.Name = "gbGerenciarCliente";
            gbGerenciarCliente.Size = new Size(776, 550);
            gbGerenciarCliente.TabIndex = 0;
            gbGerenciarCliente.TabStop = false;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(263, 233);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(120, 32);
            btnDeletar.TabIndex = 15;
            btnDeletar.TabStop = false;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click_1;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(144, 233);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(113, 32);
            btnAlterar.TabIndex = 14;
            btnAlterar.TabStop = false;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(20, 233);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(118, 32);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.TabStop = false;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // mskCnpj
            // 
            mskCnpj.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskCnpj.Location = new Point(99, 98);
            mskCnpj.Mask = "00,000,000/0000-00";
            mskCnpj.Name = "mskCnpj";
            mskCnpj.ShortcutsEnabled = false;
            mskCnpj.Size = new Size(158, 26);
            mskCnpj.TabIndex = 2;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.Location = new Point(99, 159);
            txtEndereco.MaxLength = 100;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(479, 26);
            txtEndereco.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(99, 130);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(479, 26);
            txtEmail.TabIndex = 3;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(22, 161);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(71, 16);
            lblEndereco.TabIndex = 8;
            lblEndereco.Text = "Endereço:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(46, 132);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 16);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCnpj.Location = new Point(48, 103);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(45, 16);
            lblCnpj.TabIndex = 6;
            lblCnpj.Text = "CNPJ:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(596, 19);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(151, 25);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.TabStop = false;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(99, 66);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(479, 26);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(45, 71);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(48, 16);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // dgGerenciarCliente
            // 
            dgGerenciarCliente.AllowUserToAddRows = false;
            dgGerenciarCliente.AllowUserToDeleteRows = false;
            dgGerenciarCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgGerenciarCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGerenciarCliente.Location = new Point(6, 305);
            dgGerenciarCliente.Name = "dgGerenciarCliente";
            dgGerenciarCliente.ReadOnly = true;
            dgGerenciarCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgGerenciarCliente.Size = new Size(764, 191);
            dgGerenciarCliente.TabIndex = 10;
            dgGerenciarCliente.TabStop = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(99, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 18);
            lblId.TabIndex = 1;
            // 
            // lblClienteId
            // 
            lblClienteId.AutoSize = true;
            lblClienteId.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClienteId.Location = new Point(20, 25);
            lblClienteId.Name = "lblClienteId";
            lblClienteId.Size = new Size(73, 16);
            lblClienteId.TabIndex = 0;
            lblClienteId.Text = "Cliente ID:";
            // 
            // frmGerenciarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 575);
            Controls.Add(gbGerenciarCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGerenciarCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGerenciarCliente";
            gbGerenciarCliente.ResumeLayout(false);
            gbGerenciarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgGerenciarCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbGerenciarCliente;
        private Label lblNome;
        private DataGridView dgGerenciarCliente;
        private Label lblId;
        private Label lblClienteId;
        private Label lblEmail;
        private Label lblCnpj;
        private Button btnPesquisar;
        private TextBox txtNome;
        private Button btnDeletar;
        private Button btnAlterar;
        private Button btnCadastrar;
        private MaskedTextBox mskCnpj;
        private TextBox txtEndereco;
        private TextBox txtEmail;
        private Label lblEndereco;
    }
}