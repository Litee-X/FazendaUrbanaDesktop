namespace FazendaUrbanaDesktop.ModuloUsuario
{
    partial class frmCadastroUsuario
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
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            btnCadastrar = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            btnLimpar = new Button();
            gbCadastrarUsuario = new GroupBox();
            mskCpf = new MaskedTextBox();
            lblEndereco = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            lblNome = new Label();
            txtPesquisa = new TextBox();
            dgCadastrarUsuario = new DataGridView();
            gbCadastrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCadastrarUsuario).BeginInit();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(84, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(385, 26);
            txtEmail.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.Location = new Point(84, 108);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(385, 26);
            txtEndereco.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(84, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(385, 26);
            txtNome.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(6, 369);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(128, 27);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(140, 369);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(128, 27);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(274, 369);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(128, 27);
            btnDeletar.TabIndex = 8;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(494, 11);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(137, 27);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // gbCadastrarUsuario
            // 
            gbCadastrarUsuario.Controls.Add(mskCpf);
            gbCadastrarUsuario.Controls.Add(lblEndereco);
            gbCadastrarUsuario.Controls.Add(lblEmail);
            gbCadastrarUsuario.Controls.Add(lblCpf);
            gbCadastrarUsuario.Controls.Add(lblNome);
            gbCadastrarUsuario.Controls.Add(txtPesquisa);
            gbCadastrarUsuario.Controls.Add(dgCadastrarUsuario);
            gbCadastrarUsuario.Controls.Add(btnAtualizar);
            gbCadastrarUsuario.Controls.Add(txtNome);
            gbCadastrarUsuario.Controls.Add(btnDeletar);
            gbCadastrarUsuario.Controls.Add(btnLimpar);
            gbCadastrarUsuario.Controls.Add(txtEndereco);
            gbCadastrarUsuario.Controls.Add(btnCadastrar);
            gbCadastrarUsuario.Controls.Add(txtEmail);
            gbCadastrarUsuario.Location = new Point(12, 12);
            gbCadastrarUsuario.Name = "gbCadastrarUsuario";
            gbCadastrarUsuario.Size = new Size(776, 426);
            gbCadastrarUsuario.TabIndex = 8;
            gbCadastrarUsuario.TabStop = false;
            // 
            // mskCpf
            // 
            mskCpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskCpf.Location = new Point(84, 44);
            mskCpf.Mask = "000,000,000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(124, 26);
            mskCpf.TabIndex = 2;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(7, 113);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(71, 16);
            lblEndereco.TabIndex = 13;
            lblEndereco.Text = "Endereço:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(31, 81);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 16);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCpf.Location = new Point(41, 49);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(37, 16);
            lblCpf.TabIndex = 11;
            lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(30, 17);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(48, 16);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(6, 296);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisa";
            txtPesquisa.Size = new Size(495, 23);
            txtPesquisa.TabIndex = 5;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // dgCadastrarUsuario
            // 
            dgCadastrarUsuario.AllowUserToAddRows = false;
            dgCadastrarUsuario.AllowUserToDeleteRows = false;
            dgCadastrarUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCadastrarUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCadastrarUsuario.Location = new Point(6, 140);
            dgCadastrarUsuario.Name = "dgCadastrarUsuario";
            dgCadastrarUsuario.ReadOnly = true;
            dgCadastrarUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCadastrarUsuario.Size = new Size(764, 150);
            dgCadastrarUsuario.TabIndex = 8;
            // 
            // frmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbCadastrarUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroUsuario";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroUsuario";
            gbCadastrarUsuario.ResumeLayout(false);
            gbCadastrarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCadastrarUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtEndereco;
        private TextBox textBox3;
        private TextBox txtNome;
        private Button btnCadastrar;
        private Button btnAtualizar;
        private Button btnDeletar;
        private Button btnLimpar;
        private GroupBox gbCadastrarUsuario;
        private Label lblEndereco;
        private Label lblEmail;
        private Label lblCpf;
        private Label lblNome;
        private TextBox txtPesquisa;
        private DataGridView dgCadastrarUsuario;
        private MaskedTextBox mskCpf;
    }
}