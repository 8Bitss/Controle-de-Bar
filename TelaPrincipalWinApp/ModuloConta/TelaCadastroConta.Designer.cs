namespace ControleDeBar.WinApp.ModuloConta
{
    partial class TelaCadastroConta
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 60);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome do Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 105);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 1;
            label2.Text = "Mesa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 102);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Garçom:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(160, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(306, 29);
            txtNome.TabIndex = 3;
            // 
            // cmbMesa
            // 
            cmbMesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMesa.FormattingEnabled = true;
            cmbMesa.Location = new Point(100, 102);
            cmbMesa.Name = "cmbMesa";
            cmbMesa.Size = new Size(128, 29);
            cmbMesa.TabIndex = 4;
            // 
            // cmbGarcom
            // 
            cmbGarcom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGarcom.FormattingEnabled = true;
            cmbGarcom.Location = new Point(338, 102);
            cmbGarcom.Name = "cmbGarcom";
            cmbGarcom.Size = new Size(128, 29);
            cmbGarcom.TabIndex = 5;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(286, 204);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 37);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(392, 204);
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
            txtId.Location = new Point(160, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(68, 29);
            txtId.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 9);
            label4.Name = "label4";
            label4.Size = new Size(26, 21);
            label4.TabIndex = 11;
            label4.Text = "Id:";
            // 
            // TelaCadastroConta
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 253);
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
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroConta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Conta";
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
    }
}