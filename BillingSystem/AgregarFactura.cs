using BillingSystem.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class AgregarFactura : MetroFramework.Forms.MetroForm
    {
        public AgregarFactura()
        {
            InitializeComponent();
        }

        private void AgregarFactura_Load(object sender, EventArgs e)
        {
            using (var db = new BillingContext())
            {
                FormaPagoCombobox.DisplayMember = "TipoFormaPago";
                FormaPagoCombobox.ValueMember = "Id";
                FormaPagoCombobox.DataSource = db.FormaPago.ToList();

                VendedorCombobox.DisplayMember = "Nombre";
                VendedorCombobox.ValueMember = "Id";
                VendedorCombobox.DataSource = db.Vendedor.ToList();


                ClienteComboBox.DisplayMember = "Nombre";
                ClienteComboBox.ValueMember = "Id";
                ClienteComboBox.DataSource = db.Clientes.ToList();

                ProductoComboBox.DisplayMember = "Nombre";
                ProductoComboBox.ValueMember = "Id";
                ProductoComboBox.DataSource = db.Producto.ToList();

                //tipoDocumentoCombobox.DataSource = db.TipoDocumentos.ToList();

            }
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
