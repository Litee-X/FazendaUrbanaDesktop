﻿namespace FazendaUrbanaDesktop.ModuloInicial
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
            gerenciarToolStripMenuItem5 = new ToolStripMenuItem();
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
            menuStrip1.Size = new Size(1317, 24);
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
            gerenciarToolStripMenuItem.Click += gerenciarToolStripMenuItem_Click_1;
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
            gerenciarToolStripMenuItem1.Click += gerenciarToolStripMenuItem1_Click;
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
            gerenciarToolStripMenuItem2.Click += gerenciarToolStripMenuItem2_Click;
            // 
            // funcionarioToolStripMenuItem
            // 
            funcionarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarToolStripMenuItem5 });
            funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            funcionarioToolStripMenuItem.Size = new Size(82, 20);
            funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // gerenciarToolStripMenuItem5
            // 
            gerenciarToolStripMenuItem5.Name = "gerenciarToolStripMenuItem5";
            gerenciarToolStripMenuItem5.Size = new Size(124, 22);
            gerenciarToolStripMenuItem5.Text = "Gerenciar";
            gerenciarToolStripMenuItem5.Click += gerenciarToolStripMenuItem5_Click;
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
            gerenciarToolStripMenuItem4.Click += gerenciarToolStripMenuItem4_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1317, 782);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
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
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem gerenciarToolStripMenuItem4;
        private ToolStripMenuItem gerenciarToolStripMenuItem5;
    }
}