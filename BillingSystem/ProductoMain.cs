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
    public partial class ProductoMain : MetroFramework.Forms.MetroForm
    {
        public ProductoMain()
        {
            InitializeComponent();
        }

        BillingContext db;
        private void ProductoMain_Load(object sender, EventArgs e)
        {
            db = new BillingContext();
            ProductoBindingSource.DataSource = db.Producto.ToList();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (ProductoAddOrEdit frm = new ProductoAddOrEdit(new Modelos.Producto())) 
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ProductoBindingSource.Add(frm.ProductoInfo);
                        db.Producto.Add(frm.ProductoInfo);
                        ProductoBindingSource.EndEdit();
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
            var productoeditar = ProductoBindingSource.Current as Producto;
            if (productoeditar != null)
            {
                using (ProductoAddOrEdit frm = new ProductoAddOrEdit(productoeditar))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {

                            ProductoBindingSource.EndEdit();
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
            var rowsSeleted = ProductoGridView.Rows.Cast<DataGridViewRow>().Where(x => x.Selected == true);

            foreach (var row in rowsSeleted)
            {
                db.Producto.Remove(row.DataBoundItem as Producto);

                ProductoBindingSource.RemoveAt(row.Index);
            }

            db.SaveChanges();
        }
    }
}
