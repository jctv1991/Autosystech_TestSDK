using SDKAutoSysTech;
using SDKAutoSysTech.LPR;
using static SDKAutoSysTech.LPR.LPRCamaraHV;
namespace TestSDK
{
    public partial class Form1 : Form
    {
        string ipControlador = "192.168.18.100", ipServer="192.168.18.25";
        int puertoControlador = 5000, puertoServer= 9097;
        ControladorAK miControlador = null;
        LPRCamaraHV miCamaraLPR = null;
        bool resultadoControlador = false;
        string mensajeError = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                ipControlador = txtIpControlador.Text;
                puertoControlador = int.Parse(txtPuertoControlador.Text);
                mensajeError = string.Empty;
                if (chkEstado.Checked)
                {
                    resultadoControlador = miControlador.DesconectarControlador(out mensajeError);
                    if (resultadoControlador)
                    {
                        AgregarMensajeControlador("Desconectado");
                        btnConectar.Text = "Conectar";
                        chkEstado.Checked = false;
                    }
                }
                else
                {
                    miControlador = new ControladorAK(ipControlador, puertoControlador);
                    resultadoControlador = miControlador.ConectarControlador(out mensajeError);
                    chkEstado.Checked = resultadoControlador;
                    btnConectar.Text = "Desconectar";
                    AgregarMensajeControlador("Conectado");
                    miControlador.EstadoCambiadoDI += EstadosDI; //SE SUSCRIBE EL EVENTO
                }
                if (mensajeError != string.Empty)
                {
                    lstControladora.Items.Clear();
                    AgregarMensajeControlador(mensajeError);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarMensajeControlador(string texto)
        {
            string mensaje = (DateTime.Now.ToString("HH:mm:ss") + ": " + texto);
            lstControladora.Items.Add(mensaje);
        }

        private void AddItemToListBox(string text)
        {
            if (lstControladora.InvokeRequired)
            {
                lstControladora.Invoke(new Action<string>(AddItemToListBox), text);
            }
            else
            {
                lstControladora.Items.Add(text);
            }
        }

        void EstadosDI(int numero, bool estado)
        {
            try
            {
                string mensaje = (DateTime.Now.ToString("HH:mm:ss") + ": CANAL: " + numero + " - ESTADO: " + estado);
                AddItemToListBox(mensaje); //Como el componente maneja hilos en background y necesito refrescar la interfaz debe hacerse a traves de un delegado
            }
            catch (Exception ex)
            {

            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                miControlador.activaDO(1, chk1.Checked, out mensajeError);
            }
            catch (Exception ex)
            {

            }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                miControlador.activaDO(2, chk2.Checked, out mensajeError);
            }
            catch (Exception ex)
            {

            }
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                miControlador.activaDO(3, chk3.Checked, out mensajeError);
            }
            catch (Exception ex)
            {

            }
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                miControlador.activaDO(4, chk4.Checked, out mensajeError);
            }
            catch (Exception ex)
            {

            }
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                miControlador.activaDO(5, chk5.Checked, out mensajeError);
            }
            catch (Exception ex)
            {

            }
        }

        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                miControlador.activaDO(6, chk6.Checked, out mensajeError);
            }
            catch (Exception ex)
            {

            }
        }

        private void chk7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                miControlador.activaDO(7, chk7.Checked, out mensajeError);
            }
            catch (Exception ex)
            {

            }
        }

        private void chk8_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                miControlador.activaDO(8, chk8.Checked, out mensajeError);
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool estado = miControlador.EstaConectado();
                AgregarMensajeControlador("Estado conexión: " + estado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool res = false;
            miCamaraLPR = new LPRCamaraHV(ipServer, puertoServer);
           res= miCamaraLPR.IniciarServidor(out mensajeError);
            if (res) { 
                
                miCamaraLPR.OnEventoDeteccionRecibido += HttpServer_OnEventoDeteccionRecibido;
            }
        }

        private void HttpServer_OnEventoDeteccionRecibido(object sender, CLEventoDeteccion e)
        {
            try
            {
                Invoke((Action)(() =>
                {
                    lstPlaca.Items.Add("Placa: " + e.LicensePlate);
                    pictureBox1.Image = e.foto;
                }));
            }
            catch (Exception ex)
            {
                ex = ex;
            }

        }
    }
}
