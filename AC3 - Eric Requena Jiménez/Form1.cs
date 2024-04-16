using System.Windows.Forms;
using System.Xml.Serialization;
using classComarca;

namespace AC3___Eric_Requena_Jiménez
{
    public partial class Form1 : Form
    {
        private List<Comarca> comarques;
        public Form1()
        {
            InitializeComponent();
            LBLPoblacio.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            CargarDatosCSV();
            string rutaXML = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).xml";
            if (!File.Exists(rutaXML))
            {
                CreateXML();
            }
            ChargeComboBoxComarca();
            Cuadro.CellClick += DataGridView1_CellClick;



        }



        private void CargarDatosCSV()
        {
            string rutaArchivo = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).csv";
            Cuadro.DataSource = Helper.ReadCSV(rutaArchivo);

        }

        private void CreateXML()
        {
            string rutaXML = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).xml";
            string rutaArchivo = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).csv";
            Helper.CrearXmlDesdeCsv(rutaArchivo, rutaXML);
        }

        private void ChargeComboBoxComarca()
        {
            string rutaXML = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).xml";
            Helper.CargarXmlEnComboBox(rutaXML, ComarcaText);


        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtén el valor de la celda correspondiente a la población
                object poblacionObj = Cuadro.Rows[e.RowIndex].Cells[3].Value;

                // Verifica si el valor no es nulo y es convertible a entero
                if (poblacionObj != null && poblacionObj != DBNull.Value)
                {
                    // Intenta convertir el valor a entero
                    if (int.TryParse(poblacionObj.ToString(), out int poblacion))
                    {
                        // Ejecuta la función IdentificarComarquesPoblacioSuperior y actualiza los labels
                        IdentificarComarquesPoblacioSuperior(poblacion);
                        return; // Sale del método después de la ejecución exitosa
                    }
                }

                // Si no se pudo obtener la población válida, muestra un mensaje de error
                MessageBox.Show("No se pudo obtener la población válida de la celda seleccionada.");
            }
        }


        private void IdentificarComarquesPoblacioSuperior(int poblacion)
        {
            if (poblacion != null)
            {
                LBLPoblacio.Text = (poblacion > 20000) ? "SI" : "NO";
            }
            else
            {
                // Manejar el caso en que comarca sea null
                LBLPoblacio.Text = "No hay datos de poblacion";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gestio_Click(object sender, EventArgs e)
        {

        }

        private void Year_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PoblacióText.Text = "";
            AnyText.Text = "";
            ComarcaText.Text = "";
            DomésticText.Text = "";
            ActivitatsText.Text = "";
            TotalText.Text = "";
            ConsumText.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
