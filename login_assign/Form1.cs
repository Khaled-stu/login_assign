using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace login_assign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passs_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Btnlog_Click(object sender, EventArgs e)
        {
            string x = "Khaled";
            string y = "111222333";
            int attempts = 0;
            int maxAttempt = 3;
            bool logedin = false;
            if (!logedin)
            {
                while (attempts <= maxAttempt)
                {

                    if (textBox1.Text == x && textBox2.Text == y)
                    {
                        MessageBox.Show("login succeed");
                        Btnlog.Text = "logout";
                        attempts=0;
                        break;
                    }

                    else if (textBox1.Text != x && textBox2.Text != y)
                    {
                        MessageBox.Show("both username and password wrong");
                        attempts++;
                        return;
                    }
                    else if (textBox1.Text != x && textBox2.Text == y)
                    {
                        MessageBox.Show("username wrong");
                        attempts++;
                        return;
                    }

                    else if (textBox1.Text == x && textBox2.Text != y)
                    {
                        MessageBox.Show("password wrong");
                        attempts++;
                        return;
                    }
                    
                    if (attempts >= maxAttempt)
                    {
                        MessageBox.Show("attempt expired");
                    }
                    
                }
            }
        }
    }
}
                    
                
            
        
    

