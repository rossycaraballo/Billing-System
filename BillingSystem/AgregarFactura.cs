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
        bool isload = false;

        public AgregarFactura(Factura factura)
        {

            InitializeComponent();

            BindingFactura.DataSource = factura;
            bindingSourceCondicicionesPago.DataSource = new CondicionesPago();
        }

        public Factura FacturaCurrent { get { return BindingFactura.Current as Factura; } }
        public CondicionesPago CondicionesPago { get { return bindingSourceCondicicionesPago.Current as CondicionesPago; } }

        private void AgregarFactura_Load(object sender, EventArgs e)
        {
            panelCondicionesPago.Enabled = false;


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

            isload = true;

         
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

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormaPagoCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isload)
            {
                FormaPagoCombobox.SelectedIndex = 1;
         
            }
            //
            if (FormaPagoCombobox.SelectedIndex == 0)
            {
                panelCondicionesPago.Enabled = true;
                MessageBox.Show("Tienes que agregar la condicion de pago", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else {
                panelCondicionesPago.Enabled = false;
            }
        }

        private void VendedorCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (isload == false)
            {
                VendedorCombobox.SelectedIndex = 0;

            }
          
          
        }

        private void ClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isload == false)
            {
                ClienteComboBox.SelectedIndex = 0;

            }
         
            
        }

        private void ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isload == false)
            {
                ProductoComboBox.SelectedIndex = 0;

            }

           
        }
    }
}
