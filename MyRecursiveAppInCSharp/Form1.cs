using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecursiveAppInCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            int number = System.Convert.ToInt32(txtInput.Text);
            int retour = factorial(number);
            lblResult.Text = "Resultat : " + retour.ToString();
        }

        private int factorial(int nombre)
        {
            int n = 1;
            if (nombre > 1)
            {
                n = nombre*factorial((nombre-1));

                return n;
            }
            else
            {
                return 1;
            }
        }
    }
}
