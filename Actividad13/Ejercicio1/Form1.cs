using Ejercicio1.Models;

namespace Ejercicio1
{

    public partial class Form1 : Form
    {
        Lote l = new Lote();
  


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 modal = new Form2();

            if (modal.ShowDialog() == DialogResult.OK)
            {

                double valor = Convert.ToDouble(modal.tbValor.Text);

                l.RegistrarMedida(valor);
            }
        }
    }
}
