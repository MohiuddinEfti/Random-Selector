using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Selector
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

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
            
        }
        public int a = 0;
        public string r;
        public int line;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] lines = this.richTextBox1.Lines;
            
            if(richTextBox1.Text=="")
            {
                timer1.Enabled = false;
                MessageBox.Show("There is nothing to show");

            }
            else
            {
               textBox1.Text = lines[new Random().Next(lines.Length)];
            }
            

            if (timer1.Enabled == true)
            {
                a++;
                textBox2.Text = a.ToString();
                if (a == 30)
                {
                    timer1.Enabled = false;

                    this.richTextBox1.Clear();
                    
                    for (line = 0; line < lines.Length; line++)
                    {
                        
                        if (!lines[line].Contains(textBox1.Text))
                        {
                            this.richTextBox1.AppendText(lines[line] + Environment.NewLine);
                            
                        }
                        
                    }
                    line = 0;
                    a = 0;
                    
                }
            }

         




        }
    }
}
