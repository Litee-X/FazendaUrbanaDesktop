
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
            btnAtualizar = new Button();
            btnDeletar = new Button();
            dgCadastrarFuncionario = new DataGridView();
            mskCpf = new MaskedTextBox();
            txtPesquisa = new TextBox();
            gbFuncionarios = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgCadastrarFuncionario).BeginInit();
            gbFuncionarios.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblNome.Location = new Point(33, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(48, 16);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblEmail.Location = new Point(34, 59);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 16);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblCpf.Location = new Point(44, 91);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(37, 16);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblEndereco.Location = new Point(10, 123);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(71, 16);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 12F);
            txtNome.Location = new Point(87, 22);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(486, 26);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F);
            txtEmail.Location = new Point(87, 54);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(486, 26);
            txtEmail.TabIndex = 2;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 12F);
            txtEndereco.Location = new Point(87, 118);
            txtEndereco.MaxLength = 200;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(486, 26);
            txtEndereco.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ButtonFace;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(6, 379);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(137, 29);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(158, 379);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(139, 29);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(313, 379);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(134, 29);
            btnDeletar.TabIndex = 7;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // dgCadastrarFuncionario
            // 
            dgCadastrarFuncionario.AllowUserToAddRows = false;
            dgCadastrarFuncionario.AllowUserToDeleteRows = false;
            dgCadastrarFuncionario.AllowUserToResizeRows = false;
            dgCadastrarFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCadastrarFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCadastrarFuncionario.Location = new Point(6, 150);
            dgCadastrarFuncionario.Name = "dgCadastrarFuncionario";
            dgCadastrarFuncionario.ReadOnly = true;
            dgCadastrarFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCadastrarFuncionario.Size = new Size(675, 169);
            dgCadastrarFuncionario.TabIndex = 12;
            // 
            // mskCpf
            // 
            mskCpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskCpf.Location = new Point(87, 86);
            mskCpf.Mask = "000,000,000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(123, 26);
            mskCpf.TabIndex = 3;
            // 
            // txtPesquisa
            // 
            txtPesquisa.AccessibleName = "";
            txtPesquisa.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisa.Location = new Point(6, 325);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisa";
            txtPesquisa.Size = new Size(605, 22);
            txtPesquisa.TabIndex = 8;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged_1;
            // 
            // gbFuncionarios
            // 
            gbFuncionarios.Controls.Add(dgCadastrarFuncionario);
            gbFuncionarios.Controls.Add(btnDeletar);
            gbFuncionarios.Controls.Add(txtPesquisa);
            gbFuncionarios.Controls.Add(lblNome);
            gbFuncionarios.Controls.Add(mskCpf);
            gbFuncionarios.Controls.Add(lblEmail);
            gbFuncionarios.Controls.Add(lblCpf);
            gbFuncionarios.Controls.Add(lblEndereco);
            gbFuncionarios.Controls.Add(btnAtualizar);
            gbFuncionarios.Controls.Add(txtNome);
            gbFuncionarios.Controls.Add(btnCadastrar);
            gbFuncionarios.Controls.Add(txtEmail);
            gbFuncionarios.Controls.Add(txtEndereco);
            gbFuncionarios.Location = new Point(12, 12);
            gbFuncionarios.Name = "gbFuncionarios";
            gbFuncionarios.Size = new Size(687, 440);
            gbFuncionarios.TabIndex = 14;
            gbFuncionarios.TabStop = false;
            // 
            // frmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 466);
            Controls.Add(gbFuncionarios);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFuncionarios";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFuncionarios";
            ((System.ComponentModel.ISupportInitialize)dgCadastrarFuncionario).EndInit();
            gbFuncionarios.ResumeLayout(false);
            gbFuncionarios.PerformLayout();
            ResumeLayout(false);
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
        private Button btnAtualizar;
        private Button btnDeletar;
        private DataGridView dgCadastrarFuncionario;
        private MaskedTextBox mskCpf;
        private TextBox txtPesquisa;
        private GroupBox gbFuncionarios;
    }
}