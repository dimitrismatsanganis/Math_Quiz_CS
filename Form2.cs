using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        Class1 calculator = new Class1();
        public Form2()
        {
            InitializeComponent();                                                          //Initialize components.
        }
        private void Form2_Load(object sender, EventArgs e)                                 //Form2_Load void.
        {
            
        }

        private void button18_Click(object sender, EventArgs e)                             //Button "," void.
        {
            textBox1.Text = textBox1.Text + ",";                                            //textBox1 adds the "," character to itself.
            textBox1.ForeColor = Color.Red;                                                 //textBox1 forecolor changes to red color.       
        }

        private void button17_Click(object sender, EventArgs e)                             //Button "0" void.    
        {
            textBox1.Text = textBox1.Text + 0;                                              //textBox1 adds the "0" number to itself.    
            textBox1.ForeColor = Color.Red;                                                 //textBox1 forecolor changes to red color.
        }

        private void button13_Click(object sender, EventArgs e)                             //Button "1" void.               
        {
            textBox1.Text = textBox1.Text + 1;                                              //textBox1 adds the "1" number to itself.    
            textBox1.ForeColor = Color.Red;                                                 //textBox1 forecolor changes to red color.    
        }

        private void button14_Click(object sender, EventArgs e)                             //Button "2" void.
        {
            textBox1.Text = textBox1.Text + 2;                                              //textBox1 adds the "2" number to itself.
            textBox1.ForeColor = Color.Red;                                                 //textBox1 forecolor changes to red color.
        }

        private void button15_Click(object sender, EventArgs e)                             //Button "3" void.               
        {
            textBox1.Text = textBox1.Text + 3;                                              //textBox1 adds the "3" number to itself.    
            textBox1.ForeColor = Color.Red;                                                 //textBox1 forecolor changes to red color.
        }

        private void button9_Click(object sender, EventArgs e)                              //Button "4" void.
        {
            textBox1.Text = textBox1.Text + 4;                                              //textBox1 adds the "4" number to itself.            
            textBox1.ForeColor = Color.Red;                                                 //textBox1 forecolor changes to red color.
        }

        private void button10_Click(object sender, EventArgs e)                             //Button "5" void.        
        {
            textBox1.Text = textBox1.Text + 5;                                              //textBox1 adds the "5" number to itself.
            textBox1.ForeColor = Color.Red;                                                 //textBox1 forecolor changes to red color.            
        }

        private void button11_Click(object sender, EventArgs e)                             //Button "6" void.                
        {
            textBox1.Text = textBox1.Text + 6;                                              //textBox1 adds the "6" number to itself.               
            textBox1.ForeColor = Color.Red;                                                 //textBox1 forecolor changes to red color. 
        }

        private void button5_Click(object sender, EventArgs e)                              //Button "7" void.            
        {
            textBox1.Text = textBox1.Text + 7;                                              //textBox1 adds the "7" number to itself.
            textBox1.ForeColor = Color.Red;                                                 //textBox1 forecolor changes to red color. 
        }

        private void button6_Click(object sender, EventArgs e)                              //Button "8" void.        
        {
            textBox1.Text = textBox1.Text + 8;                                              //textBox1 adds the "8" number to itself.
            textBox1.ForeColor = Color.Red;                                                 //textBox1 forecolor changes to red color.                 
        }

        private void button7_Click(object sender, EventArgs e)                              //Button "9" void.        
        {
            textBox1.Text = textBox1.Text + 9;                                              //textBox1 adds the "9" number to itself.    
            textBox1.ForeColor = Color.Red;                                                 //textBox1 forecolor changes to red color. 
        }

        public void apotelesma()                                                            //apotelesma void.
        {
            switch (calculator.count)                                                       //Switch controller. 
            {
                case 1:                                                                     //First Case.    
                    calculator.answer = calculator.num + double.Parse(textBox1.Text);       //calculator.answer is the sum of calculator.num and textBox1's text.                                                         
                    textBox1.Text = calculator.answer.ToString();                           //textBox1 gets string converted calculator.answer.     
                    break;                                                                  //Break the process.
                case 2:                                                                     //Second Case                
                    calculator.answer = calculator.num - double.Parse(textBox1.Text);       //calculator.answer is the subtraction of calculator.num and textBox1's text.    
                    textBox1.Text = calculator.answer.ToString();                           //textBox1 gets string converted calculator.answer.  
                    break;                                                                  //Break the process.        
                case 3:                                                                     //Third Case.
                    calculator.answer = calculator.num * double.Parse(textBox1.Text);       //calculator.answer is the multiplication of calculator.num and textBox1's text.
                    textBox1.Text = calculator.answer.ToString();                           //textBox1 gets string converted calculator.answer.  
                    break;                                                                  //Break the process.    
                case 4:                                                                     //Forth Case.
                    calculator.answer = calculator.num / double.Parse(textBox1.Text);       //calculator.answer is the division of calculator.num and textBox1's text.
                    textBox1.Text = calculator.answer.ToString();                           //textBox1 gets string converted calculator.answer.  
                    break;                                                                  //Break the process.            

            }
        }

        private void button16_Click(object sender, EventArgs e)                             //Button "+" void. 
        {
            calculator.num = double.Parse(textBox1.Text);                                   //calculator.num gets textBox1's text.
            textBox1.Clear();                                                               //Clears textBox1's text.
            textBox1.Focus();                                                               //textBox1 is now focused.    
            calculator.count = 1;                                                           //calculator.count is set to 1, first case of switch controller.    
            label1.Text = calculator.num.ToString() + " +";                                 //label1's text is the corverted to string calculator.num and the " +" character.    
        }

        private void button12_Click(object sender, EventArgs e)                             //Button "-" void.        
        {
            calculator.num = double.Parse(textBox1.Text);                                   //calculator.num gets textBox1's text.   
            textBox1.Clear();                                                               //Clears textBox1's text.
            textBox1.Focus();                                                               //textBox1 is now focused. 
            calculator.count = 2;                                                           //calculator.count is set to 2, second case of switch controller.
            label1.Text = calculator.num.ToString() + " -";                                 //label1's text is the corverted to string calculator.num and the " -" character.                          
        }

        private void button8_Click(object sender, EventArgs e)                              //Button "*" void.    
        {
            calculator.num = double.Parse(textBox1.Text);                                   //calculator.num gets textBox1's text.   
            textBox1.Clear();                                                               //Clears textBox1's text.
            textBox1.Focus();                                                               //textBox1 is now focused.                 
            calculator.count = 3;                                                           //calculator.count is set to 3, third case of switch controller.
            label1.Text = calculator.num.ToString() + " *";                                 //label1's text is the corverted to string calculator.num and the " *" character.             
        }

        private void button4_Click(object sender, EventArgs e)                              //Button "/" void.    
        {
            calculator.num = double.Parse(textBox1.Text);                                   //calculator.num gets textBox1's text.
            textBox1.Clear();                                                               //Clears textBox1's text.
            textBox1.Focus();                                                               //textBox1 is now focused.         
            calculator.count = 4;                                                           //calculator.count is set to 4, forth case of switch controller.
            label1.Text = calculator.num.ToString() + " /";                                 //label1's text is the corverted to string calculator.num and the " /" character.             
        }

        private void button19_Click(object sender, EventArgs e)                             //Button "=" void.    
        {
            apotelesma();                                                                   //apotelesma void is executed.        
            label1.Text = "";                                                               //label1's text is now empty.    
        }

        private void button3_Click(object sender, EventArgs e)                              //Clear button void.        
        {
            textBox1.Text = "";                                                             //textbox1's text is now empty.  
        }

        private void button2_Click(object sender, EventArgs e)                              //Backspace button void. 
        {
            int length = textBox1.TextLength - 1;                                           //Fnd the lenght after substract 1 from textBox1's text length.
            string text = textBox1.Text;                                                    //String variable text gets textBox1 content.
            textBox1.Clear();                                                               //Clears textBox1's text.
            for (int i =0;i < length; i++)                                                  //A for loop.
            {   
                textBox1.Text = textBox1.Text + text[i];                                    //textbox1's text gets as many characters as the length int value.
            }
        }

        private void button1_Click(object sender, EventArgs e)                              //Exit button void.  
        {
            this.Close();                                                                   //Closes the application.   
        }
    }
}
