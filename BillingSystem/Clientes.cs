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
    public partial class Clientes : MetroFramework.Forms.MetroForm
    {
        private BillingDbEntities db;

        public Clientes()
        {

            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            db = new BillingDbEntities();
            clienteBindingSource.DataSource = db.Clientes.ToList();
            tipoDocumentoGridCombo.DataSource = db.TipoDocumentoes.ToList();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            clienteBindingSource.DataSource = db.Clientes.ToList();
            tipoDocumentoGridCombo.DataSource = db.TipoDocumentoes.ToList();
            Cursor.Current = Cursors.Default;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {



        }


        private void updateClienteGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            clienteBindingSource.DataSource = db.Clientes.ToList();
            tipoDocumentoGridCombo.DataSource = db.TipoDocumentoes.ToList();
            Cursor.Current = Cursors.Default;
        }

        private async void metroTile2_Click(object sender, EventArgs e)
        {
            var fromAgregar = new frmAgregarClientes(new Cliente());

            //using (var fromAgregar = new frmAgregarClientes(new Cliente()))
            //{
            if (fromAgregar.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    using (var transaction = db.Database.BeginTransaction())
                    {
                        clienteBindingSource.Add(fromAgregar.ClienteCurrent);
                        db.Clientes.Add(fromAgregar.ClienteCurrent);

                        await db.SaveChangesAsync();

                        transaction.Commit();
                    }
                    //await db.Database.Connection.OpenAsync();

                 


                    // db.Database.Connection.Close();



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {


            }

            updateClienteGrid();
            // }
        }

        private async void metroTile5_Click(object sender, EventArgs e)
        {
            clienteBindingSource.EndEdit();
            await db.SaveChangesAsync();

        }
    }
}
