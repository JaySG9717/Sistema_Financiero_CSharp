namespace Consulta_de_Movimientos
{
    partial class frm_consulta_movimientos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidopaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidomaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadsolicitadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalapagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazoprestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaprestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeropedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diadepagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultacreditoclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.credisanchez_companyDataSet = new Consulta_de_Movimientos.credisanchez_companyDataSet();
            this.consulta_credito_clienteTableAdapter = new Consulta_de_Movimientos.credisanchez_companyDataSetTableAdapters.Consulta_credito_clienteTableAdapter();
            this.credisanchez_companyDataSet1 = new Consulta_de_Movimientos.credisanchez_companyDataSet1();
            this.consultacreditoclienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.consulta_credito_clienteTableAdapter1 = new Consulta_de_Movimientos.credisanchez_companyDataSet1TableAdapters.Consulta_credito_clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultacreditoclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credisanchez_companyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credisanchez_companyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultacreditoclienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-7, -6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(908, 86);
            this.label8.TabIndex = 8;
            this.label8.Text = "CONSULTAS DE INVENTARIO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidopaternoDataGridViewTextBoxColumn,
            this.apellidomaternoDataGridViewTextBoxColumn,
            this.cantidadsolicitadaDataGridViewTextBoxColumn,
            this.totalapagarDataGridViewTextBoxColumn,
            this.plazoprestamoDataGridViewTextBoxColumn,
            this.fechaprestamoDataGridViewTextBoxColumn,
            this.numeropedidoDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.diadepagoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consultacreditoclienteBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(198, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 563);
            this.dataGridView1.TabIndex = 9;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidopaternoDataGridViewTextBoxColumn
            // 
            this.apellidopaternoDataGridViewTextBoxColumn.DataPropertyName = "apellido_paterno";
            this.apellidopaternoDataGridViewTextBoxColumn.HeaderText = "apellido_paterno";
            this.apellidopaternoDataGridViewTextBoxColumn.Name = "apellidopaternoDataGridViewTextBoxColumn";
            // 
            // apellidomaternoDataGridViewTextBoxColumn
            // 
            this.apellidomaternoDataGridViewTextBoxColumn.DataPropertyName = "apellido_materno";
            this.apellidomaternoDataGridViewTextBoxColumn.HeaderText = "apellido_materno";
            this.apellidomaternoDataGridViewTextBoxColumn.Name = "apellidomaternoDataGridViewTextBoxColumn";
            // 
            // cantidadsolicitadaDataGridViewTextBoxColumn
            // 
            this.cantidadsolicitadaDataGridViewTextBoxColumn.DataPropertyName = "cantidad_solicitada";
            this.cantidadsolicitadaDataGridViewTextBoxColumn.HeaderText = "cantidad_solicitada";
            this.cantidadsolicitadaDataGridViewTextBoxColumn.Name = "cantidadsolicitadaDataGridViewTextBoxColumn";
            // 
            // totalapagarDataGridViewTextBoxColumn
            // 
            this.totalapagarDataGridViewTextBoxColumn.DataPropertyName = "total_a_pagar";
            this.totalapagarDataGridViewTextBoxColumn.HeaderText = "total_a_pagar";
            this.totalapagarDataGridViewTextBoxColumn.Name = "totalapagarDataGridViewTextBoxColumn";
            // 
            // plazoprestamoDataGridViewTextBoxColumn
            // 
            this.plazoprestamoDataGridViewTextBoxColumn.DataPropertyName = "plazo_prestamo";
            this.plazoprestamoDataGridViewTextBoxColumn.HeaderText = "plazo_prestamo";
            this.plazoprestamoDataGridViewTextBoxColumn.Name = "plazoprestamoDataGridViewTextBoxColumn";
            // 
            // fechaprestamoDataGridViewTextBoxColumn
            // 
            this.fechaprestamoDataGridViewTextBoxColumn.DataPropertyName = "fecha_prestamo";
            this.fechaprestamoDataGridViewTextBoxColumn.HeaderText = "fecha_prestamo";
            this.fechaprestamoDataGridViewTextBoxColumn.Name = "fechaprestamoDataGridViewTextBoxColumn";
            // 
            // numeropedidoDataGridViewTextBoxColumn
            // 
            this.numeropedidoDataGridViewTextBoxColumn.DataPropertyName = "numero_pedido";
            this.numeropedidoDataGridViewTextBoxColumn.HeaderText = "numero_pedido";
            this.numeropedidoDataGridViewTextBoxColumn.Name = "numeropedidoDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diadepagoDataGridViewTextBoxColumn
            // 
            this.diadepagoDataGridViewTextBoxColumn.DataPropertyName = "dia_de_pago";
            this.diadepagoDataGridViewTextBoxColumn.HeaderText = "dia_de_pago";
            this.diadepagoDataGridViewTextBoxColumn.Name = "diadepagoDataGridViewTextBoxColumn";
            // 
            // consultacreditoclienteBindingSource
            // 
            this.consultacreditoclienteBindingSource.DataMember = "Consulta_credito_cliente";
            this.consultacreditoclienteBindingSource.DataSource = this.credisanchez_companyDataSet;
            // 
            // credisanchez_companyDataSet
            // 
            this.credisanchez_companyDataSet.DataSetName = "credisanchez_companyDataSet";
            this.credisanchez_companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consulta_credito_clienteTableAdapter
            // 
            this.consulta_credito_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // credisanchez_companyDataSet1
            // 
            this.credisanchez_companyDataSet1.DataSetName = "credisanchez_companyDataSet1";
            this.credisanchez_companyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultacreditoclienteBindingSource1
            // 
            this.consultacreditoclienteBindingSource1.DataMember = "Consulta_credito_cliente";
            this.consultacreditoclienteBindingSource1.DataSource = this.credisanchez_companyDataSet1;
            // 
            // consulta_credito_clienteTableAdapter1
            // 
            this.consulta_credito_clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_consulta_movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 1022);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_consulta_movimientos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_consulta_movimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultacreditoclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credisanchez_companyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credisanchez_companyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultacreditoclienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private credisanchez_companyDataSet credisanchez_companyDataSet;
        private System.Windows.Forms.BindingSource consultacreditoclienteBindingSource;
        private credisanchez_companyDataSetTableAdapters.Consulta_credito_clienteTableAdapter consulta_credito_clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidopaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidomaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadsolicitadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalapagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazoprestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeropedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diadepagoDataGridViewTextBoxColumn;
        private credisanchez_companyDataSet1 credisanchez_companyDataSet1;
        private System.Windows.Forms.BindingSource consultacreditoclienteBindingSource1;
        private credisanchez_companyDataSet1TableAdapters.Consulta_credito_clienteTableAdapter consulta_credito_clienteTableAdapter1;
    }
}

