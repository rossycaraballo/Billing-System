namespace BillingSystem
{
    public partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrear = new MetroFramework.Controls.MetroTile();
            this.FactGridView = new System.Windows.Forms.DataGridView();
            this.FactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingDbDataSet = new BillingSystem.BillingDbDataSet();
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasTableAdapter = new BillingSystem.BillingDbDataSetTableAdapters.FacturasTableAdapter();
            this.formaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormaPagoDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idVendedorDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idClienteDataGridViewComboBoColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FactGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.vendedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(15, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(27, 89);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(96, 62);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear Factura";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FactGridView
            // 
            this.FactGridView.AllowUserToAddRows = false;
            this.FactGridView.AllowUserToDeleteRows = false;
            this.FactGridView.AllowUserToOrderColumns = true;
            this.FactGridView.AutoGenerateColumns = false;
            this.FactGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FactGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idFormaPagoDataGridViewComboBoxColumn,
            this.idVendedorDataGridViewComboBoxColumn,
            this.idClienteDataGridViewComboBoColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.idProductoDataGridViewComboBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn});
            this.FactGridView.DataSource = this.facturasBindingSource;
            this.FactGridView.Location = new System.Drawing.Point(27, 169);
            this.FactGridView.Name = "FactGridView";
            this.FactGridView.ReadOnly = true;
            this.FactGridView.Size = new System.Drawing.Size(998, 272);
            this.FactGridView.TabIndex = 3;
            // 
            // FactBindingSource
            // 
            this.FactBindingSource.DataSource = typeof(BillingSystem.Modelos.Factura);
            // 
            // billingDbDataSet
            // 
            this.billingDbDataSet.DataSetName = "BillingDbDataSet";
            this.billingDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "Facturas";
            this.facturasBindingSource.DataSource = this.billingDbDataSet;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // formaPagoBindingSource
            // 
            this.formaPagoBindingSource.DataSource = typeof(BillingSystem.Modelos.FormaPago);
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataSource = typeof(BillingSystem.Modelos.Vendedor);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(BillingSystem.Modelos.Cliente);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(BillingSystem.Modelos.Producto);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idFormaPagoDataGridViewComboBoxColumn
            // 
            this.idFormaPagoDataGridViewComboBoxColumn.DataPropertyName = "IdFormaPago";
            this.idFormaPagoDataGridViewComboBoxColumn.DataSource = this.formaPagoBindingSource;
            this.idFormaPagoDataGridViewComboBoxColumn.DisplayMember = "TipoFormaPago";
            this.idFormaPagoDataGridViewComboBoxColumn.HeaderText = "FormaPago";
            this.idFormaPagoDataGridViewComboBoxColumn.Name = "idFormaPagoDataGridViewComboBoxColumn";
            this.idFormaPagoDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idFormaPagoDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idFormaPagoDataGridViewComboBoxColumn.ValueMember = "Id";
            // 
            // idVendedorDataGridViewComboBoxColumn
            // 
            this.idVendedorDataGridViewComboBoxColumn.DataPropertyName = "IdVendedor";
            this.idVendedorDataGridViewComboBoxColumn.DataSource = this.vendedorBindingSource;
            this.idVendedorDataGridViewComboBoxColumn.DisplayMember = "Nombre";
            this.idVendedorDataGridViewComboBoxColumn.HeaderText = "Vendedor";
            this.idVendedorDataGridViewComboBoxColumn.Name = "idVendedorDataGridViewComboBoxColumn";
            this.idVendedorDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idVendedorDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idVendedorDataGridViewComboBoxColumn.ValueMember = "Id";
            // 
            // idClienteDataGridViewComboBoColumn
            // 
            this.idClienteDataGridViewComboBoColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewComboBoColumn.DataSource = this.clienteBindingSource;
            this.idClienteDataGridViewComboBoColumn.DisplayMember = "Nombre";
            this.idClienteDataGridViewComboBoColumn.HeaderText = "Cliente";
            this.idClienteDataGridViewComboBoColumn.Name = "idClienteDataGridViewComboBoColumn";
            this.idClienteDataGridViewComboBoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idClienteDataGridViewComboBoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idClienteDataGridViewComboBoColumn.ValueMember = "Id";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            // 
            // idProductoDataGridViewComboBoxColumn
            // 
            this.idProductoDataGridViewComboBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewComboBoxColumn.DataSource = this.productoBindingSource;
            this.idProductoDataGridViewComboBoxColumn.DisplayMember = "Nombre";
            this.idProductoDataGridViewComboBoxColumn.HeaderText = "Producto";
            this.idProductoDataGridViewComboBoxColumn.Name = "idProductoDataGridViewComboBoxColumn";
            this.idProductoDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idProductoDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idProductoDataGridViewComboBoxColumn.ValueMember = "Id";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            // 
            // MainMenu
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 532);
            this.Controls.Add(this.FactGridView);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FactGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private MetroFramework.Controls.MetroTile btnCrear;
        private System.Windows.Forms.DataGridView FactGridView;
        private System.Windows.Forms.BindingSource FactBindingSource;
        private BillingDbDataSet billingDbDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idFormaPagoDataGridViewComboBoxColumn;
        private System.Windows.Forms.BindingSource formaPagoBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn idVendedorDataGridViewComboBoxColumn;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn idClienteDataGridViewComboBoColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idProductoDataGridViewComboBoxColumn;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private BillingDbDataSetTableAdapters.FacturasTableAdapter facturasTableAdapter;
    }
}