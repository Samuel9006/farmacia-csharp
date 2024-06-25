using FarmaciaUnir.dto;

namespace FarmaciaUnir
{
    public partial class PedidoForm : Form
    {
        public PedidoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se dispara al presionar el boton borrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombreMedicamento.Text = "";
            cmbTipoMedicamento.SelectedIndex = -1;
            txtCantidad.Text = "";
            rbCofarma.Checked = false;
            rbEmpsephar.Checked = false;
            rbCemefar.Checked = false;
            cbPrincipal.Checked = false;
            cbSecundaria.Checked = false;
        }


        /// <summary>
        /// Evento que se dispara al presionar el boton confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMedicamento.Text.Trim();
            string tipo = cmbTipoMedicamento.SelectedItem?.ToString();
            string cantidadStr = txtCantidad.Text.Trim();
            int cantidad;
            string distribuidor = null;
            if (rbCofarma.Checked) distribuidor = "Cofarma";
            else if (rbEmpsephar.Checked) distribuidor = "Empsephar";
            else if (rbCemefar.Checked) distribuidor = "Cemefar";

            bool sucursalPrincipal = cbPrincipal.Checked;
            bool sucursalSecundaria = cbSecundaria.Checked; 


            // Validaciones
            if (string.IsNullOrEmpty(nombre) || !nombre.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("El nombre del medicamento debe contener caracteres alfanuméricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tipo == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de medicamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(cantidadStr, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (distribuidor == null)
            {
                MessageBox.Show("Debe seleccionar un distribuidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!sucursalPrincipal && !sucursalSecundaria)
            {
                MessageBox.Show("Debe seleccionar al menos una sucursal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pedido pedido = new Pedido()
            {
                Nombre = nombre,
                Tipo = tipo,
                Cantidad = int.Parse(cantidadStr),
                Distribuidor = distribuidor,
                SucPrincipal = sucursalPrincipal,
                SucSecundaria = sucursalSecundaria
            };

            ConfirmacionForm resumenForm = new ConfirmacionForm(pedido);
            resumenForm.ShowDialog();
        }
    }
}
