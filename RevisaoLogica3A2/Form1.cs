using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoLogica3A2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if ((txtIdade.Text.Trim().ToString() == "") || (txtPeso.Text.Trim().ToString() == ""))
            {
                MessageBox.Show("Informe o Peso e a Idade");
                txtIdade.Focus();
                txtPeso.Focus();
            }
            else
            {
                // Converter para valores
                int idade = Int32.Parse(txtIdade.Text);
                int peso = Int32.Parse(txtPeso.Text);
                // Verifica valores negativos
                if ((idade < 0 ) || (peso < 0)){
                    MessageBox.Show("Peso e Idade não podem ser menor que Zero");
                    txtIdade.Focus();
                    txtPeso.Focus();
                }
                else
                {
                    if ((idade >= 20) && ((peso >= 50) && (peso <= 80))){
                        MessageBox.Show("Peso Ideal");

                    } else if ((idade < 20) && ((peso >= 50) && (peso <= 90))){
                        MessageBox.Show("Acima do Peso");

                    }else
                    {
                        MessageBox.Show("Peso Inválido");
                    }
                }
            }
        }
    }
}
