
namespace FazendaUrbanaDesktop
{
    partial class frmFuncionarios
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
            lblNome = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            lblEndereco = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            btnCadastrar = new Button();
            btnPesquisar = new Button();
            lblFuncionarioid = new Label();
            lblId = new Label();
            btnLimpar = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            dgCadastrarFuncionario = new DataGridView();
            mskCpf = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgCadastrarFuncionario).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblNome.Location = new Point(39, 59);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(48, 16);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblEmail.Location = new Point(39, 96);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 16);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblCpf.Location = new Point(39, 128);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(37, 16);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblEndereco.Location = new Point(39, 160);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(71, 16);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 12F);
            txtNome.Location = new Point(132, 59);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(486, 26);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F);
            txtEmail.Location = new Point(132, 91);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(486, 26);
            txtEmail.TabIndex = 2;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 12F);
            txtEndereco.Location = new Point(132, 155);
            txtEndereco.MaxLength = 200;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(486, 26);
            txtEndereco.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(34, 395);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(137, 32);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(197, 395);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(133, 32);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblFuncionarioid
            // 
            lblFuncionarioid.AutoSize = true;
            lblFuncionarioid.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncionarioid.Location = new Point(39, 20);
            lblFuncionarioid.Name = "lblFuncionarioid";
            lblFuncionarioid.Size = new Size(104, 16);
            lblFuncionarioid.TabIndex = 7;
            lblFuncionarioid.Text = "Funcionário ID:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(149, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 18);
            lblId.TabIndex = 8;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(545, 15);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(154, 28);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(360, 395);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(139, 32);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(523, 395);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(134, 32);
            btnDeletar.TabIndex = 8;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // dgCadastrarFuncionario
            // 
            dgCadastrarFuncionario.AllowUserToAddRows = false;
            dgCadastrarFuncionario.AllowUserToDeleteRows = false;
            dgCadastrarFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCadastrarFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCadastrarFuncionario.Location = new Point(21, 187);
            dgCadastrarFuncionario.Name = "dgCadastrarFuncionario";
            dgCadastrarFuncionario.ReadOnly = true;
            dgCadastrarFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCadastrarFuncionario.Size = new Size(657, 189);
            dgCadastrarFuncionario.TabIndex = 12;
            // 
            // mskCpf
            // 
            mskCpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskCpf.Location = new Point(132, 126);
            mskCpf.Mask = "000,000,000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(123, 26);
            mskCpf.TabIndex = 3;
            // 
            // frmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 439);
            Controls.Add(mskCpf);
            Controls.Add(dgCadastrarFuncionario);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnLimpar);
            Controls.Add(lblId);
            Controls.Add(lblFuncionarioid);
            Controls.Add(btnPesquisar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblEndereco);
            Controls.Add(lblCpf);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)dgCadastrarFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblCpf;
        private Label lblEndereco;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtEndereco;
        private Button btnCadastrar;
        private EventHandler Form2_Load;
        private Button btnPesquisar;
        private Label lblFuncionarioid;
        private Label lblId;
        private Button btnLimpar;
        private Button btnAtualizar;
        private Button btnDeletar;
        private DataGridView dgCadastrarFuncionario;
        private MaskedTextBox mskCpf;
    }
}