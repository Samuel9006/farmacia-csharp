using FarmaciaUnir.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FarmaciaUnir
{
    public partial class ConfirmacionForm : Form
    {
        public ConfirmacionForm(Pedido pedido)
        {
            InitializeComponent();

            Text = "Pedido al distribuidor " + pedido.Distribuidor;
            lblPedido.Text = pedido.Cantidad + " unidades del " + pedido.Tipo + " " + pedido.Nombre;

            string direccion = "Para la farmacia situada en";
            if (pedido.SucPrincipal)
            {
                direccion += " Calle de la Rosa n. 28";
            }
            if (pedido.SucPrincipal && pedido.SucSecundaria)
            {
                direccion += " y";
            }
            if (pedido.SucSecundaria)
            {
                direccion += " Calle Alcazabilla n. 3";
            }

            lblDireccion.Text = direccion;
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido enviado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
