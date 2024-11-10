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
            txtPesquisa = new TextBox();
            btnDeletar = new Button();
            btnAtualizar = new Button();
            btnCadastrar = new Button();
            mskCnpj = new MaskedTextBox();
            txtEndereco = new TextBox();
            txtEmail = new TextBox();
            lblEndereco = new Label();
            lblEmail = new Label();
            lblCnpj = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            dgGerenciarCliente = new DataGridView();
            gbGerenciarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgGerenciarCliente).BeginInit();
            SuspendLayout();
            // 
            // gbGerenciarCliente
            // 
            gbGerenciarCliente.Controls.Add(txtPesquisa);
            gbGerenciarCliente.Controls.Add(btnDeletar);
            gbGerenciarCliente.Controls.Add(btnAtualizar);
            gbGerenciarCliente.Controls.Add(btnCadastrar);
            gbGerenciarCliente.Controls.Add(mskCnpj);
            gbGerenciarCliente.Controls.Add(txtEndereco);
            gbGerenciarCliente.Controls.Add(txtEmail);
            gbGerenciarCliente.Controls.Add(lblEndereco);
            gbGerenciarCliente.Controls.Add(lblEmail);
            gbGerenciarCliente.Controls.Add(lblCnpj);
            gbGerenciarCliente.Controls.Add(txtNome);
            gbGerenciarCliente.Controls.Add(lblNome);
            gbGerenciarCliente.Controls.Add(dgGerenciarCliente);
            gbGerenciarCliente.Location = new Point(12, 12);
            gbGerenciarCliente.Name = "gbGerenciarCliente";
            gbGerenciarCliente.Size = new Size(776, 530);
            gbGerenciarCliente.TabIndex = 0;
            gbGerenciarCliente.TabStop = false;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisa.Location = new Point(6, 417);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisa";
            txtPesquisa.Size = new Size(561, 22);
            txtPesquisa.TabIndex = 8;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged_1;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(249, 469);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(120, 32);
            btnDeletar.TabIndex = 7;
            btnDeletar.TabStop = false;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(130, 469);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(113, 32);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.TabStop = false;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(6, 469);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(118, 32);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.TabStop = false;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // mskCnpj
            // 
            mskCnpj.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskCnpj.Location = new Point(88, 54);
            mskCnpj.Mask = "00,000,000/0000-00";
            mskCnpj.Name = "mskCnpj";
            mskCnpj.ShortcutsEnabled = false;
            mskCnpj.Size = new Size(158, 26);
            mskCnpj.TabIndex = 2;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.Location = new Point(88, 115);
            txtEndereco.MaxLength = 100;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(479, 26);
            txtEndereco.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(88, 86);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(479, 26);
            txtEmail.TabIndex = 3;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(11, 117);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(71, 16);
            lblEndereco.TabIndex = 8;
            lblEndereco.Text = "Endereço:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(35, 88);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 16);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCnpj.Location = new Point(37, 59);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(45, 16);
            lblCnpj.TabIndex = 6;
            lblCnpj.Text = "CNPJ:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(88, 22);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(479, 26);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(34, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(48, 16);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // dgGerenciarCliente
            // 
            dgGerenciarCliente.AllowUserToAddRows = false;
            dgGerenciarCliente.AllowUserToDeleteRows = false;
            dgGerenciarCliente.AllowUserToResizeRows = false;
            dgGerenciarCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgGerenciarCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGerenciarCliente.Location = new Point(6, 147);
            dgGerenciarCliente.Name = "dgGerenciarCliente";
            dgGerenciarCliente.ReadOnly = true;
            dgGerenciarCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgGerenciarCliente.Size = new Size(764, 264);
            dgGerenciarCliente.TabIndex = 10;
            dgGerenciarCliente.TabStop = false;
            // 
            // frmGerenciarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 554);
            Controls.Add(gbGerenciarCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGerenciarCliente";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
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
        private Label lblEmail;
        private Label lblCnpj;
        private TextBox txtNome;
        private Button btnDeletar;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private MaskedTextBox mskCnpj;
        private TextBox txtEndereco;
        private TextBox txtEmail;
        private Label lblEndereco;
        private TextBox txtPesquisa;
    }
}