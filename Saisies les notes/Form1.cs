using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Saisies_les_notes
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "TP1")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "TP1";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "TP2")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "TP2";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "TP3")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "TP3";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Note pratique")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Note pratique";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Note finale")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Note finale";
                textBox5.ForeColor = Color.Silver;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"Saisies les notes\Resources\click1.wav\click1.wav");
            soundPlayer.Play();
            float TP1, TP2, TP3, notePratique, noteFinale, totalTP, noteGlobale;

            for (int i = 1; i <= 5; i++)
            {
                TextBox textBox = this.Controls.Find("textBox" + i, true).FirstOrDefault() as TextBox;
                if (textBox != null && !float.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show("Please enter a valid number in TextBox" + i + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
            }

            
            TP1 = float.Parse(textBox1.Text);
            TP2 = float.Parse(textBox2.Text);
            TP3 = float.Parse(textBox3.Text);
            notePratique = float.Parse(textBox4.Text);
            noteFinale = float.Parse(textBox5.Text);

            totalTP = TP1 + TP2 + TP3;
            noteGlobale = (float)(totalTP * 0.4 + notePratique * 0.2 + noteFinale * 0.4);
            string formattedNote = noteGlobale.ToString("00.00");

            label5.Text = totalTP.ToString();
            label3.Text = noteGlobale.ToString();

           
            if (noteGlobale < 50)
            {
                label7.Text = "E";
                label7.ForeColor = Color.Red;
            }
            else if (noteGlobale < 60)
            {
                label7.Text = "D";
                label7.ForeColor = Color.Orange;
            }
            else if (noteGlobale < 70)
            {
                label7.Text = "C";
                label7.ForeColor = Color.Yellow;
            }
            else if (noteGlobale < 80)
            {
                label7.Text = "B";
                label7.ForeColor = Color.Blue;
            }
            else
            {
                label7.Text = "A";
                label7.ForeColor = Color.Green;
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\BruceWayne\Downloads\click1.wav");
            soundPlayer.Play();
            for (int i = 0; i < 10; i++)
            {
                TextBox textBox = this.Controls.Find("textBox" + i, true).FirstOrDefault() as TextBox;
                if (textBox != null)
                {
                    textBox.Text = "";
                    SetWatermark(textBox); // Set watermark text and color
                }
            }
            label7.Text = "";
            label5.Text = "";
            label3.Text = "";
        }

        private void SetWatermark(TextBox textBox)
        {
            if (textBox == textBox1)
            {
                textBox.Text = "TP1";
                textBox.ForeColor = Color.Silver;
            }
            else if (textBox == textBox2)
            {
                textBox.Text = "TP2";
                textBox.ForeColor = Color.Silver;
            }
            else if (textBox == textBox3)
            {
                textBox.Text = "TP3";
                textBox.ForeColor = Color.Silver;
            }
            else if (textBox == textBox4)
            {
                textBox.Text = "Note pratique";
                textBox.ForeColor = Color.Silver;
            }
            else if (textBox == textBox5)
            {
                textBox.Text = "Note finale";
                textBox.ForeColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\BruceWayne\Downloads\click2.wav");
            soundPlayer.Play();
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
