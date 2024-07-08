namespace TelaPrincipalWinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            menuStrip1 = new MenuStrip();
            produtoMenuItem = new ToolStripMenuItem();
            mesaToolStripMenuItem = new ToolStripMenuItem();
            garcomMenuItem = new ToolStripMenuItem();
            contaMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            pnlRegistros = new Panel();
            btnEditarPedido = new ToolStripButton();
            btnConcluirPedido = new ToolStripButton();
            btnAdicionarPedido = new ToolStripButton();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, lblTipoCadastro, btnAdicionarPedido, btnConcluirPedido, btnEditarPedido });
            toolStrip1.Location = new Point(0, 35);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(780, 31);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Font = new Font("Segoe UI", 12F);
            btnAdicionar.Image = ControleDeBar.WinApp.Properties.Resources.btnAdicionar;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Margin = new Padding(1);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(0, 0, 10, 0);
            btnAdicionar.Size = new Size(38, 29);
            btnAdicionar.Text = "Cadastrar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.Image = ControleDeBar.WinApp.Properties.Resources.btnEditar;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(0, 0, 10, 0);
            btnEditar.Size = new Size(38, 28);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 12F);
            btnExcluir.Image = ControleDeBar.WinApp.Properties.Resources.btnExcluir;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(0, 0, 10, 0);
            btnExcluir.Size = new Size(38, 28);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(122, 28);
            lblTipoCadastro.Text = "Seja bem vindo!";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { produtoMenuItem, mesaToolStripMenuItem, garcomMenuItem, contaMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5);
            menuStrip1.Size = new Size(780, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // produtoMenuItem
            // 
            produtoMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            produtoMenuItem.Name = "produtoMenuItem";
            produtoMenuItem.Size = new Size(84, 25);
            produtoMenuItem.Text = "Produto";
            produtoMenuItem.Click += produtoMenuItem_Click;
            // 
            // mesaToolStripMenuItem
            // 
            mesaToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mesaToolStripMenuItem.Name = "mesaToolStripMenuItem";
            mesaToolStripMenuItem.Size = new Size(62, 25);
            mesaToolStripMenuItem.Text = "Mesa";
            // 
            // garcomMenuItem
            // 
            garcomMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            garcomMenuItem.Name = "garcomMenuItem";
            garcomMenuItem.Size = new Size(81, 25);
            garcomMenuItem.Text = "Garçom";
            garcomMenuItem.Click += garcomMenuItem_Click;
            // 
            // contaMenuItem
            // 
            contaMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator2 });
            contaMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            contaMenuItem.Name = "contaMenuItem";
            contaMenuItem.Size = new Size(67, 25);
            contaMenuItem.Text = "Conta";
            contaMenuItem.Click += contaMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(57, 6);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(780, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(195, 21);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // pnlRegistros
            // 
            pnlRegistros.BackColor = SystemColors.GradientInactiveCaption;
            pnlRegistros.Location = new Point(3, 65);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(787, 356);
            pnlRegistros.TabIndex = 3;
            // 
            // btnEditarPedido
            // 
            btnEditarPedido.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditarPedido.Enabled = false;
            btnEditarPedido.Font = new Font("Segoe UI", 12F);
            btnEditarPedido.Image = ControleDeBar.WinApp.Properties.Resources.btnAtualizarPedido;
            btnEditarPedido.ImageTransparentColor = Color.Magenta;
            btnEditarPedido.Name = "btnEditarPedido";
            btnEditarPedido.Padding = new Padding(0, 0, 10, 0);
            btnEditarPedido.Size = new Size(38, 28);
            btnEditarPedido.Text = "Excluir";
            // 
            // btnConcluirPedido
            // 
            btnConcluirPedido.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConcluirPedido.Enabled = false;
            btnConcluirPedido.Font = new Font("Segoe UI", 12F);
            btnConcluirPedido.Image = ControleDeBar.WinApp.Properties.Resources.btnConcluirPedido;
            btnConcluirPedido.ImageTransparentColor = Color.Magenta;
            btnConcluirPedido.Name = "btnConcluirPedido";
            btnConcluirPedido.Padding = new Padding(0, 0, 10, 0);
            btnConcluirPedido.Size = new Size(38, 28);
            btnConcluirPedido.Text = "Excluir";
            // 
            // btnAdicionarPedido
            // 
            btnAdicionarPedido.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarPedido.Enabled = false;
            btnAdicionarPedido.Font = new Font("Segoe UI", 12F);
            btnAdicionarPedido.Image = ControleDeBar.WinApp.Properties.Resources.btnAdicionarPedido;
            btnAdicionarPedido.ImageTransparentColor = Color.Magenta;
            btnAdicionarPedido.Name = "btnAdicionarPedido";
            btnAdicionarPedido.Padding = new Padding(0, 0, 10, 0);
            btnAdicionarPedido.Size = new Size(38, 28);
            btnAdicionarPedido.Text = "Excluir";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(pnlRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            Padding = new Padding(0, 0, 10, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Bar";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem produtoMenuItem;
        private ToolStripMenuItem mesaToolStripMenuItem;
        private ToolStripMenuItem garcomMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripMenuItem contaMenuItem;
        private ToolStripStatusLabel statusLabelPrincipal;
        private Panel pnlRegistros;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnAdicionarPedido;
        private ToolStripButton btnConcluirPedido;
        private ToolStripButton btnEditarPedido;
    }
}
