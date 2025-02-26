using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_loja
{
    public partial class Form1 : Form
    {
        decimal bicicleta; //Guardando o preço de cada produto
        int e1; //Guardar o valor de estoque de cada produto
        decimal q1; //Guardar o valor da quantidade de cada produto

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void check_produto1_CheckedChanged(object sender, EventArgs e)
        {
            bicicleta = 500; //Guardando o valor do produto
            e1 = 10; //guardando a quantidade  do produto

            if (check_produto1.Checked == true)
            {
                check_produto1.Text = "Bicicleta"; //Alterando Para o Nome do 
            }   pic_carrinho1.Image = Properties.Resources.Bicicleta;//trocar a imagem
        }
        
    }
}
