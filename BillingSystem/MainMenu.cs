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
    }
}
