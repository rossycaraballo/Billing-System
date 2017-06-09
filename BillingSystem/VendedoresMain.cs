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
    public partial class VendedoresMain : MetroFramework.Forms.MetroForm
    {
        public VendedoresMain()
        {
            InitializeComponent();
        }

        BillingContext db;
        private void ProductoMain_Load(object sender, EventArgs e)
        {
            db = new BillingContext();
            vendedorBindingSource.DataSource = db.Vendedor.ToList();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (VendedorAddOrEdit frm = new VendedorAddOrEdit(new Modelos.Vendedor())) 
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        vendedorBindingSource.Add(frm.VendedorInfo);
                        db.Vendedor.Add(frm.VendedorInfo);
                        vendedorBindingSource.EndEdit();
                        db.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var productoeditar = vendedorBindingSource.Current as Vendedor;
            if (productoeditar != null)
            {
                using (VendedorAddOrEdit frm = new VendedorAddOrEdit(productoeditar))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {

                            vendedorBindingSource.EndEdit();
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
          
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var rowsSeleted = VendedorGridView.Rows.Cast<DataGridViewRow>().Where(x => x.Selected == true);

            foreach (var rowVendedor in rowsSeleted)
            {
                db.Vendedor.Remove(rowVendedor.DataBoundItem as Vendedor);

                vendedorBindingSource.RemoveAt(rowVendedor.Index);
            }

            db.SaveChanges();
        }
    }
}
