namespace ControleDeBar.WinApp.ModuloMesa
{
    partial class TelaMesaForm
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
            label4 = new Label();
            txtIdMesa = new TextBox();
            txtNumeroMesa = new NumericUpDown();
            btnGravar = new Button();
            btnCancelar = new Button();
            mesaOcupada = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)txtNumeroMesa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 59);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 91);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Número:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 190);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // txtIdMesa
            // 
            txtIdMesa.Enabled = false;
            txtIdMesa.Location = new Point(147, 51);
            txtIdMesa.Name = "txtIdMesa";
            txtIdMesa.Size = new Size(120, 23);
            txtIdMesa.TabIndex = 4;
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.Location = new Point(147, 89);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(120, 23);
            txtNumeroMesa.TabIndex = 5;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(214, 200);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(304, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // mesaOcupada
            // 
            mesaOcupada.AutoSize = true;
            mesaOcupada.Location = new Point(147, 136);
            mesaOcupada.Name = "mesaOcupada";
            mesaOcupada.Size = new Size(96, 19);
            mesaOcupada.TabIndex = 11;
            mesaOcupada.Text = "Mesa cupada";
            mesaOcupada.UseVisualStyleBackColor = true;
            // 
            // TelaMesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 255);
            Controls.Add(mesaOcupada);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtNumeroMesa);
            Controls.Add(txtIdMesa);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMesaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de mesas";
            ((System.ComponentModel.ISupportInitialize)txtNumeroMesa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtIdMesa;
        private NumericUpDown txtNumeroMesa;
        private Button btnGravar;
        private Button btnCancelar;
        private CheckBox mesaOcupada;
    }
}