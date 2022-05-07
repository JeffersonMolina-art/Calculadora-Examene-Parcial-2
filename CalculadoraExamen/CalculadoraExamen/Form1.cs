namespace CalculadoraExamen
{
    public partial class Form1 : Form
    {
        private double numero_1 = 0;
        private double numero_2 = 0;
        private double resultadooperaciones = 0;
        private string operadorutilizado;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numero7_Click(object sender, EventArgs e)
        {
            if (areatrabajo.Text == "0")
            {
                areatrabajo.Text = "";
            }
            String Numero = "7";
            areatrabajo.Text += Numero;
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            if (areatrabajo.Text == "0")
            {
                areatrabajo.Text = "";
            }
            String Numero = "8";
            areatrabajo.Text += Numero;
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            if (areatrabajo.Text == "0")
            {
                areatrabajo.Text = "";
            }
            String Numero = "9";
            areatrabajo.Text += Numero;
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            if (areatrabajo.Text == "0")
            {
                areatrabajo.Text = "";
            }
            String Numero = "/";
            numero_1 = Convert.ToDouble(areatrabajo.Text);
            areatrabajo.Text = "";
            operadorutilizado = Numero;

        }

        private void borrartodo_Click(object sender, EventArgs e)
        {

            areatrabajo.Text = "";
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            if (areatrabajo.Text == "0")
            {
                areatrabajo.Text = "";
            }
            String Numero = "4";
            areatrabajo.Text += Numero;
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            if (areatrabajo.Text == "0")
            {
                areatrabajo.Text = "";
            }
            String Numero = "5";
            areatrabajo.Text += Numero;
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            if (areatrabajo.Text == "0")
            {
                areatrabajo.Text = "";
            }
            String Numero = "6";
            areatrabajo.Text += Numero;
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            
            String Numero = "*";
            numero_1 = Convert.ToDouble(areatrabajo.Text);
            areatrabajo.Text = "";
            operadorutilizado = Numero;
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            if (areatrabajo.Text == "0")
            {
                areatrabajo.Text = "";
            }
            String Numero = "1";
            areatrabajo.Text += Numero;
        }

        private void numero2_Click(object sender, EventArgs e)
        {
            if (areatrabajo.Text == "0")
            {
                areatrabajo.Text = "";
            }
            String Numero = "2";
            areatrabajo.Text += Numero;
        }

        private void numero3_Click(object sender, EventArgs e)
        {
            if (areatrabajo.Text == "0")
            {
                areatrabajo.Text = "";
            }
            String Numero = "3";
            areatrabajo.Text += Numero;
        }

        private void restar_Click(object sender, EventArgs e)
        {
            
            String Numero = "-";
            numero_1 = Convert.ToDouble(areatrabajo.Text);
            areatrabajo.Text = "";
            operadorutilizado = Numero;
        }

        private void numero0_Click(object sender, EventArgs e)
        {
            if (areatrabajo.Text == "0")
            {
                areatrabajo.Text = "";
            }
            String Numero = "0";
            areatrabajo.Text += Numero;
        }

        private void punto_Click(object sender, EventArgs e)
        {
            String Numero = ".";
            areatrabajo.Text += Numero;
        }

        private void suma_Click(object sender, EventArgs e)
        {
            
            String Numero = "+";
            numero_1 = Convert.ToDouble(areatrabajo.Text);
            areatrabajo.Text = "";
            operadorutilizado = Numero;
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            areatrabajo.Text = "0";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            numero_2 = Convert.ToDouble(areatrabajo.Text);
            if (operadorutilizado == "/")
            {
                if(numero_2 == 0.0)
                {
                    String mensaje = "Ingrese el segundo valor diferente de 0";
                    MessageBox.Show(mensaje);
                }
                resultadooperaciones = numero_1 / numero_2;
                areatrabajo.Text = resultadooperaciones.ToString();
                numero_1 = 0;
                numero_2 = 0;
                resultadooperaciones = 0;
                operadorutilizado = "";
            }
            if (operadorutilizado == "+")
            {
                resultadooperaciones = numero_1 + numero_2;
                areatrabajo.Text = resultadooperaciones.ToString();
                numero_1 = 0;
                numero_2 = 0;
                resultadooperaciones = 0;
                operadorutilizado = "";
            }
            if (operadorutilizado == "-")
            {
               
                if (numero_1 == 0)
                {
                    string correcion_rest = numero_2 + "-";
                    areatrabajo.Text = correcion_rest;
                }
                if (numero_1 != 0)
                {
                    resultadooperaciones = numero_1 - numero_2;
                    areatrabajo.Text = resultadooperaciones.ToString();
                }
                
                numero_1 = 0;
                numero_2 = 0;
                resultadooperaciones = 0;
                operadorutilizado = "";
            }
            if (operadorutilizado == "*")
            {
                resultadooperaciones = numero_1 * numero_2;
                areatrabajo.Text = resultadooperaciones.ToString();
                numero_1 = 0;
                numero_2 = 0;
                resultadooperaciones = 0;
                operadorutilizado = "";
            }
        }

        private void areatrabajo_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}