namespace FarmaciaUnir
{
    partial class PedidoForm
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
            lblNombreMedicamento = new Label();
            txtNombreMedicamento = new TextBox();
            lblTipoMedicamento = new Label();
            cmbTipoMedicamento = new ComboBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            groupBox1 = new GroupBox();
            rbCemefar = new RadioButton();
            rbEmpsephar = new RadioButton();
            rbCofarma = new RadioButton();
            lblDistribuidores = new Label();
            lblSucursales = new Label();
            cbPrincipal = new CheckBox();
            cbSecundaria = new CheckBox();
            btnConfirmar = new Button();
            btnBorrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreMedicamento
            // 
            lblNombreMedicamento.AutoSize = true;
            lblNombreMedicamento.Location = new Point(32, 29);
            lblNombreMedicamento.Name = "lblNombreMedicamento";
            lblNombreMedicamento.Size = new Size(147, 15);
            lblNombreMedicamento.TabIndex = 0;
            lblNombreMedicamento.Text = "Nombre del medicamento";
            // 
            // txtNombreMedicamento
            // 
            txtNombreMedicamento.Location = new Point(192, 26);
            txtNombreMedicamento.Name = "txtNombreMedicamento";
            txtNombreMedicamento.Size = new Size(221, 23);
            txtNombreMedicamento.TabIndex = 1;
            // 
            // lblTipoMedicamento
            // 
            lblTipoMedicamento.AutoSize = true;
            lblTipoMedicamento.Location = new Point(53, 75);
            lblTipoMedicamento.Name = "lblTipoMedicamento";
            lblTipoMedicamento.Size = new Size(126, 15);
            lblTipoMedicamento.TabIndex = 2;
            lblTipoMedicamento.Text = "Tipo del Medicamento";
            // 
            // cmbTipoMedicamento
            // 
            cmbTipoMedicamento.FormattingEnabled = true;
            cmbTipoMedicamento.Items.AddRange(new object[] { "Analgesico", "Analeptico", "Anestesico", "Antiácido", "Antidepresivo", "Antibiótico" });
            cmbTipoMedicamento.Location = new Point(192, 72);
            cmbTipoMedicamento.Name = "cmbTipoMedicamento";
            cmbTipoMedicamento.Size = new Size(221, 23);
            cmbTipoMedicamento.TabIndex = 3;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(126, 122);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(192, 114);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(221, 23);
            txtCantidad.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbCemefar);
            groupBox1.Controls.Add(rbEmpsephar);
            groupBox1.Controls.Add(rbCofarma);
            groupBox1.Location = new Point(192, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // rbCemefar
            // 
            rbCemefar.AutoSize = true;
            rbCemefar.Location = new Point(6, 62);
            rbCemefar.Name = "rbCemefar";
            rbCemefar.Size = new Size(70, 19);
            rbCemefar.TabIndex = 2;
            rbCemefar.TabStop = true;
            rbCemefar.Text = "Cemefar";
            rbCemefar.UseVisualStyleBackColor = true;
            // 
            // rbEmpsephar
            // 
            rbEmpsephar.AutoSize = true;
            rbEmpsephar.Location = new Point(6, 37);
            rbEmpsephar.Name = "rbEmpsephar";
            rbEmpsephar.Size = new Size(84, 19);
            rbEmpsephar.TabIndex = 1;
            rbEmpsephar.TabStop = true;
            rbEmpsephar.Text = "Empsephar";
            rbEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rbCofarma
            // 
            rbCofarma.AutoSize = true;
            rbCofarma.Location = new Point(6, 12);
            rbCofarma.Name = "rbCofarma";
            rbCofarma.Size = new Size(71, 19);
            rbCofarma.TabIndex = 0;
            rbCofarma.TabStop = true;
            rbCofarma.Text = "Cofarma";
            rbCofarma.UseVisualStyleBackColor = true;
            // 
            // lblDistribuidores
            // 
            lblDistribuidores.AutoSize = true;
            lblDistribuidores.Location = new Point(99, 170);
            lblDistribuidores.Name = "lblDistribuidores";
            lblDistribuidores.Size = new Size(80, 15);
            lblDistribuidores.TabIndex = 7;
            lblDistribuidores.Text = "Distribuidores";
            // 
            // lblSucursales
            // 
            lblSucursales.AutoSize = true;
            lblSucursales.Location = new Point(117, 279);
            lblSucursales.Name = "lblSucursales";
            lblSucursales.Size = new Size(62, 15);
            lblSucursales.TabIndex = 8;
            lblSucursales.Text = "Sucursales";
            // 
            // cbPrincipal
            // 
            cbPrincipal.AutoSize = true;
            cbPrincipal.Location = new Point(192, 279);
            cbPrincipal.Name = "cbPrincipal";
            cbPrincipal.Size = new Size(72, 19);
            cbPrincipal.TabIndex = 9;
            cbPrincipal.Text = "Principal";
            cbPrincipal.UseVisualStyleBackColor = true;
            // 
            // cbSecundaria
            // 
            cbSecundaria.AutoSize = true;
            cbSecundaria.Location = new Point(281, 279);
            cbSecundaria.Name = "cbSecundaria";
            cbSecundaria.Size = new Size(84, 19);
            cbSecundaria.TabIndex = 10;
            cbSecundaria.Text = "Secundaria";
            cbSecundaria.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.LightGreen;
            btnConfirmar.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmar.Location = new Point(219, 359);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.IndianRed;
            btnBorrar.ForeColor = SystemColors.ButtonHighlight;
            btnBorrar.Location = new Point(99, 359);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // PedidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 401);
            Controls.Add(btnBorrar);
            Controls.Add(btnConfirmar);
            Controls.Add(cbSecundaria);
            Controls.Add(cbPrincipal);
            Controls.Add(lblSucursales);
            Controls.Add(lblDistribuidores);
            Controls.Add(groupBox1);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(cmbTipoMedicamento);
            Controls.Add(lblTipoMedicamento);
            Controls.Add(txtNombreMedicamento);
            Controls.Add(lblNombreMedicamento);
            Name = "PedidoForm";
            Text = "Pedido";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreMedicamento;
        private TextBox txtNombreMedicamento;
        private Label lblTipoMedicamento;
        private ComboBox cmbTipoMedicamento;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private GroupBox groupBox1;
        private Label lblDistribuidores;
        private RadioButton rbCemefar;
        private RadioButton rbEmpsephar;
        private RadioButton rbCofarma;
        private Label lblSucursales;
        private CheckBox cbPrincipal;
        private CheckBox cbSecundaria;
        private Button btnConfirmar;
        private Button btnBorrar;
    }
}
