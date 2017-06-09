using BillingSystem.DataBase;
using BillingSystem.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;

namespace BillingSystem
{
    public partial class Clientes : MetroFramework.Forms.MetroForm
    {
        private BillingContext db;

        public Clientes()
        {

            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            db = new BillingContext();
            clienteBindingSource.DataSource = db.Clientes.ToList();
            tipoDocumentoGridCombo.DataSource = db.TipoDocumentos.ToList();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            clienteBindingSource.DataSource = db.Clientes.ToList();
            tipoDocumentoGridCombo.DataSource = db.TipoDocumentos.ToList();
            Cursor.Current = Cursors.Default;
        }




        private void updateClienteGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            clienteBindingSource.DataSource = db.Clientes.ToList();
            tipoDocumentoGridCombo.DataSource = db.TipoDocumentos.ToList();
            Cursor.Current = Cursors.Default;
        }

        private async void metroTile2_Click(object sender, EventArgs e)
        {


            using (var fromAgregar = new frmAgregarClientes(new Cliente()))
            {
                if (fromAgregar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        clienteBindingSource.Add(fromAgregar.ClienteCurrent);
                        db.Clientes.Add(fromAgregar.ClienteCurrent);
                        clienteBindingSource.EndEdit();
                        await db.SaveChangesAsync();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private async void AgregarCliente_click(object sender, EventArgs e)
        {


            using (var fromAgregar = new frmAgregarClientes(new Cliente()))
            {
                if (fromAgregar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        clienteBindingSource.Add(fromAgregar.ClienteCurrent);
                        db.Clientes.Add(fromAgregar.ClienteCurrent);
                        clienteBindingSource.EndEdit();
                        await db.SaveChangesAsync();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var rowsSeleted = GridClientes.Rows.Cast<DataGridViewRow>().Where(x => x.Selected == true);

            foreach (var row in rowsSeleted)
            {
                db.Clientes.Remove(row.DataBoundItem as Cliente);

                clienteBindingSource.RemoveAt(row.Index);
            }

            db.SaveChanges();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            var obj = clienteBindingSource.Current as Cliente;
            if (obj != null)
            {
                using (var fromAgregar = new frmAgregarClientes(obj))
                {
                    if (fromAgregar.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            clienteBindingSource.EndEdit();
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
    }
}
