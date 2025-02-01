using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioEscapes
{
    public partial class Form1 : Form
    {
        // Importar la función keybd_event de la API de Windows
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        // Constantes para las teclas
        private const int KEYEVENTF_KEYDOWN = 0x0000; // Tecla presionada
        private const int KEYEVENTF_KEYUP = 0x0002; // Tecla liberada

        private void SendKeyPress(byte keyCode)
        {
            // Enviar la tecla presionada
            keybd_event(keyCode, 0, KEYEVENTF_KEYDOWN, UIntPtr.Zero);

            // Enviar la tecla liberada
            keybd_event(keyCode, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
        }


        private CancellationTokenSource _cancellationTokenSource;
        private bool _disposed;
        public Form1()
        {
            InitializeComponent();
        }

        private void SliderEsc_ValueChanged(object sender, EventArgs e)
        {
            LblEsc.Text = "Cantidad de Esc: " + SliderEsc.Value;
        }

        private void SliderSeg_Scroll(object sender, EventArgs e)
        {
            LblSeg.Text = "Intervalo de Segundos: " + SliderSeg.Value;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            SliderEsc.Value = Convert.ToInt32(Properties.Settings.Default.escapes);
            SliderSeg.Value = Convert.ToInt32(Properties.Settings.Default.segundos);
           
            LblEsc.Text = "Cantidad de Esc: " + SliderEsc.Value;
            LblSeg.Text = "Intervalo de Segundos: " + SliderSeg.Value;
            LblProgreso.Text = "Inactivo";
        }

        private async void BtnIniciar_Click(object sender, EventArgs e)
        {
            GuardarConfig();

            HabilitacionControles(true);
            CambiosApariencia();

            // Crear un nuevo CancellationTokenSource
            _cancellationTokenSource = new CancellationTokenSource();
            // Obtener el token de cancelación
            var cancellationToken = _cancellationTokenSource.Token;

            try
            {
                // Ejecutar la tarea en segundo plano
                await Task.Run(() => EnviarEscapes(cancellationToken), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                CartelTareaDetenida();

            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HabilitacionControles(false);
                LblProgreso.Text = "Inactivo";
                LblProgreso.ForeColor = ColoresARGB.Red;
                BtnIniciar.BackGroudColor = ColoresARGB.Success;


            }
        }

        private void CambiosApariencia()
        {
            LblProgreso.Text = "Activado";
            LblProgreso.ForeColor = ColoresARGB.Success;

            BtnDetener.BackGroudColor = ColoresARGB.Red;
            BtnIniciar.BackGroudColor = ColoresARGB.Dark;
        }

        private void GuardarConfig()
        {
            Properties.Settings.Default.escapes = SliderEsc.Value;
            Properties.Settings.Default.segundos = SliderSeg.Value;
            Properties.Settings.Default.Save();
        }

        private void EnviarEscapes(CancellationToken cancellationToken)
        {
            _disposed = false;
            try
            {
                int cantidad = Convert.ToInt32(LblEsc.Text.Split(':')[1].Trim());
                for (int i = 0; i < cantidad; i++)
                {
                    /*
                    // Verificar si se ha solicitado la cancelación
                    cancellationToken.ThrowIfCancellationRequested();

                    // Simular trabajo
                    Thread.Sleep(100);

                    // Actualizar la interfaz de usuario (usar Invoke para evitar problemas de hilos)
                    this.Invoke((MethodInvoker)delegate
                    {
                        LblProgreso.Text = $"Progreso: {i}%";
                    });
                    */
                    // Verificar si se ha solicitado la cancelación
                    cancellationToken.ThrowIfCancellationRequested();
                    int segundos = Convert.ToInt32(LblSeg.Text.Split(':')[1].Trim()) * 1000;
                    //int segundos = SliderSeg.Value * 1000;

                    Thread.Sleep(segundos);

                    //SendKeys.Send("{ESC}");
                    // Enviar la tecla "A" (código de tecla virtual para "A" es 0x41)
                    //SendKeyPress(0x41);
                    SendKeyPress(0x1B);
                    VerProgreso(i);

                }


            }
            catch (OperationCanceledException)
            {
                CartelTareaDetenida();
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                MessageBox.Show($"{ex.Message}", "Error en Envio de escapes:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private static void CartelTareaDetenida()
        {
            // La tarea fue cancelada
            MessageBox.Show("El envio de Escapes fue Detenido", "Tarea cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void VerProgreso(int i)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (!_disposed)
                    LblProgreso.Text = $"Esc Nº{i + 1} de {SliderEsc.Value}";
                else
                {
                    LblProgreso.Text = $"Deteniendo";

                }
            });
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            //LblProgreso.Visible = false;
            _disposed = true;

            LblProgreso.Text = "Deteniendo";

            BtnDetener.Enabled = false;
            BtnDetener.BackGroudColor = ColoresARGB.Dark;

            // Solicitar la cancelación de la tarea
            _cancellationTokenSource?.Cancel();

        }



        private void HabilitacionControles(bool habilitacion)
        {
            BtnDetener.Enabled = habilitacion;
            BtnIniciar.Enabled = !habilitacion;
            SliderSeg.Enabled = !habilitacion;
            SliderEsc.Enabled = !habilitacion;
        }
    }
}
