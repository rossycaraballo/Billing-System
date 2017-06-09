using BillingSystem.Modelos;

namespace BillingSystem
{
    partial class frmAgregarClientes
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.bindingCliente = new System.Windows.Forms.BindingSource(this.components);
            this.txtDocumento = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tipoDocumentoCombobox = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.checkEstado = new MetroFramework.Controls.MetroCheckBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(97, 105);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre: ";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingCliente, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(211, 103);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 28);
            this.txtNombre.TabIndex = 1;
            // 
            // bindingCliente
            // 
            this.bindingCliente.DataSource = typeof(BillingSystem.Modelos.Cliente);
            // 
            // txtDocumento
            // 
            this.txtDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingCliente, "Documento", true));
            this.txtDocumento.Location = new System.Drawing.Point(211, 150);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(277, 28);
            this.txtDocumento.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(80, 153);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Documento:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 202);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Tipo Documento:";
            // 
            // tipoDocumentoCombobox
            // 
            this.tipoDocumentoCombobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingCliente, "IdTipoDocumento", true));
            this.tipoDocumentoCombobox.FormattingEnabled = true;
            this.tipoDocumentoCombobox.ItemHeight = 24;
            this.tipoDocumentoCombobox.Location = new System.Drawing.Point(211, 198);
            this.tipoDocumentoCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.tipoDocumentoCombobox.Name = "tipoDocumentoCombobox";
            this.tipoDocumentoCombobox.Size = new System.Drawing.Size(276, 30);
            this.tipoDocumentoCombobox.Style = MetroFramework.MetroColorStyle.Blue;
            this.tipoDocumentoCombobox.TabIndex = 5;
            this.tipoDocumentoCombobox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingCliente, "Cuenta", true));
            this.metroTextBox1.Location = new System.Drawing.Point(211, 254);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(277, 28);
            this.metroTextBox1.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(119, 256);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 20);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Cuenta:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(119, 303);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 20);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Estado:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 395);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 54);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingCliente, "Estado", true));
            this.checkEstado.Location = new System.Drawing.Point(211, 306);
            this.checkEstado.Margin = new System.Windows.Forms.Padding(4);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(30, 17);
            this.checkEstado.TabIndex = 11;
            this.checkEstado.Text = "?";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataSource = typeof(BillingSystem.Modelos.TipoDocumento);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(97, 395);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(160, 54);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Cancelar";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // frmAgregarClientes
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 479);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tipoDocumentoCombobox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAgregarClientes";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = " Cliente";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.frmAgregarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtDocumento;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox tipoDocumentoCombobox;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroCheckBox checkEstado;
        private System.Windows.Forms.BindingSource bindingCliente;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}