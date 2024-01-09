using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Regional_de_Credito
{
    public partial class frm_consulta_regional_credito : Form
    {
        string connectionString = "Server = localhost\\SQLEXPRESS; Database = credisanchez_company; Trusted_Connection = True; ";
        public frm_consulta_regional_credito()
        {
            InitializeComponent();
        }

        private void btn_search_client_Click(object sender, EventArgs e)
        {
            string nombre = txtreg_nombre_cliente.Text.Trim();
            string apellidoPaterno = txtreg_apellido_paterno.Text.Trim();
            string apellidoMaterno = txtreg_apellido_materno.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM Clientes WHERE nombre LIKE @nombre AND apellido_paterno LIKE @apellido_paterno AND apellido_materno LIKE @apellido_materno";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                dataAdapter.SelectCommand.Parameters.AddWithValue("@apellido_paterno", "%" + apellidoPaterno + "%");
                dataAdapter.SelectCommand.Parameters.AddWithValue("@apellido_materno", "%" + apellidoMaterno + "%");

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                DGV_Consulta_regional.DataSource = dataTable;
            }
        }

        private void frm_consulta_regional_credito_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'credisanchez_companyDataSet3.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter1.Fill(this.credisanchez_companyDataSet3.Clientes);
        }
    }
}
