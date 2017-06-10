using BillingSystem.DataBase;
using BillingSystem.Modelos;
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
        public AgregarFactura(Factura factura)
        {

            InitializeComponent();

            BindingFactura.DataSource = factura;
        }

        public Factura FacturaCurrent { get { return BindingFactura.Current as Factura; } }

        private void AgregarFactura_Load(object sender, EventArgs e)
        {
          ;


           FormaPagoCombobox.DisplayMember = "TipoFormaPago";
            FormaPagoCombobox.ValueMember = "Id";
          
          //  FormaPagoCombobox.se = 1;

            VendedorCombobox.DisplayMember = "Nombre";
            VendedorCombobox.ValueMember = "Id";
          
          //  VendedorCombobox.SelectedIndex = 1;

            ClienteComboBox.DisplayMember = "Nombre";
            ClienteComboBox.ValueMember = "Id";
           
            //ClienteComboBox.SelectedIndex = 1;

            ProductoComboBox.DisplayMember = "Nombre";
            ProductoComboBox.ValueMember = "Id";
     

            using (var db = new BillingContext())
            {
                FormaPagoCombobox.DataSource = db.FormaPago.ToList();
                VendedorCombobox.DataSource = db.Vendedor.ToList();
                ClienteComboBox.DataSource = db.Clientes.ToList();
                ProductoComboBox.DataSource = db.Producto.ToList();
            }
          //  ProductoComboBox.SelectedIndex = 1;
            //tipoDocumentoCombobox.DataSource = db.TipoDocumentos.ToList();


        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BindingFactura.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
