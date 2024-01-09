namespace Consulta_Regional_de_Credito
{
    partial class frm_consulta_regional_credito
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtreg_apellido_materno = new System.Windows.Forms.TextBox();
            this.txtreg_apellido_paterno = new System.Windows.Forms.TextBox();
            this.btn_search_client = new System.Windows.Forms.Button();
            this.txtreg_nombre_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV_Consulta_regional = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografia_cliente = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidopaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidomaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_casa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresos_mensuales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_referencia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paterno_referencia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_materno_referencia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_referencia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_referencia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paterno_referencia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_materno_referencia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_referencia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.credisanchez_companyDataSet3 = new Consulta_Regional_de_Credito.credisanchez_companyDataSet3();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.credisanchez_companyDataSet = new Consulta_Regional_de_Credito.credisanchez_companyDataSet();
            this.clientesTableAdapter = new Consulta_Regional_de_Credito.credisanchez_companyDataSetTableAdapters.ClientesTableAdapter();
            this.credisanchez_companyDataSet2 = new Consulta_Regional_de_Credito.credisanchez_companyDataSet2();
            this.consultacreditoclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consulta_credito_clienteTableAdapter = new Consulta_Regional_de_Credito.credisanchez_companyDataSet2TableAdapters.Consulta_credito_clienteTableAdapter();
            this.clientesTableAdapter1 = new Consulta_Regional_de_Credito.credisanchez_companyDataSet3TableAdapters.ClientesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Consulta_regional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credisanchez_companyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credisanchez_companyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credisanchez_companyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultacreditoclienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.txtreg_apellido_materno);
            this.panel1.Controls.Add(this.txtreg_apellido_paterno);
            this.panel1.Controls.Add(this.btn_search_client);
            this.panel1.Controls.Add(this.txtreg_nombre_cliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1561, 39);
            this.panel1.TabIndex = 1;
            // 
            // txtreg_apellido_materno
            // 
            this.txtreg_apellido_materno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreg_apellido_materno.Location = new System.Drawing.Point(1104, 4);
            this.txtreg_apellido_materno.Name = "txtreg_apellido_materno";
            this.txtreg_apellido_materno.Size = new System.Drawing.Size(302, 29);
            this.txtreg_apellido_materno.TabIndex = 4;
            this.txtreg_apellido_materno.Text = "APELLIDO MATERNO";
            this.txtreg_apellido_materno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtreg_apellido_paterno
            // 
            this.txtreg_apellido_paterno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreg_apellido_paterno.Location = new System.Drawing.Point(779, 4);
            this.txtreg_apellido_paterno.Name = "txtreg_apellido_paterno";
            this.txtreg_apellido_paterno.Size = new System.Drawing.Size(302, 29);
            this.txtreg_apellido_paterno.TabIndex = 3;
            this.txtreg_apellido_paterno.Text = "APELLIDO PATERNO";
            this.txtreg_apellido_paterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_search_client
            // 
            this.btn_search_client.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_client.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_client.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_search_client.Location = new System.Drawing.Point(1427, 3);
            this.btn_search_client.Name = "btn_search_client";
            this.btn_search_client.Size = new System.Drawing.Size(84, 31);
            this.btn_search_client.TabIndex = 2;
            this.btn_search_client.Text = "BUSCAR";
            this.btn_search_client.UseVisualStyleBackColor = false;
            this.btn_search_client.Click += new System.EventHandler(this.btn_search_client_Click);
            // 
            // txtreg_nombre_cliente
            // 
            this.txtreg_nombre_cliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreg_nombre_cliente.Location = new System.Drawing.Point(453, 5);
            this.txtreg_nombre_cliente.Name = "txtreg_nombre_cliente";
            this.txtreg_nombre_cliente.Size = new System.Drawing.Size(302, 29);
            this.txtreg_nombre_cliente.TabIndex = 1;
            this.txtreg_nombre_cliente.Text = "NOMBRE";
            this.txtreg_nombre_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(-5, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSQUEDA REGIONAL DE CREDITO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGV_Consulta_regional);
            this.panel2.Location = new System.Drawing.Point(75, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1405, 740);
            this.panel2.TabIndex = 2;
            // 
            // DGV_Consulta_regional
            // 
            this.DGV_Consulta_regional.AutoGenerateColumns = false;
            this.DGV_Consulta_regional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Consulta_regional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fotografia_cliente,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidopaternoDataGridViewTextBoxColumn,
            this.apellidomaternoDataGridViewTextBoxColumn,
            this.fecha_nacimiento,
            this.calle,
            this.numero_casa,
            this.colonia,
            this.municipio,
            this.telefono,
            this.ingresos_mensuales,
            this.nombre_referencia1,
            this.apellido_paterno_referencia1,
            this.apellido_materno_referencia1,
            this.telefono_referencia1,
            this.nombre_referencia2,
            this.apellido_paterno_referencia2,
            this.apellido_materno_referencia2,
            this.telefono_referencia2});
            this.DGV_Consulta_regional.DataSource = this.clientesBindingSource1;
            this.DGV_Consulta_regional.Location = new System.Drawing.Point(32, 25);
            this.DGV_Consulta_regional.Name = "DGV_Consulta_regional";
            this.DGV_Consulta_regional.Size = new System.Drawing.Size(1346, 695);
            this.DGV_Consulta_regional.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotografia_cliente
            // 
            this.fotografia_cliente.DataPropertyName = "fotografia_cliente";
            this.fotografia_cliente.HeaderText = "fotografia_cliente";
            this.fotografia_cliente.Name = "fotografia_cliente";
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
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.DataPropertyName = "fecha_nacimiento";
            this.fecha_nacimiento.HeaderText = "fecha_nacimiento";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "calle";
            this.calle.Name = "calle";
            // 
            // numero_casa
            // 
            this.numero_casa.DataPropertyName = "numero_casa";
            this.numero_casa.HeaderText = "numero_casa";
            this.numero_casa.Name = "numero_casa";
            // 
            // colonia
            // 
            this.colonia.DataPropertyName = "colonia";
            this.colonia.HeaderText = "colonia";
            this.colonia.Name = "colonia";
            // 
            // municipio
            // 
            this.municipio.DataPropertyName = "municipio";
            this.municipio.HeaderText = "municipio";
            this.municipio.Name = "municipio";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            // 
            // ingresos_mensuales
            // 
            this.ingresos_mensuales.DataPropertyName = "ingresos_mensuales";
            this.ingresos_mensuales.HeaderText = "ingresos_mensuales";
            this.ingresos_mensuales.Name = "ingresos_mensuales";
            // 
            // nombre_referencia1
            // 
            this.nombre_referencia1.DataPropertyName = "nombre_referencia1";
            this.nombre_referencia1.HeaderText = "nombre_referencia1";
            this.nombre_referencia1.Name = "nombre_referencia1";
            // 
            // apellido_paterno_referencia1
            // 
            this.apellido_paterno_referencia1.DataPropertyName = "apellido_paterno_referencia1";
            this.apellido_paterno_referencia1.HeaderText = "apellido_paterno_referencia1";
            this.apellido_paterno_referencia1.Name = "apellido_paterno_referencia1";
            // 
            // apellido_materno_referencia1
            // 
            this.apellido_materno_referencia1.DataPropertyName = "apellido_materno_referencia1";
            this.apellido_materno_referencia1.HeaderText = "apellido_materno_referencia1";
            this.apellido_materno_referencia1.Name = "apellido_materno_referencia1";
            // 
            // telefono_referencia1
            // 
            this.telefono_referencia1.DataPropertyName = "telefono_referencia1";
            this.telefono_referencia1.HeaderText = "telefono_referencia1";
            this.telefono_referencia1.Name = "telefono_referencia1";
            // 
            // nombre_referencia2
            // 
            this.nombre_referencia2.DataPropertyName = "nombre_referencia2";
            this.nombre_referencia2.HeaderText = "nombre_referencia2";
            this.nombre_referencia2.Name = "nombre_referencia2";
            // 
            // apellido_paterno_referencia2
            // 
            this.apellido_paterno_referencia2.DataPropertyName = "apellido_paterno_referencia2";
            this.apellido_paterno_referencia2.HeaderText = "apellido_paterno_referencia2";
            this.apellido_paterno_referencia2.Name = "apellido_paterno_referencia2";
            // 
            // apellido_materno_referencia2
            // 
            this.apellido_materno_referencia2.DataPropertyName = "apellido_materno_referencia2";
            this.apellido_materno_referencia2.HeaderText = "apellido_materno_referencia2";
            this.apellido_materno_referencia2.Name = "apellido_materno_referencia2";
            // 
            // telefono_referencia2
            // 
            this.telefono_referencia2.DataPropertyName = "telefono_referencia2";
            this.telefono_referencia2.HeaderText = "telefono_referencia2";
            this.telefono_referencia2.Name = "telefono_referencia2";
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.credisanchez_companyDataSet3;
            // 
            // credisanchez_companyDataSet3
            // 
            this.credisanchez_companyDataSet3.DataSetName = "credisanchez_companyDataSet3";
            this.credisanchez_companyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.credisanchez_companyDataSet;
            // 
            // credisanchez_companyDataSet
            // 
            this.credisanchez_companyDataSet.DataSetName = "credisanchez_companyDataSet";
            this.credisanchez_companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // credisanchez_companyDataSet2
            // 
            this.credisanchez_companyDataSet2.DataSetName = "credisanchez_companyDataSet2";
            this.credisanchez_companyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultacreditoclienteBindingSource
            // 
            this.consultacreditoclienteBindingSource.DataMember = "Consulta_credito_cliente";
            this.consultacreditoclienteBindingSource.DataSource = this.credisanchez_companyDataSet2;
            // 
            // consulta_credito_clienteTableAdapter
            // 
            this.consulta_credito_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_consulta_regional_credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 1022);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_consulta_regional_credito";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_consulta_regional_credito_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Consulta_regional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credisanchez_companyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credisanchez_companyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credisanchez_companyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultacreditoclienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtreg_apellido_materno;
        private System.Windows.Forms.TextBox txtreg_apellido_paterno;
        private System.Windows.Forms.Button btn_search_client;
        private System.Windows.Forms.TextBox txtreg_nombre_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_Consulta_regional;
        private credisanchez_companyDataSet credisanchez_companyDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private credisanchez_companyDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private credisanchez_companyDataSet2 credisanchez_companyDataSet2;
        private System.Windows.Forms.BindingSource consultacreditoclienteBindingSource;
        private credisanchez_companyDataSet2TableAdapters.Consulta_credito_clienteTableAdapter consulta_credito_clienteTableAdapter;
        private credisanchez_companyDataSet3 credisanchez_companyDataSet3;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private credisanchez_companyDataSet3TableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotografia_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidopaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidomaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_casa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresos_mensuales;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_referencia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paterno_referencia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_materno_referencia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_referencia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_referencia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paterno_referencia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_materno_referencia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_referencia2;
    }
}

