using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryInicioSesionLogs;

namespace pryGauna_Gestion
{
    public partial class frmMain : Form
    {
        clsUsuario clsUsuario;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblLogIn.Text = "LOGIN";
            lblUser.Text = "User";
            lblPassword.Text = "Password";

            btnLogIn.Text = "Login";

            clsUsuario = new clsUsuario();
            tstrConnectioStatus.Text = clsUsuario.estadoConexion;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
