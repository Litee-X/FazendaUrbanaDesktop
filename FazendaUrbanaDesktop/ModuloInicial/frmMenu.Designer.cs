namespace FazendaUrbanaDesktop.ModuloInicial
{
    partial class frmMenu
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
            menuStrip1 = new MenuStrip();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            gerenciarToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            gerenciarToolStripMenuItem1 = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            gerenciarToolStripMenuItem2 = new ToolStripMenuItem();
            funcionarioToolStripMenuItem = new ToolStripMenuItem();
            gerenciarToolStripMenuItem3 = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            gerenciarToolStripMenuItem4 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, fornecedorToolStripMenuItem, produtoToolStripMenuItem, funcionarioToolStripMenuItem, usuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(56, 20);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // gerenciarToolStripMenuItem
            // 
            gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            gerenciarToolStripMenuItem.Size = new Size(180, 22);
            gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarToolStripMenuItem1 });
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(79, 20);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // gerenciarToolStripMenuItem1
            // 
            gerenciarToolStripMenuItem1.Name = "gerenciarToolStripMenuItem1";
            gerenciarToolStripMenuItem1.Size = new Size(124, 22);
            gerenciarToolStripMenuItem1.Text = "Gerenciar";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarToolStripMenuItem2 });
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(62, 20);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // gerenciarToolStripMenuItem2
            // 
            gerenciarToolStripMenuItem2.Name = "gerenciarToolStripMenuItem2";
            gerenciarToolStripMenuItem2.Size = new Size(124, 22);
            gerenciarToolStripMenuItem2.Text = "Gerenciar";
            // 
            // funcionarioToolStripMenuItem
            // 
            funcionarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarToolStripMenuItem3 });
            funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            funcionarioToolStripMenuItem.Size = new Size(82, 20);
            funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // gerenciarToolStripMenuItem3
            // 
            gerenciarToolStripMenuItem3.Name = "gerenciarToolStripMenuItem3";
            gerenciarToolStripMenuItem3.Size = new Size(124, 22);
            gerenciarToolStripMenuItem3.Text = "Gerenciar";
            gerenciarToolStripMenuItem3.Click += gerenciarToolStripMenuItem3_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarToolStripMenuItem4 });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(59, 20);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // gerenciarToolStripMenuItem4
            // 
            gerenciarToolStripMenuItem4.Name = "gerenciarToolStripMenuItem4";
            gerenciarToolStripMenuItem4.Size = new Size(124, 22);
            gerenciarToolStripMenuItem4.Text = "Gerenciar";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMenu";
            ShowIcon = false;
            Text = "frmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem funcionarioToolStripMenuItem;
        private ToolStripMenuItem gerenciarToolStripMenuItem;
        private ToolStripMenuItem gerenciarToolStripMenuItem1;
        private ToolStripMenuItem gerenciarToolStripMenuItem2;
        private ToolStripMenuItem gerenciarToolStripMenuItem3;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem gerenciarToolStripMenuItem4;
    }
}