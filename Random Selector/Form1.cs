using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            panel1.Visible = false;
            textBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            panel1.Visible = true ;
            button1.BackColor = Color.DarkBlue;

        }
        public int a = 0;
        public int number = 0;
        public string r;
        public int line;
        public int size;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] lines = this.richTextBox1.Lines;
           

            if (richTextBox1.Text=="")
            {
                timer1.Enabled = false;
                MessageBox.Show("There is nothing to show");

            }
            else
            {
               label1.Text = lines[new Random().Next(lines.Length)];
            }
            
            if(WindowState==FormWindowState.Normal)
            {
                size = 27;
            }
            else
            {
                size = 65;
            }

           

            if (timer1.Enabled == true)
            {
                
                a++;
                textBox2.Text = a.ToString();
                panel1.Size = new Size(size * a, 41);
                if (a == 30)
                {
                    number = number + 1;
                    timer1.Enabled = false;
                    if(richTextBox2.Text=="")
                    {
                        richTextBox2.Text = number+". "+label1.Text;
                    }
                    else
                    {
                        richTextBox2.Text = richTextBox2.Text + "\n" + number + ". " + label1.Text;
                    }
                    button1.BackColor = Color.DeepSkyBlue;
                    panel1.Visible = false;
                    a = 0;  
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox2.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_BackColorChanged(object sender, EventArgs e)
        {
            
        }
    }
}
