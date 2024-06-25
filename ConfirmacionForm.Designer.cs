namespace FarmaciaUnir
{
    partial class ConfirmacionForm
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
            lblPedido = new Label();
            lblDireccion = new Label();
            btnCancelar = new Button();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Location = new Point(12, 92);
            lblPedido.MaximumSize = new Size(150, 0);
            lblPedido.MinimumSize = new Size(100, 0);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(103, 15);
            lblPedido.TabIndex = 0;
            lblPedido.Text = "SASDFDDDDFSFSF";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(12, 147);
            lblDireccion.MaximumSize = new Size(200, 0);
            lblDireccion.MinimumSize = new Size(150, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(150, 15);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "label2 dssdsddsdsddsdSD ";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(45, 260);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = SystemColors.ActiveCaption;
            btnEnviar.ForeColor = SystemColors.ButtonHighlight;
            btnEnviar.Location = new Point(144, 260);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // ConfirmacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 321);
            Controls.Add(btnEnviar);
            Controls.Add(btnCancelar);
            Controls.Add(lblDireccion);
            Controls.Add(lblPedido);
            Name = "ConfirmacionForm";
            Text = "Confirmacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPedido;
        private Label lblDireccion;
        private Button btnCancelar;
        private Button btnEnviar;
    }
}