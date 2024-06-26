using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Medias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variáveis responsáveis por receberem as notas calculadas com o peso.
            double Nota1, Nota2, Trabalho;

            //Converte o conteúdo dos componentes TextBox e ComboBox para double e realiza a multiplicação dos mesmos
            Nota1 = Convert.ToDouble(txtBox1.Text) * Convert.ToDouble(comboBox1.Text);
            Nota2 = double.Parse(txtBox2.Text) * double.Parse(comboBox2.Text);
            Trabalho = Convert.ToDouble(txtBox3.Text) * Convert.ToDouble(comboBox3.Text);

            //Soma dos variáveis para que se obtenha a média
            double Media = Nota1 + Nota2 + Trabalho;

            textBox3.Text = Media.ToString();

            //Variáveis responsáveis por receberem as quantidades de aulas e faltas
            double QdeAulas, QdeFaltas;

            //Converte o conteúdo dos componentes TextBox(Qde Aulas e Qde faltas
            QdeAulas = Convert.ToDouble(txtBox2.Text);
            QdeFaltas = Convert.ToDouble(txtBox1.Text);

            //Realiza a conta necessária para se achar a porcentagem de presença do aluno
            double PorcentgemPresenca = 100 - ((QdeFaltas / QdeAulas) * 100);

            //Realiza a conta de aproveitamento do aluno e converte o valor em string para ser exibido no TextBox4
            textBox4.Text = Convert.ToString(((Media * 10) + (PorcentgemPresenca) / 2) + "%");
        }
    }
}
