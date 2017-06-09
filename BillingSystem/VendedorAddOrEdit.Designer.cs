namespace BillingSystem
{
    partial class VendedorAddOrEdit
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
            this.vendedorEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCostoUnitario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.checkEstado = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorEditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorEditBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(151, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // vendedorEditBindingSource
            // 
            this.vendedorEditBindingSource.DataSource = typeof(BillingSystem.Modelos.Vendedor);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nombre: ";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorEditBindingSource, "PorcientoComision", true));
            this.txtCostoUnitario.Location = new System.Drawing.Point(152, 127);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(208, 23);
            this.txtCostoUnitario.TabIndex = 5;
            this.txtCostoUnitario.Click += new System.EventHandler(this.txtCostoUnitario_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Porciento Comision:";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 44);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(24, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 44);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.vendedorEditBindingSource, "Estado", true));
            this.checkEstado.Location = new System.Drawing.Point(152, 169);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(28, 15);
            this.checkEstado.TabIndex = 14;
            this.checkEstado.Text = "?";
            this.checkEstado.UseVisualStyleBackColor = true;
            this.checkEstado.CheckedChanged += new System.EventHandler(this.checkEstado_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 167);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Estado:";
            // 
            // VendedorAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 308);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VendedorAddOrEdit";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.VendedorAddOrEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendedorEditBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCostoUnitario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroCheckBox checkEstado;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.BindingSource vendedorEditBindingSource;
    }
}