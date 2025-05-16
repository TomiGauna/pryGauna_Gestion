using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGauna_Gestion
{
    public partial class frmDisplay : Form
    {
        public frmDisplay(string user)
        {
            InitializeComponent();
            tslUsername.Text = user + " -";
        }

        private void frmDisplay_Load(object sender, EventArgs e)
        {
            btnGet.Text = "Get Providers";
            tslDate.Text = DateTime.Now.ToString();            

            dgvDisplay.Columns.Add("col1", "Nº");
            dgvDisplay.Columns.Add("col2", "Entidad");
            dgvDisplay.Columns.Add("col3", "APERTURA");
            dgvDisplay.Columns.Add("col4", "Nº EXPTE");
            dgvDisplay.Columns.Add("col5", "JUZGADO");
            dgvDisplay.Columns.Add("col6", "JURISDICCION");
            dgvDisplay.Columns.Add("col7", "DIRECCION");
            dgvDisplay.Columns.Add("col8", "LIQUIDADOR RESPONSABLE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fileLocation = @"../../Requirements/datosProveedor.txt";
                if (File.Exists(fileLocation))
                {
                    using (StreamReader leer = new StreamReader(fileLocation))
                    {
                        string registro;
                        while ((registro = leer.ReadLine()) != null)
                        {
                            string[] campos = registro.Split('|');
                            dgvDisplay.Rows.Add(campos[0], campos[1], campos[2], campos[3], campos[4], campos[5], campos[6], campos[7]);
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            
        }
    }
}
