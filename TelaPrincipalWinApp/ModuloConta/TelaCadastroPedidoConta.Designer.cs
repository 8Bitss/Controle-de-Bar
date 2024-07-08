namespace ControleDeBar.WinApp.ModuloConta
{
    partial class TelaCadastroPedidoConta
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
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            checkProdutosPedido = new CheckedListBox();
            lblNumeroMesa = new Label();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F);
            btnGravar.Location = new Point(245, 317);
            btnGravar.Margin = new Padding(4, 4, 4, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(104, 40);
            btnGravar.TabIndex = 19;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(357, 317);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 40);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 13;
            label1.Text = "Conta da Mesa:";
            // 
            // checkProdutosPedido
            // 
            checkProdutosPedido.FormattingEnabled = true;
            checkProdutosPedido.Location = new Point(23, 85);
            checkProdutosPedido.Name = "checkProdutosPedido";
            checkProdutosPedido.Size = new Size(444, 196);
            checkProdutosPedido.TabIndex = 21;
            // 
            // lblNumeroMesa
            // 
            lblNumeroMesa.AutoSize = true;
            lblNumeroMesa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroMesa.Location = new Point(146, 36);
            lblNumeroMesa.Name = "lblNumeroMesa";
            lblNumeroMesa.Size = new Size(152, 21);
            lblNumeroMesa.TabIndex = 22;
            lblNumeroMesa.Text = "[Número da Mesa]";
            // 
            // TelaCadastroPedidoConta
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 370);
            Controls.Add(lblNumeroMesa);
            Controls.Add(checkProdutosPedido);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroPedidoConta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Pedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private CheckedListBox checkProdutosPedido;
        private Label lblNumeroMesa;
    }
}