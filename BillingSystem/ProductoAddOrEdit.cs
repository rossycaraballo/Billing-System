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
    public partial class ProductoAddOrEdit : MetroFramework.Forms.MetroForm
    {
        public ProductoAddOrEdit(Producto obj)
        {
            InitializeComponent();
            productoBindingSource.DataSource = obj;
            if (checkEstado.CheckState == CheckState.Checked)
                checkEstado.Text = "Activo";
            else if (checkEstado.CheckState == CheckState.Unchecked)
                checkEstado.Text = "Inactivo";


        }

        public Producto ProductoInfo { get { return productoBindingSource.Current as Producto; }

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtCostoUnitario_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            productoBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void checkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEstado.CheckState == CheckState.Checked)
                checkEstado.Text = "Activo";
            else if (checkEstado.CheckState == CheckState.Unchecked)
                checkEstado.Text = "Inactivo";
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
