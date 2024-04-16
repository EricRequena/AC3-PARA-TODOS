using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using AC3___Eric_Requena_Jiménez; 

namespace AC3___Eric_Requena_Jiménez
{
    public class Helper
    {
        public static DataTable ReadCSV(string rutaArchivo)
        {
            DataTable dataTable = new DataTable();

            // Llegeix la primera linea per obtenir el header
            string[] header;
            using (TextFieldParser parser = new TextFieldParser(rutaArchivo))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                if (!parser.EndOfData)
                {
                    header = parser.ReadFields();
                }
                else
                {
                    return null; // Si el fitxer està buit, retorna null
                }
            }

            // Afegir les columnes al DataTable
            foreach (string encabezado in header)
            {
                dataTable.Columns.Add(encabezado);
            }

            // Llegir les dades del fitxer i afegir-les al DataTable
            using (TextFieldParser parser = new TextFieldParser(rutaArchivo))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // Ignorar el header
                parser.ReadLine();

                // Llegir les dades
                while (!parser.EndOfData)
                {
                    string[] campos = parser.ReadFields();

                    // Afegeix una fila al DataTable
                    dataTable.Rows.Add(campos);
                }
            }
            return dataTable;
        }



        public static void CrearXmlDesdeCsv(string rutaArchivo, string rutaXml)
        {
            // Creamos un nuevo documento XML
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = xmlDoc.CreateElement("Comarcas");
            xmlDoc.InsertBefore(xmlDeclaration, xmlDoc.DocumentElement);
            xmlDoc.AppendChild(root);

            // Leemos todas las líneas del archivo CSV
            string[] lineas = File.ReadAllLines(rutaArchivo);

            // Iteramos sobre las líneas para crear elementos XML
            for (int i = 1; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(',');
                if (campos.Length < 3)
                    continue;
                
                // Creamos un nuevo elemento para cada línea del CSV
                XmlElement comarca = xmlDoc.CreateElement("Comarca");
                comarca.SetAttribute("Codigo", campos[1]);
                comarca.InnerText = campos[2] + "," + campos[3];

                root.AppendChild(comarca);
            }

            // Guardamos el documento XML
            xmlDoc.Save(rutaXml);
        }

        public static void CargarXmlEnComboBox(string rutaXml, ComboBox comboBox)
        {
            // Limpiamos el ComboBox antes de cargar nuevos datos
            comboBox.Items.Clear();

            // Cargamos el documento XML
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(rutaXml);

            // Iteramos sobre los elementos XML y agregamos los datos al ComboBox
            foreach (XmlNode nodo in xmlDoc.DocumentElement.ChildNodes)
            {
                
                string nombre = nodo.InnerText;
                comboBox.Items.Add(nombre);
            }

            // Seleccionamos el primer elemento del ComboBox (opcional)
            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;
        }
    }
}
