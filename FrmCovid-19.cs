namespace Covid_19_2
{
    public partial class FrmCovid19 : Form
    {
        //Variables globales
        string vTos = "";
        string vFiebre = "";
        string vCansancio = "";
        string vIncapacidad = "";
        string vRespiracion = "";
        string vDolor = "";
        string TipoSexo = "";
        string provincia = "";
        public FrmCovid19()
        {
            InitializeComponent();
        }

        private void FrmCovid19_Load(object sender, EventArgs e)
        {
            txtFechaActual.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void cbFiebre_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFiebre.Checked == true)
            {
                vFiebre = "Fiebre";
            }
            else
            {
                vFiebre = "";
            }
        }

        private void cbTos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTos.Checked == true)
            {
                vTos = "Tos";
            }
            else
            {
                vTos = "";
            }
        }

        private void cbCansancio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCansancio.Checked == true)
            {
                vCansancio = "Cansancio";
            }
            else
            {
                vCansancio = "";
            }
        }

        private void cbDifResp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDifResp.Checked == true)
            {
                vRespiracion = "Respiracion";
            }
            else
            {
                vRespiracion = "";
            }
        }

        private void cbPecho_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPecho.Checked == true)
            {
                vDolor = "Dolor Pecho";
            }
            else
            {
                vDolor = "";
            }
        }

        private void cbMovilidad_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMovilidad.Checked == true)
            {
                vIncapacidad = "Incapacidad de hablar o moverse";
            }
            else
            {
                vIncapacidad = "";
            }
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemenino.Checked == true)
            {
                txtOtro.Enabled = false;
                TipoSexo = "Femenino";
            }
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMasculino.Checked == true)
            {
                txtOtro.Enabled = false;
                TipoSexo = "Masculino";
            }
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtro.Checked == true)
            {
                txtOtro.Enabled = true;
                TipoSexo = txtOtro.Text;
            }
        }

        private void cbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvincias.SelectedIndex != -1)
            {
                provincia = cbProvincias.Text;
            }
        }

        private void btnResumir_Click(object sender, EventArgs e)
        {
            string mensaje0 = "Información Diagnóstico CoronaVirus - Covid-19 ";
            string mensaje1 = "Nombre: " + txtNombre.Text + " " + txtPrimerApellido.Text + " " + txtSegundoApellido.Text;
            string mensaje2 = "Fecha: " + txtFechaActual.Text + "Dirección: " + txtDireccion.Text;
            string mensaje3 = "Género: " + TipoSexo + "Correo Electrónico: " + txtCorreo.Text;
            string mensaje4 = "Síntomas básicos: " + vFiebre + " " + vTos + " " + vCansancio + " ";
            string mensaje5 = "Síntomas Graves: " + vRespiracion + " " + vDolor + " " + vIncapacidad;

            DialogResult Resultado = new DialogResult();
            Resultado = MessageBox.Show(mensaje0 + mensaje1 + mensaje2 + mensaje3 + mensaje4 + mensaje5 + " ",
                                        "Información General Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrarA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro?", "Registro Pacientes",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}