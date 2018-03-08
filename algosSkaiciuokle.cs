using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algosSkaiciavimoPrograma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sukuriami kintamieji algai i rankas skaiciuoti kartu ir procentu kintamieji:

        int antPop, visoMokesciu, darbdMokes, iRankas,
            pajamMokes, sodrosMokesc, autorinSum,
            minus10proc, minus19proc, minus22proc;

        private void button1_Click(object sender, EventArgs e)
        {
            //Paprastos formules skaiciuoti mokesciams:

            if (textBoxtab1.Text != null)
            {
                antPop = int.Parse(algaAntPop.Text);
            }

            if (antPop > 0)
            {
                visoMokesciu = antPop * 24 / 100;
            }

            taxdeductbox.Text = visoMokesciu.ToString();

            darbdMokes = antPop * 31 / 100;
            darbdMokesc.Text = darbdMokes.ToString();

            pajamMokes = antPop * 15 / 100;
            pajamuMokest.Text = pajamMokes.ToString();

            sodrosMokesc = antPop * 9 / 100;
            sodrosMokes.Text = sodrosMokesc.ToString();

            // formule autorinems pajamoms skaiciuoti 1 tabe , vyksta pridejimas procentu

            if (checkBoxPasirkt1.Checked == false)
            {
                autorinSum = 0;
            }
            else
                autorinSum = int.Parse(textBoxtab1.Text);

            minus10proc = autorinSum - (autorinSum * 10 / 100);
            minus19proc = autorinSum - (autorinSum * 19 / 100);
            minus22proc = autorinSum - (autorinSum * 22 / 100);

              if (checkBox10proc1.Checked == true)
                {
                    autorinSum = minus10proc;
                }
                else if (checkBox19proc1.Checked == true)
                {
                    autorinSum = minus19proc;
                }
                else if (checkBox22proc1.Checked == true)
                {
                    autorinSum = minus22proc;
                }
            
            iRankas = antPop - visoMokesciu + autorinSum;
            algaiRankas.Text = iRankas.ToString();
            txtboxAlgAntPop1.Text = antPop1.ToString();
        } 

        // Sukuriami kintamieji algai ant popieriaus skaiciuoti kartu ir procentu kintamieji:

        int ivestAlgiRankas1, visoMokesciu1, darbdMokes1,
            pajamMokes1, sodrosMokesc1, antPop1,
            autorinSum1, plius10proc1, plius19proc1, plius22proc1;

        private void button6_Click(object sender, EventArgs e)
        {
            //  formules skaicuoti algai ant popieriaus

            ivestAlgiRankas1 = int.Parse(txtboxAlgiRank1.Text);
            if (ivestAlgiRankas1 > 0)
            {
                visoMokesciu1 = ivestAlgiRankas1 * 24 / 100;
            }
            txtboxvisoMokesc1.Text = visoMokesciu1.ToString();

            pajamMokes1 = ivestAlgiRankas1 * 15 / 100;
            txtboxPajammokes1.Text = pajamMokes1.ToString();

            sodrosMokesc1 = ivestAlgiRankas1 * 9 / 100;
            txtBoxSodramok1.Text = sodrosMokesc1.ToString();

            darbdMokes1 = ivestAlgiRankas1 * 31 / 100;
            txtboxdarbdavMokesc1.Text = darbdMokes1.ToString();

            // formule skaiciuojanti procentus autoriniu sutarciu pajamoms
            if (checkBox2.Checked == false)
            {
                autorinSum1 = 0;
            }
            else
                autorinSum1 = int.Parse(textBox2.Text);

            plius10proc1 = autorinSum1 * 10 / 100 + autorinSum1;
            plius19proc1 = autorinSum1 * 19 / 100 + autorinSum1;
            plius22proc1 = autorinSum1 * 22 / 100 + autorinSum1;

            if (checkBox10proc.Checked == true)
            {
                autorinSum1 = plius19proc1;
            }
            else if (checkBox19proc.Checked == true)
            {
                autorinSum1 = plius19proc1;
            }
            else if (checkBox22proc.Checked == true)
            {
                autorinSum1 = plius22proc1;
            }
           
            antPop1 = ivestAlgiRankas1 + visoMokesciu1 +autorinSum1;
            txtboxAlgAntPop1.Text = antPop1.ToString();  
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //paspaudus pajamas uz sutartis enables procentu langus 2 tabe

            textBox2.Visible = checkBox2.Checked;
            label2kokes2.Visible = checkBox2.Checked;
            checkBox10proc.Visible = checkBox2.Checked;
            checkBox19proc.Visible = checkBox2.Checked;
            checkBox22proc.Visible = checkBox2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //padarius trinti palieka tuscius langus pirmam tab:

            empName.Text = "";
            algaAntPop.Text = "";
            taxdeductbox.Text = "";
            algaiRankas.Text = "";
            darbdMokesc.Text = "";
            sodrosMokes.Text = "";
            pajamuMokest.Text = "";
            textBoxtab1.Text = "";
            checkBox10proc1.Checked = false;
            checkBox19proc1.Checked = false;
            checkBox22proc1.Checked = false;
            checkBoxPasirkt1.Checked = false;


        }

        private void button5_Click(object sender, EventArgs e)

        {
            //padarius trinti palieka tuscius langus antram tab:

            txtboxAlgAntPop1.Text = "";
            txtboxdarbdavMokesc1.Text = "";
            txtboxAlgiRank1.Text = "";
            txtBoxSodramok1.Text = "";
            txtboxvisoMokesc1.Text = "";
            txtBoxVardas1.Text = "";
            txtboxPajammokes1.Text = "";
            textBox2.Text = "";
            checkBox10proc.Checked = false;
            checkBox19proc.Checked = false;
            checkBox22proc.Checked = false;
            checkBoxPasirkt1.Checked = false;
            checkBox2.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)

        {
            //paspaudus pajamas uz sutartis enables procentu langus

            textBoxtab1.Visible = checkBoxPasirkt1.Checked;
            Label1mokes.Visible = checkBoxPasirkt1.Checked;
            checkBox10proc1.Visible = checkBoxPasirkt1.Checked;
            checkBox19proc1.Visible = checkBoxPasirkt1.Checked;
            checkBox22proc1.Visible = checkBoxPasirkt1.Checked;
        }

        private void button4_Click(object sender, EventArgs e)

        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)

        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e) { }

        private void checkBox10proc1_CheckedChanged(object sender, EventArgs e) { }
    }
}
