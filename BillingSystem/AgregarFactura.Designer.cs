namespace BillingSystem
{
    partial class AgregarFactura
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
            this.FormaPagoCombobox = new MetroFramework.Controls.MetroComboBox();
            this.BindingFactura = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.VendedorCombobox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ClienteComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ProductoComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.lblPrecio = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtComentario = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BindingFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // FormaPagoCombobox
            // 
            this.FormaPagoCombobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BindingFactura, "IdFormaPago", true));
            this.FormaPagoCombobox.FormattingEnabled = true;
            this.FormaPagoCombobox.ItemHeight = 23;
            this.FormaPagoCombobox.Location = new System.Drawing.Point(160, 106);
            this.FormaPagoCombobox.Name = "FormaPagoCombobox";
            this.FormaPagoCombobox.Size = new System.Drawing.Size(208, 29);
            this.FormaPagoCombobox.Style = MetroFramework.MetroColorStyle.Blue;
            this.FormaPagoCombobox.TabIndex = 7;
            this.FormaPagoCombobox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // BindingFactura
            // 
            this.BindingFactura.DataSource = typeof(BillingSystem.Modelos.Factura);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(35, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Forma de Pago:";
            // 
            // VendedorCombobox
            // 
            this.VendedorCombobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BindingFactura, "IdVendedor", true));
            this.VendedorCombobox.FormattingEnabled = true;
            this.VendedorCombobox.ItemHeight = 23;
            this.VendedorCombobox.Location = new System.Drawing.Point(160, 153);
            this.VendedorCombobox.Name = "VendedorCombobox";
            this.VendedorCombobox.Size = new System.Drawing.Size(208, 29);
            this.VendedorCombobox.Style = MetroFramework.MetroColorStyle.Blue;
            this.VendedorCombobox.TabIndex = 9;
            this.VendedorCombobox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 156);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Vendedor:";
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BindingFactura, "IdCliente", true));
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.ItemHeight = 23;
            this.ClienteComboBox.Location = new System.Drawing.Point(160, 201);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(208, 29);
            this.ClienteComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.ClienteComboBox.TabIndex = 11;
            this.ClienteComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 204);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Cliente:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(34, 394);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Comentario:";
            // 
            // ProductoComboBox
            // 
            this.ProductoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BindingFactura, "IdProducto", true));
            this.ProductoComboBox.FormattingEnabled = true;
            this.ProductoComboBox.ItemHeight = 23;
            this.ProductoComboBox.Location = new System.Drawing.Point(160, 254);
            this.ProductoComboBox.Name = "ProductoComboBox";
            this.ProductoComboBox.Size = new System.Drawing.Size(208, 29);
            this.ProductoComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductoComboBox.TabIndex = 16;
            this.ProductoComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(35, 257);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Producto:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingFactura, "Cantidad", true));
            this.txtCantidad.Location = new System.Drawing.Point(160, 300);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(208, 23);
            this.txtCantidad.TabIndex = 18;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(35, 300);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Cantidad:";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingFactura, "PrecioUnitario", true));
            this.txtPrecio.Location = new System.Drawing.Point(160, 346);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(208, 23);
            this.txtPrecio.TabIndex = 20;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(35, 350);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 19);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 542);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(120, 44);
            this.metroButton1.TabIndex = 22;
            this.metroButton1.Text = "Cancelar";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(363, 542);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 44);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingFactura, "Comentario", true));
            this.txtComentario.Location = new System.Drawing.Point(160, 394);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(208, 23);
            this.txtComentario.TabIndex = 23;
            // 
            // AgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 631);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.ProductoComboBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.ClienteComboBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.VendedorCombobox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.FormaPagoCombobox);
            this.Controls.Add(this.metroLabel3);
            this.Name = "AgregarFactura";
            this.Text = "AgregarFactura";
            this.Load += new System.EventHandler(this.AgregarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox FormaPagoCombobox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox VendedorCombobox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox ClienteComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox ProductoComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtCantidad;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroLabel lblPrecio;
        private System.Windows.Forms.BindingSource BindingFactura;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtComentario;
    }
}