namespace ControleDeBar.WinApp.ModuloGarcom
{
    partial class TelaGarcomForm
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
            txtNome = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            label3 = new Label();
            txtCpf = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 65);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 113);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 1;
            label2.Text = "Cpf:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(94, 62);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(323, 29);
            txtNome.TabIndex = 0;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(211, 160);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(317, 160);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 37);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.BackColor = Color.Silver;
            txtId.Enabled = false;
            txtId.Location = new Point(94, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(68, 29);
            txtId.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 15);
            label3.Name = "label3";
            label3.Size = new Size(26, 21);
            label3.TabIndex = 9;
            label3.Text = "Id:";
            // 
            // txtCpf
            // 
            txtCpf.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCpf.Location = new Point(94, 110);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(323, 29);
            txtCpf.TabIndex = 1;
            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // TelaGarcomForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 206);
            Controls.Add(txtCpf);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaGarcomForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Garçom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtId;
        private Label label3;
        private MaskedTextBox txtCpf;
    }
}