namespace ControleDeBar.WinApp.ModuloProduto
{
    partial class TelaProdutoForm
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
            txtIdProduto = new TextBox();
            txtNomeProduto = new TextBox();
            txtPrecoProduto = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)txtPrecoProduto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 40);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 68);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome do Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 99);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço do Produto:";
            // 
            // txtIdProduto
            // 
            txtIdProduto.Enabled = false;
            txtIdProduto.Location = new Point(160, 40);
            txtIdProduto.Name = "txtIdProduto";
            txtIdProduto.Size = new Size(100, 23);
            txtIdProduto.TabIndex = 3;
            txtIdProduto.Text = "0";
            txtIdProduto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(160, 69);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(303, 23);
            txtNomeProduto.TabIndex = 1;
            // 
            // txtPrecoProduto
            // 
            txtPrecoProduto.Location = new Point(160, 99);
            txtPrecoProduto.Name = "txtPrecoProduto";
            txtPrecoProduto.Size = new Size(120, 23);
            txtPrecoProduto.TabIndex = 2;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(345, 169);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(426, 169);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // TelaProdutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 218);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPrecoProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtIdProduto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaProdutoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)txtPrecoProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdProduto;
        private TextBox txtNomeProduto;
        private NumericUpDown txtPrecoProduto;
        private Button button1;
        private Button button2;
    }
}