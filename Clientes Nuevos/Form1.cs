using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using AForge.Video;
using AForge.Video.DirectShow;





namespace Clientes_Nuevos
{
    public partial class frm_solicitud_credito : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Bitmap currentFrame;
        public frm_solicitud_credito()
        {
            InitializeComponent();
        }

        private void frm_solicitud_credito_Load(object sender, EventArgs e)
        {
            // Inicializar la cámara web (asegúrate de tener permisos para acceder a la cámara)
            try
            {
                // Configura la cámara web (0 indica la primera cámara disponible)
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No se encontró ninguna cámara web disponible.");
                    return;
                }

                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al acceder a la cámara web: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Asignar la imagen capturada a la variable de nivel de clase
            currentFrame = (Bitmap)eventArgs.Frame.Clone();

            // Mostrar el fotograma capturado en el PictureBox
            pictureBox_Camera.Image = currentFrame;
        }


        private void btn_solicitar_credito_Click(object sender, EventArgs e)
        {
            // Obtener el valor de ingresos mensuales
            if (decimal.TryParse(txt_ingresos.Text, out decimal ingresosMensuales))
            {
                // Verificar si los ingresos son mayores a $5,000
                if (ingresosMensuales > 5000)
                {
                    // Mostrar un MessageBox con el mensaje de crédito autorizado
                    MessageBox.Show("Crédito autorizado.", "Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mostrar el panel con los campos de referencias personales
                    panel_referencias_personales.Visible = true;
                    panel_foto.Visible = true;
                }
                else
                {
                    // Mostrar un MessageBox con el mensaje de crédito no autorizado
                    MessageBox.Show("Crédito no autorizado.", "Rechazado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Ocultar el panel con los campos de referencias personales (si es que estaba visible)
                    panel_referencias_personales.Visible = false;
                    panel_foto.Visible = false;
                }
            }
            else
            {
                // Mostrar un MessageBox si el valor ingresado en el campo de ingresos mensuales no es válido
                MessageBox.Show("Ingresos mensuales inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btn_tomar_foto_Click(object sender, EventArgs e)
        {
            // Detiene la captura de video
            videoSource.SignalToStop();
            videoSource.WaitForStop();
        }

        private void btn_procesar_datos_Click(object sender, EventArgs e)
        {
            // Obtener la foto capturada en el PictureBox
            Bitmap fotoCapturada = (Bitmap)pictureBox_Camera.Image;

            // Convertir la foto a un arreglo de bytes
            byte[] fotoBytes = ImageToByteArray(fotoCapturada);

            // Obtener los datos ingresados en los TextBox Del Panel "DATOS DEL CLIENTE"
            string nombrecliente = txt_nombrecliente.Text;
            string apellido_paterno = txt_apellido_paterno.Text;
            string apellido_materno = txt_apellido_materno.Text;
            string calle = txt_calle.Text;

            // En valores enteros se intentara convertir los caracteres string a int, si lo ingresado es correcto se procede a guardar en la variable entera "Numero"
            int numero;
            if (!int.TryParse(txt_numero.Text, out numero))
            {
                MessageBox.Show("El número de domicilio ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string colonia = txt_colonia.Text;
            string municipio = txt_municipio.Text;
            
            long telefono;
            if (!long.TryParse(txt_telefono.Text, out telefono))
            {
                MessageBox.Show("El número telefonico del cliente no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ingresos_mensuales;
            if (!int.TryParse(txt_ingresos.Text, out ingresos_mensuales))
            {
                MessageBox.Show("La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los datos ingresados en los TextBox Del Panel "REFERENCIAS"
            string nombrereferencia1 = txt_nombre_referencia1.Text;
            string apellido_paterno_referencia1 = txt_ape_ref1.Text;
            string apellido_materno_referencia1 = txt_apem_ref1.Text;

            long telefono_referencia1;
            if (!long.TryParse(txt_tel_ref1.Text, out telefono_referencia1))
            {
                MessageBox.Show("El número de telefono de la referencia 1 no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombrereferencia2 = txt_nom_ref2.Text;
            string apellido_paterno_referencia2 = txt_apep_ref2.Text;
            string apellido_materno_referencia2 = txt_apem_ref2.Text;

            long telefono_referencia2;
            if (!long.TryParse(txt_tel_ref2.Text, out telefono_referencia2))
            {
                MessageBox.Show("El número de telefonico de la referencia 2  no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la fecha de nacimiento seleccionada en el DateTimePicker
            DateTime fechaNacimiento = dateTimePicker1.Value;

            // Guardar los datos y la foto en la base de datos
            string connectionString = "Server = localhost\\SQLEXPRESS; Database = credisanchez_company; Trusted_Connection = True; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO Clientes (Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, Calle, Numero_Casa, Colonia, Municipio, Telefono, Ingresos_Mensuales, Nombre_Referencia1, apellido_paterno_referencia1, apellido_materno_referencia1, telefono_referencia1, Nombre_Referencia2, apellido_paterno_referencia2, apellido_materno_referencia2, telefono_referencia2, fotografia_cliente) VALUES (@nombre, @apellido_paterno, @apellido_materno, @fecha_nacimiento, @calle, @numero_casa, @colonia, @municipio, @telefono, @ingresos_mensuales, @nombre_referencia1, @apellido_paterno_referencia1, @apellido_materno_referencia1, @telefono_referencia1, @nombre_referencia2, @apellido_paterno_referencia2, @apellido_materno_referencia2, @telefono_referencia2, @fotografia_cliente)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@nombre", nombrecliente);
                command.Parameters.AddWithValue("@apellido_paterno", apellido_paterno);
                command.Parameters.AddWithValue("@apellido_materno", apellido_materno);
                command.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@calle", calle);
                command.Parameters.AddWithValue("@numero_casa", numero);
                command.Parameters.AddWithValue("@colonia", colonia);
                command.Parameters.AddWithValue("@municipio", municipio);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@ingresos_mensuales", ingresos_mensuales);
                command.Parameters.AddWithValue("@nombre_referencia1", nombrereferencia1);
                command.Parameters.AddWithValue("@apellido_paterno_referencia1", apellido_paterno_referencia1);
                command.Parameters.AddWithValue("@apellido_materno_referencia1", apellido_materno_referencia1);
                command.Parameters.AddWithValue("@telefono_referencia1", telefono_referencia1);
                command.Parameters.AddWithValue("@nombre_referencia2", nombrereferencia2);
                command.Parameters.AddWithValue("@apellido_paterno_referencia2", apellido_paterno_referencia2);
                command.Parameters.AddWithValue("@apellido_materno_referencia2", apellido_materno_referencia2);
                command.Parameters.AddWithValue("@telefono_referencia2", telefono_referencia2);
                command.Parameters.AddWithValue("@fotografia_cliente", fotoBytes);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Solicitud procesada y datos guardados en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar la solicitud en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la solicitud en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Reiniciar la cámara web y la captura de video
            videoSource.Start();
        }



        private void btn_try_photo_Click_1(object sender, EventArgs e)
        {
            // Reiniciar la cámara web y la captura de video
            videoSource.Start();
        }
        // Convertir una imagen a un arreglo de bytes
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}