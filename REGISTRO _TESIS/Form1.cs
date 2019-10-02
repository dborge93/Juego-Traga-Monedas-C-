using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace REGISTRO__TESIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 1;
        public double suma (int i)
        {
            double valor;
            valor = i + 5;
            return valor;

        }
        public void proceso()
        {
            if ((textBox1.Text == textBox2.Text) && (textBox1.Text == textBox3.Text) && (textBox2.Text == textBox3.Text))
            {
                //  if (textBox4.Text == textBox3.Text)

                //    {
                MessageBox.Show("Usted a ganado C$ 1.00 cordoba");
                textBox4.Text = (int.Parse(textBox4.Text) + int.Parse(textBox5.Text)).ToString();
                textBox6.Text = (double.Parse(textBox6.Text) - double.Parse(textBox5.Text)).ToString();

                //   }
            }

            else
            {
                textBox4.Text = (int.Parse(textBox4.Text) - int.Parse(textBox5.Text)).ToString();
                textBox6.Text = (double.Parse(textBox6.Text) + double.Parse(textBox5.Text)).ToString();
            }
        }

private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "0")


            {
                MessageBox.Show(" Desea agregar mas dinero ");
                textBox4.Focus();

            }

            else

            {

                if (double.Parse(textBox4.Text) >= double.Parse(textBox5.Text))
                {

                    Random J = new Random();
                    textBox1.Text = J.Next(1, 10).ToString();
                    textBox2.Text = J.Next(1, 8).ToString();
                    textBox3.Text = J.Next(1, 8).ToString();
                    numeros.Text = n++.ToString();
                    if ((double.Parse(textBox5.Text) <= 10))
                    {
                        proceso();
                        button1.Enabled = false;
                        numeros.Text = "0";
                        textBox5.Text = "0";
                        n = 1;
                        MessageBox.Show(" A finalizado a puesta  apostar nuevamente !!!");
                    }

                    else
                    {

                        if ((double.Parse(textBox5.Text) > 10))

                        {
                            if (double.Parse(numeros.Text) < 3)
                            {


                                proceso();

                            }

                            else

                            {

                                button1.Enabled = false;
                                numeros.Text = "0";
                                textBox5.Text = "0";
                                n = 1;
                                MessageBox.Show(" A finalizado la puesta  apostar nuevamente !!!");
                            }
                        }
                    }

                }

                else
                {
                    MessageBox.Show("INCORRECTO ");
                    textBox5.Focus();
                }
                textBox5.Focus();
            }
        }
           

        private void tabPage3_Click(object sender, EventArgs e)
        {
        
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="FICHAS")
            {
                maskedTextBox1.Visible= false ;

            }
            else
            {

            MessageBox.Show("DIGITE LOS NUMEROS DE LA  NO.  " +  comboBox1.Text);
            maskedTextBox1.Visible = true;
            maskedTextBox1.Focus();

        }
            if (comboBox1.Text== "")
            {

                button1.Enabled = false;
            }
            else 
            {
                button1.Enabled = true;
            }
                   

                }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("DESEA GUARDAR EL REGISTRO", "AVISO", MessageBoxButtons.YesNo);
                if (op== DialogResult.Yes)
                {

                
            SqlConnection con = new SqlConnection(@"Data Source=SALITA07\SQLSERVER2014;Initial Catalog=CASINO;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTE(ID,NOMBRE,APELLIDO,CORREO,TEL) VALUES('" + textBox8.Text + "','" + textBox9.Text + "','"+ textBox10.Text +"','" + textBox11.Text +"','" + textBox7.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
                    textBox8.Clear();
              textBox9.Clear();
              textBox10.Clear();
                  textBox11.Clear();
                  textBox7.Clear();
                  MessageBox.Show("REGISTRO GUARDADO  !..");
                }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void numeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try {
                if (double.Parse(textBox5.Text) > 0)
                {
                    button1.Enabled = true;

                }
                if (textBox5.Text == "")
                {
                    textBox5.Focus();
                }

            }

          catch (Exception ex)

            {

              MessageBox.Show("Digite un valor en el texto");

            }

           }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           /* double valor;
            valor = suma(int.Parse(textBox6.Text));
            textBox6.Text = valor.ToString(); */
        }
    }
        
       }
    

