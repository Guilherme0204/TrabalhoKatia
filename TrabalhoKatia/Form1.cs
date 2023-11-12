using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoKatia
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        public Form1()
        {
            InitializeComponent();
            cbxUnidade.Items.AddRange(unidade);
            cbxQuadra.Items.AddRange(quadra);   
            cbxTipo.Items.AddRange(tipo);
            txtValor.Enabled = false;
            txtCPF.Enabled = false; 
        }
        string[] unidade = { "Bragança Paulista", "Atibaia", "Piracaia" };
        string[] quadra = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string[] tipo = { "Master", "Nobre", "Plus" };
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {


        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoQuarto = cbxTipo.SelectedItem.ToString();
            double valor = ValorDiaria(tipoQuarto);
            if (valor > 0)
            {
                txtValor.Text = valor.ToString();   
            }
            
        }
        public double ValorDiaria(string Tipo)
        {
            switch (Tipo)
            {
                case "Master":
                    return 400;
                case "Nobre":
                    return 300;
                case "Plus":
                    return 250.00;
                default:
                    return 0;
            }
        }
        List<CheckOut> ck = new List<CheckOut>();
       // CheckOut checkout = new CheckOut();
        public int Codigo()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
        
        private void btnSalva_Click(object sender, EventArgs e)
        {
            int codigo = Codigo();
            CheckOut checkout = new CheckOut();

            checkout.Unidade = cbxUnidade.SelectedItem.ToString();
            checkout.NumQuarto = txtNumQuarto.Text;
            checkout.Quadra = cbxQuadra.SelectedItem.ToString();
            checkout.Tipo = cbxTipo.SelectedItem.ToString();
            checkout.Dia = Convert.ToInt32(txtDiarias.Text);
            checkout.ValorDiaria = Convert.ToDouble(txtValor.Text);
            checkout.ConsumoFrigobar = Convert.ToDouble(txtFrigo.Text);
            checkout.Atividade = Convert.ToDouble(txtAtv.Text);
            checkout.Restaurante = Convert.ToDouble(txtRestaurante.Text);
            checkout.CPF = codigo.ToString();
            txtCPF.Text = checkout.CPF;
            txtCPF.Enabled = true;
            ck.Add(checkout);
            SalvarTxt salvarTxt = new SalvarTxt();
            salvarTxt.gravar(checkout.Info());
            MessageBox.Show(checkout.Info());
            MessageBox.Show("Informe o código da reserva para buscar informações");
           /* try
            {
                string data = "Server=localhost;Database=checkout;User=root;Password=guilherme123@@";
                Conexao = new MySqlConnection(data);
                string sql = "INSERT INTO info(Unidade) " + "VALUES" + " ('" + cbxUnidade.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < ck.Count; i++)
            {
                
                if (ck[i].CPF.Equals(txtCPF.Text))
                {
                    MessageBox.Show(ck[i].Info());
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            cbxQuadra.Text = "";
            cbxTipo.Text = "";
            cbxUnidade.Text = "";
            txtAtv.Text = "";
            txtDiarias.Text = "";
            txtCPF.Text = "";
            txtFrigo.Text = "";
            txtNumQuarto.Text = "";
            txtRestaurante.Text = "";
        }
    }
}
