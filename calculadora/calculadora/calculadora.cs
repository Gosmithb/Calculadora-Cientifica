using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class calculadora : Form
    {
        Operaciones Op1 = new Operaciones();
        bool operacion = false;
        AcercaDeForm acercaDeForm = new AcercaDeForm();

        public calculadora()
        {
            InitializeComponent();
        }

        private void uno_Btn_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                resultado_Tbx.Clear();
                operacion = false;
            }
            resultado_Tbx.Text = resultado_Tbx.Text + "1";
        }

        private void dos_Btn_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                resultado_Tbx.Clear();
                operacion = false;
            }
            resultado_Tbx.Text = resultado_Tbx.Text + "2";
        }

        private void tres_Btn_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                resultado_Tbx.Clear();
                operacion = false;
            }
            resultado_Tbx.Text = resultado_Tbx.Text + "3";
        }

        private void cuatro_Btn_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                resultado_Tbx.Clear();
                operacion = false;
            }
            resultado_Tbx.Text = resultado_Tbx.Text + "4";
        }

        private void cinco_Btn_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                resultado_Tbx.Clear();
                operacion = false;
            }
            resultado_Tbx.Text = resultado_Tbx.Text + "5";
        }

        private void seis_Btn_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                resultado_Tbx.Clear();
                operacion = false;
            }
            resultado_Tbx.Text = resultado_Tbx.Text + "6";
        }

        private void siete_Btn_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                resultado_Tbx.Clear();
                operacion = false;
            }
            resultado_Tbx.Text = resultado_Tbx.Text + "7";
        }

        private void ocho_Btn_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                resultado_Tbx.Clear();
                operacion = false;
            }
            resultado_Tbx.Text = resultado_Tbx.Text + "8";
        }

        private void nueve_Btn_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                resultado_Tbx.Clear();
                operacion = false;
            }
            resultado_Tbx.Text = resultado_Tbx.Text + "9";
        }

        private void cero_Btn_Click(object sender, EventArgs e)
        {
            if (operacion)
            {
                resultado_Tbx.Clear();
                operacion = false;
            }
            resultado_Tbx.Text = resultado_Tbx.Text + "0";
        }

        private void boton_Click(Object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((b.Text == "+") || (b.Text == "-"))
            {
                Op1.Memoria = Convert.ToSingle(resultado_Tbx.Text);
                if (Op1.Operador != "=")
                {
                    if (!operacion)
                        Op1.Operador = b.Text;
                    Op1.EvaluarOperaciones();
                }
                resultado_Tbx.Text = Op1.Resultado.ToString();
                operacion = true;
                //Guardamos en Op1.Operacion
                Op1.Operador = b.Text;
            }
            else
            {
                switch (b.Text)
                {
                    case "x":
                        Op1.Memoria = Convert.ToSingle(resultado_Tbx.Text);
                        if (Op1.Operador != "=")
                        {
                            if (Op1.Operador == null)
                            {
                                Op1.Resultado = 1;
                                Op1.Operador = b.Text;
                            }
                            Op1.EvaluarOperaciones();
                        }
                        resultado_Tbx.Text = Op1.Resultado.ToString();
                        operacion = true;
                        //Guardamos en Op1.Operacion
                        Op1.Operador = b.Text;
                        break;
                    case "/":
                        Op1.Memoria = Convert.ToSingle(resultado_Tbx.Text);
                        if (Op1.Operador != "=")
                        {
                            if (Op1.Operador == null)
                            {
                                Op1.Resultado = 1;
                                Op1.Operador = b.Text;
                            }
                            Op1.EvaluarOperaciones();
                        }
                        resultado_Tbx.Text = Op1.Resultado.ToString();
                        operacion = true;
                        //Guardamos en Op1.Operacion
                        Op1.Operador = b.Text;
                        break;
                    case "=":
                        Op1.Memoria = Convert.ToSingle(resultado_Tbx.Text);
                        Op1.EvaluarOperaciones();
                        resultado_Tbx.Text = Op1.Resultado.ToString();
                        Op1.Operador = b.Text;
                        break;
                    case ".":
                        if (operacion || (resultado_Tbx.Text.Length == 0))
                        {
                            //En caso de que el boton anterior haya sido de operacion
                            //o que sea el primer digito ingresado:
                            resultado_Tbx.Text = "0";
                            operacion = false;
                        }
                        if (!resultado_Tbx.Text.Contains("."))
                            //Si no contiene resultado_Tbx un punto, ya lo agregará
                            resultado_Tbx.Text += b.Text;
                        break;
                    case "CE":
                        resultado_Tbx.Clear();
                        operacion = false;
                        Op1.Memoria = 0;
                        Op1.Resultado = 0;
                        Op1.Operador = null;
                        break;
                    case "C":
                        resultado_Tbx.Clear();
                        break;
                    case "<-":
                        if (resultado_Tbx.Text.Length >= 1)
                            resultado_Tbx.Text = resultado_Tbx.Text.Remove(resultado_Tbx.Text.Length - 1);
                        break;
                    default:
                        if (operacion)
                        {
                            resultado_Tbx.Clear();
                        }
                        break;
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estándarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(235, 318);
            resultado_Tbx.Location = new Point(21, 39);
            estándarToolStripMenuItem.Enabled = false;
            cientificaToolStripMenuItem.Enabled = true;
            biomedicaToolStripMenuItem.Enabled = true;
            estándarToolStripMenuItem.Checked = true;
            cientificaToolStripMenuItem.Checked = false;
            biomedicaToolStripMenuItem.Checked = false;
            cientifico_Pn.Visible = false;
        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(430, 349);
            resultado_Tbx.Location = new Point(114, 56);
            estándarToolStripMenuItem.Enabled = true;
            cientificaToolStripMenuItem.Enabled = false;
            biomedicaToolStripMenuItem.Enabled = true;
            estándarToolStripMenuItem.Checked = false;
            cientificaToolStripMenuItem.Checked = true;
            biomedicaToolStripMenuItem.Checked = false;
            cientifico_Pn.Visible = true;

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acercaDeForm.Show();
        }
    }
}
