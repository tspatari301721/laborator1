using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butoane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("numele else Nicolai \n x este 20 \n d este 1,0471975511966");
        }

        /*
        Butonul doi verifica daca variabila de tip intreg x este egala cu 10
        Daca x<>10 apare prima caseta
        Daca x= 10 apare caseta2
        */
        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            if (x != 10) {MessageBox.Show("x nu este 10"); }
            else {MessageBox.Show("x trebuie sa fie 10"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text!="")button2.Enabled = true;             
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        /*
        Butonul  trei
        Redactati codul pentru butonul trei astfel incit sa apara sau caseta1 sau caseta 2
        */
        int flag = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                MessageBox.Show("X este 3 si numele este Ala");
                flag = 0;
                return;
            }
            if (flag == 0)
            {
                MessageBox.Show("nu conteaza ce apare");
                flag = 1;
                return;
            }
        }

        /*
         Butonul patru
         Pentru butonul 4 sa se utilizeze 2 cicluri. Ciclul While  pentru variabila count.
         Pina cind count <10   count = count + 1; si ciclul for pentru variabila i. Daca i <5   count = count - 1;
         */
        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count<10)
            {
                count++;
            }
            
            for (int i = 0; i < 5; i++)
            {
                count--;
            }
            MessageBox.Show("raspunsul este " + count);
        }
    }
}
