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
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {

        BillingContext db;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoMain frm = new ProductoMain();
            frm.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendedoresMain frm = new VendedoresMain();
            frm.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billingDbDataSet.Facturas' table. You can move, or remove it, as needed.
            this.facturasTableAdapter.Fill(this.billingDbDataSet.Facturas);
            db = new BillingContext();

            /// FactGridView.DataSource = db.Factura.ToList();
            /// 
            formaPagoBindingSource.DataSource = db.FormaPago.ToList();
            vendedorBindingSource.DataSource = db.Vendedor.ToList();
            clienteBindingSource.DataSource = db.Clientes.ToList();
            productoBindingSource.DataSource = db.Producto.ToList();
            //    formaPagoBindingSource.DataSource = db.FormaPago.ToList();
            //    vendedorBindingSource.DataSource = db.Vendedor.ToList();
            //    clienteBindingSource.DataSource = db.Clientes.ToList();
            //    productoBindingSource.DataSource = db.Producto.ToList();
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {

            using (var fromAgregar = new AgregarFactura(new Factura()))
            {
                if (fromAgregar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        fromAgregar.FacturaCurrent.Fecha = DateTime.Now;

                      //  facturasBindingSource.Add(fromAgregar.FacturaCurrent);
                        db.Factura.Add(fromAgregar.FacturaCurrent);
                      //  facturasBindingSource.EndEdit();

                        await db.SaveChangesAsync();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

             updateFacturaGrid();
        }




        private void updateFacturaGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            facturasBindingSource.DataSource = db.Factura.ToList();
            
            Cursor.Current = Cursors.Default;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



    }
}
