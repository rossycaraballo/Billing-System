namespace BillingSystem
{
    partial class ProductoAddOrEdit
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
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCostoUnitario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPrecioUnitario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.checkEstado = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(152, 107);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 28);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(BillingSystem.Modelos.Producto);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 107);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nombre: ";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "CostoUnitario", true));
            this.txtCostoUnitario.Location = new System.Drawing.Point(152, 157);
            this.txtCostoUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(277, 28);
            this.txtCostoUnitario.TabIndex = 5;
            this.txtCostoUnitario.Click += new System.EventHandler(this.txtCostoUnitario_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 157);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Costo Unitario:";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "PrecioUnitario", true));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(152, 215);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(277, 28);
            this.txtPrecioUnitario.TabIndex = 7;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 215);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Precio Unitario:";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(279, 391);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 54);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(47, 391);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 54);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.productoBindingSource, "Estado", true));
            this.checkEstado.Location = new System.Drawing.Point(152, 276);
            this.checkEstado.Margin = new System.Windows.Forms.Padding(4);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(30, 17);
            this.checkEstado.TabIndex = 14;
            this.checkEstado.Text = "?";
            this.checkEstado.UseVisualStyleBackColor = true;
            this.checkEstado.CheckedChanged += new System.EventHandler(this.checkEstado_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(46, 273);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 20);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Estado:";
            // 
            // ProductoAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 478);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ProductoAddOrEdit";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCostoUnitario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPrecioUnitario;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroCheckBox checkEstado;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.BindingSource productoBindingSource;
    }
}