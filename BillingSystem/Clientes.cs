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
        private readonly BillingDbEntities db;

        public Clientes()
        {
            db = new BillingDbEntities();
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
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
                        await db.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {


                }
            }
        }
    }
}
