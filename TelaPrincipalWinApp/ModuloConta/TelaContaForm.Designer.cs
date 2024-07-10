namespace ControleDeBar.WinApp.ModuloConta
{
    partial class TelaContaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            cmbMesa = new ComboBox();
            cmbGarcom = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            menuStrip1 = new MenuStrip();
            removerProdutoItemToolStripMenuItem = new ToolStripMenuItem();
            btnAdicionar = new Button();
            txtQuantidade = new NumericUpDown();
            label6 = new Label();
            txtProduto = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            lblValorTotal = new Label();
            listProdutos = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 54);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome do Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 106);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 1;
            label2.Text = "Mesa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 106);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Garçom:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(180, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(306, 29);
            txtNome.TabIndex = 3;
            // 
            // cmbMesa
            // 
            cmbMesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMesa.FormattingEnabled = true;
            cmbMesa.Location = new Point(100, 103);
            cmbMesa.Name = "cmbMesa";
            cmbMesa.Size = new Size(171, 29);
            cmbMesa.TabIndex = 4;
            // 
            // cmbGarcom
            // 
            cmbGarcom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGarcom.FormattingEnabled = true;
            cmbGarcom.Location = new Point(417, 103);
            cmbGarcom.Name = "cmbGarcom";
            cmbGarcom.Size = new Size(171, 29);
            cmbGarcom.TabIndex = 5;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(384, 557);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(490, 557);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.BackColor = Color.Silver;
            txtId.Enabled = false;
            txtId.Location = new Point(180, 15);
            txtId.Name = "txtId";
            txtId.Size = new Size(68, 29);
            txtId.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 18);
            label4.Name = "label4";
            label4.Size = new Size(26, 21);
            label4.TabIndex = 11;
            label4.Text = "Id:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtProduto);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(44, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 369);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Pedidos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listProdutos);
            groupBox2.Controls.Add(menuStrip1);
            groupBox2.Location = new Point(18, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(516, 264);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produtos";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { removerProdutoItemToolStripMenuItem });
            menuStrip1.Location = new Point(3, 25);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(510, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // removerProdutoItemToolStripMenuItem
            // 
            removerProdutoItemToolStripMenuItem.Name = "removerProdutoItemToolStripMenuItem";
            removerProdutoItemToolStripMenuItem.Size = new Size(66, 20);
            removerProdutoItemToolStripMenuItem.Text = "Remover";
            removerProdutoItemToolStripMenuItem.Click += removerProdutoItemToolStripMenuItem_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 11.25F);
            btnAdicionar.Location = new Point(396, 43);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(138, 28);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionarPedido_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(333, 43);
            txtQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(57, 29);
            txtQuantidade.TabIndex = 8;
            txtQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(233, 46);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 7;
            label6.Text = "Quantidade:";
            // 
            // txtProduto
            // 
            txtProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            txtProduto.FormattingEnabled = true;
            txtProduto.Location = new Point(99, 43);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(128, 29);
            txtProduto.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 46);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 5;
            label5.Text = "Produto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 149);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 14;
            label7.Text = "Valor Total:";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(135, 149);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(33, 21);
            lblValorTotal.TabIndex = 15;
            lblValorTotal.Text = "R$ ";
            // 
            // listProdutos
            // 
            listProdutos.FormattingEnabled = true;
            listProdutos.ItemHeight = 21;
            listProdutos.Location = new Point(0, 52);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(516, 214);
            listProdutos.TabIndex = 1;
            // 
            // TelaContaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 597);
            Controls.Add(lblValorTotal);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(cmbGarcom);
            Controls.Add(cmbMesa);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Conta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private ComboBox cmbMesa;
        private ComboBox cmbGarcom;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtId;
        private Label label4;
        private GroupBox groupBox1;
        private Label label6;
        private ComboBox txtProduto;
        private Label label5;
        private GroupBox groupBox2;
        private Button btnAdicionar;
        private NumericUpDown txtQuantidade;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem removerProdutoItemToolStripMenuItem;
        private Label label7;
        private Label lblValorTotal;
        private ListBox listProdutos;
    }
}