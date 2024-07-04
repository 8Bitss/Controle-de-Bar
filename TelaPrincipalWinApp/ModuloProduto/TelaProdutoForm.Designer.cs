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
            idProduto = new TextBox();
            nomeProduto = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            precoProduto = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)precoProduto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 86);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 117);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Preço do Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 56);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 2;
            label3.Text = "Id:";
            // 
            // idProduto
            // 
            idProduto.Location = new Point(188, 53);
            idProduto.Name = "idProduto";
            idProduto.ReadOnly = true;
            idProduto.Size = new Size(65, 23);
            idProduto.TabIndex = 1;
            idProduto.Text = "0";
            idProduto.TextAlign = HorizontalAlignment.Right;
            // 
            // nomeProduto
            // 
            nomeProduto.Location = new Point(188, 85);
            nomeProduto.Name = "nomeProduto";
            nomeProduto.Size = new Size(232, 23);
            nomeProduto.TabIndex = 2;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(295, 201);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(88, 33);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(389, 201);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 33);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // precoProduto
            // 
            precoProduto.DecimalPlaces = 2;
            precoProduto.Location = new Point(188, 117);
            precoProduto.Name = "precoProduto";
            precoProduto.Size = new Size(120, 23);
            precoProduto.TabIndex = 3;
            // 
            // TelaProdutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 262);
            Controls.Add(precoProduto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(nomeProduto);
            Controls.Add(idProduto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaProdutoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)precoProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idProduto;
        private TextBox nomeProduto;
        private Button btnGravar;
        private Button btnCancelar;
        private NumericUpDown precoProduto;
    }
}