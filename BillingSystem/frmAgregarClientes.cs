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
    public partial class frmAgregarClientes : MetroFramework.Forms.MetroForm
    {
        //public frmAgregarClientes()
        //{
        //    InitializeComponent();
        //}


        public frmAgregarClientes(Cliente edit)
        {

            InitializeComponent();
            bindingCliente.DataSource = edit;


        }

        public Cliente ClienteCurrent { get { return bindingCliente.Current as Cliente; } }

        private void frmAgregarClientes_Load(object sender, EventArgs e)
        {
            tipoDocumentoCombobox.DisplayMember = "Tipo";
            tipoDocumentoCombobox.ValueMember = "Id";

            using (var db = new BillingDbEntities())
            {
                tipoDocumentoCombobox.DataSource = db.TipoDocumentoes.ToList();
               
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bindingCliente.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
