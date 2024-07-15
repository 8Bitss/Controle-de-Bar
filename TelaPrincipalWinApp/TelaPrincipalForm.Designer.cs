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
            menuStrip1 = new MenuStrip();
            produtoMenuItem = new ToolStripMenuItem();
            mesaMenuItem = new ToolStripMenuItem();
            garcomMenuItem = new ToolStripMenuItem();
            contaMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            pnlRegistros = new Panel();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            toolStrip1 = new ToolStrip();
            btnGerarRelatorios = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            produtoMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            produtoMenuItem.Name = "produtoMenuItem";
            produtoMenuItem.Size = new Size(82, 25);
            produtoMenuItem.Text = "Produto";
            produtoMenuItem.Click += produtoMenuItem_Click;
            // 
            // mesaMenuItem
            // 
            mesaMenuItem.Name = "mesaMenuItem";
            mesaMenuItem.Size = new Size(47, 20);
            mesaMenuItem.Text = "Mesa";
            mesaMenuItem.Click += mesaMenuItem_Click;
            // 
            // garcomMenuItem
            // 
            garcomMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            garcomMenuItem.Name = "garcomMenuItem";
            garcomMenuItem.Size = new Size(79, 25);
            garcomMenuItem.Text = "Garçom";
            garcomMenuItem.Click += garcomMenuItem_Click;
            // 
            // contaMenuItem
            // 
            contaMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contaMenuItem.Name = "contaMenuItem";
            contaMenuItem.Size = new Size(65, 25);
            contaMenuItem.Text = "Conta";
            contaMenuItem.Click += contaMenuItem_Click;
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
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnGerarRelatorios, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 35);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(780, 31);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnGerarRelatorios
            // 
            btnGerarRelatorios.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGerarRelatorios.Enabled = false;
            btnGerarRelatorios.Font = new Font("Segoe UI", 12F);
            btnGerarRelatorios.Image = ControleDeBar.WinApp.Properties.Resources.btnGerarGabarito;
            btnGerarRelatorios.ImageTransparentColor = Color.Magenta;
            btnGerarRelatorios.Name = "btnGerarRelatorios";
            btnGerarRelatorios.Padding = new Padding(0, 0, 10, 0);
            btnGerarRelatorios.Size = new Size(38, 28);
            btnGerarRelatorios.Click += gerarRelatoriosStripButton_Click;
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem produtoMenuItem;
        private ToolStripMenuItem mesaMenuItem;
        private ToolStripMenuItem garcomMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem contaMenuItem;
        private ToolStripStatusLabel statusLabelPrincipal;
        private Panel pnlRegistros;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStrip toolStrip1;
        private ToolStripButton btnGerarRelatorios;
    }
}
