using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Class2 player = new Class2();
        int[] num = new int[8];                                                                                                             //An array of 8 int types variables, num. 
        Random rnd = new Random();                                                                                                          //A random type variable, rnd.
        int correct1;                                                                                                                       //An int variable, correct1.
        int correct2;                                                                                                                       //An int variable, correct2.    
        int correct3;                                                                                                                       //An int variable, correct3.            
        int correct4;                                                                                                                       //An int variable, correct4.                    
        bool extratime;                                                                                                                     //A bool variable, extratime.            
        int score;                                                                                                                          //An int variable, score.                    
        int games;                                                                                                                          //An int variable, games.                    
        int success1;                                                                                                                       //An int variable, success1.                                
        int success2;                                                                                                                       //An int variable, success2.                              
        int success3;                                                                                                                       //An int variable, success3.                      
        int success4;                                                                                                                       //An int variable, success4.          
        double final1;                                                                                                                      //A double variable, final1.                                
        double final2;                                                                                                                      //A double variable, final2.
        double final3;                                                                                                                      //A double variable, final3.                
        double final4;                                                                                                                      //A double variable, final4.                                     
        double[] array = new double[4];                                                                                                     //An array of 4 double types variables, array.                                
        string[] names = new string[] {"ADDITION", "SUBSTRACTION", "MULTIPLICATION", "DIVISION" };                                          //An array of 4 specifics string type variables, names.                                     
        public Form1()                                                                                                                  
        {
            InitializeComponent();                                                                                                          //Initialize components.
        }

        private void callonload()                                                                                                           //callonload void.   
        {
            button1.Visible = true;                                                                                                         //button1 is now visible.                    
            FileInfo f1 = new FileInfo("games.txt");                                                                                        //A fileinfo variable f1, for games.txt file.                
            if (f1.Length != 0)                                                                                                             //If f1 is not empty.
            {   
                richTextBox1.Clear();                                                                                                       //Clears the richTextBox1.                 
                richTextBox1.LoadFile("games.txt", RichTextBoxStreamType.PlainText);                                                        //richTextBox1 loads games.txt file.                        
                games = Convert.ToInt32(richTextBox1.Lines[0]);                                                                             //Int variable, games gets the first line of richTextBox1 int converted.                                                 
                success1 = Convert.ToInt32(richTextBox1.Lines[1]);                                                                          //Int variable, success1 gets the second line of richTextBox1 int converted.                                    
                final1 = Convert.ToDouble(richTextBox1.Lines[1])/Convert.ToDouble(richTextBox1.Lines[0]) * 100;                             //Int variable, final1 does the arithmetical calculation of (success1/games)*100.                                                
                success2 = Convert.ToInt32(richTextBox1.Lines[2]);                                                                          //Int variable, success2 gets the third line of richTextBox1 int converted.                                
                final2 = Convert.ToDouble(richTextBox1.Lines[2]) / Convert.ToDouble(richTextBox1.Lines[0]) * 100;                           //Int variable, final2 does the arithmetical calculation of (success2/games)*100.                            
                success3 = Convert.ToInt32(richTextBox1.Lines[3]);                                                                          //Int variable, success3 gets the forth line of richTextBox1 int converted.                
                final3 = Convert.ToDouble(richTextBox1.Lines[3]) / Convert.ToDouble(richTextBox1.Lines[0]) * 100;                           //Int variable, final3 does the arithmetical calculation of (success3/games)*100.                                                
                success4 = Convert.ToInt32(richTextBox1.Lines[4]);                                                                          //Int variable, success4 gets the fifth line of richTextBox1 int converted.                                
                final4 = Convert.ToDouble(richTextBox1.Lines[4]) / Convert.ToDouble(richTextBox1.Lines[0]) * 100;                           //Int variable, final4 does the arithmetical calculation of (success4/games)*100.                                                        
                array[0] = final1;                                                                                                          //First double type variable of the array, array is the final1.            
                array[1] = final2;                                                                                                          //Second double type variable of the array, array is the final2.            
                array[2] = final3;                                                                                                          //Third double type variable of the array, array is the final3.                            
                array[3] = final4;                                                                                                          //Forth double type variable of the array, array is the final4.                                    
            }
            else { games = 0; success1 = 0; success2 = 0; success3 = 0; success4 = 0; }                                                     //Else, file is empty, so games=success1=success2=success3=success4=0.    

            if (final1.ToString().Length > 5)                                                                                               //If double variable final1's length is over 5 characters then: 
            {
                label11.Text = "ADDITION : " + final1.ToString().Substring(0, 5) + "%";                                                     //label11's text shows only the 5 first of them.         
            }
            else                                                                                                                            //Else, double variable final2's length is less than 5 characters then:          
            {
                label11.Text = "ADDITION : " + final1.ToString() + "%";                                                                     //label11's text shows all of them.                 
            }                                                                                                                                               
            if (final2.ToString().Length > 5)                                                                                               //If double variable final2's length is over 5 characters then:     
            {
                label12.Text = "SUBSTRACTION : " + final2.ToString().Substring(0, 5) + "%";                                                 //label12's text shows only the 5 first of them.   
            }
            else                                                                                                                            //Else, double variable final3's length is less than 5 characters then:         
            {
                label12.Text = "SUBSTRACTION : " + final2.ToString() + "%";                                                                 //label12's text shows all of them.                            
            }                                                                                    
            if (final3.ToString().Length > 5)                                                                                               //If double variable final3's length is over 5 characters then:         
            {
                label13.Text = "MULTIPLICATION : " + final3.ToString().Substring(0, 5) + "%";                                               //label13's text shows only the 5 first of them.                                                       
            }
            else                                                                                                                            //Else, double variable final4's length is less than 5 characters then:             
            {
                label13.Text = "MULTIPLICATION : " + final3.ToString() + "%";                                                               //label13's text shows all of them.                                                        
            }                                                                               
            if (final4.ToString().Length > 5)                                                                                               //If double variable final4's length is over 5 characters then:                         
            {
                label14.Text = "DIVISION : " + final4.ToString().Substring(0, 5) + "%";                                                     //label14's text shows only the 5 first of them.                                   
            }
            else                                                                                                                            //Else, double variable final1's length is less than 5 characters then:                                         
            {
                label14.Text = "DIVISION : " + final4.ToString() + "%";                                                                     //label14's text shows all of them.                    
            }  
            
           
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = label6.Visible = false;                    //label1, label2, label3, label4, label5, label6 are not visible.   
            label7.Visible = label8.Visible = label9.Visible = label10.Visible = label16.Visible = label17.Visible = false;                 //label7, label8, label9, label10, label16, label17 are not visible.  
            textBox1.Visible = textBox2.Visible = textBox3.Visible = textBox4.Visible = button2.Visible = false;                            //textBox1, textBox2, textBox3, textBox4, button2 are not visible.
            extratime = false;                                                                                                              //Bool variable extratime is false.
            score = 0;                                                                                                                      //Int variable, score equals to zero.
            player.extra = 1;                                                                                                               //player.extra from Class2 equals to 1.        
            player.time = 90;                                                                                                               //player.time from Class2 equals to 90.          
            button1.Enabled = true;                                                                                                         //button1 is now enabled            
            textBox1.Clear();                                                                                                               //Clears the textBox1.          
            textBox2.Clear();                                                                                                               //Clears the textBox2.                  
            textBox3.Clear();                                                                                                               //Clears the textBox3.                         
            textBox4.Clear();                                                                                                               //Clears the textBox4.                     
            textBox1.BackColor = textBox2.BackColor = textBox3.BackColor = textBox4.BackColor = Color.White;                                //Back color of textBox1, textBox2, textBox3, textBox4 changes to white color.        

        }
        private void Form1_Load(object sender, EventArgs e)                                                                                 //Form1_Load void.   
        {
            callonload();                                                                                                                   //Refreshes when have been called.    
        }

        private void button1_Click(object sender, EventArgs e)                                                                              //Play button void (button1_Click).
        {
            label1.Visible = label3.Visible = label4.Visible = label5.Visible = label6.Visible = label16.Visible = true;                    //label1, label3, label4, label5, label6, label16 are visible.  
            textBox1.Visible = textBox2.Visible = textBox3.Visible = textBox4.Visible = button2.Visible = true;                             //textBox1, textBox2, textBox3, textBox4, button2 are visible.    
            label1.ForeColor = Color.Green;                                                                                                 //Forecolor of label1 changes to green.
            button1.Visible = false;                                                                                                        //button1 is not visible.

            for (int i = 0; i < 8; i++)                                                                                                     //A for loop.
            {
                num[i] = rnd.Next(1, 100);                                                                                                  //For every loop a random number is selected between 1 to 100, this happens 8 times, so we get 8 randomly selected numbers.
            }

            timer1.Start();                                                                                                                 //timer1 starts.
            label1.Text = player.time.ToString() + "sec.";                                                                                  //label1 shows player's "regular" time.        
            label2.Text = player.extra.ToString() + "sec.";                                                                                 //label2 shows player's extra time.
            label3.Text = num[0].ToString() + " + " + num[1].ToString() + " = ";                                                            //label3 shows the arithmetic operation of addition.                 
            label4.Text = num[2].ToString() + " - " + num[3].ToString() + " = ";                                                            //label4 shows the arithmetic operation of subtraction.        
            label5.Text = num[4].ToString() + " * " + num[5].ToString() + " = ";                                                            //label5 shows the arithmetic operation of multiplication.                                
            label6.Text = num[6].ToString() + " / " + num[7].ToString() + " = ";                                                            //label6 shows the arithmetic operation of division.                                    
            correct1 = num[0] + num[1];                                                                                                     //Int variable correct1 is the result of the arithmetic operation of addition.                 
            correct2 = num[2] - num[3];                                                                                                     //Int variable correct2 is the result of the arithmetic operation of subtraction.                            
            correct3 = num[4] * num[5];                                                                                                     //Int variable correct3 is the result of the arithmetic operation of multiplication.                
            correct4 = num[6] / num[7];                                                                                                     //Int variable correct4 is the result of the arithmetic operation of division.            
            label7.Text = correct1.ToString();                                                                                              //label7 shows the result of the arithmetic operation of addition, correct1.    
            label8.Text = correct2.ToString();                                                                                              //label8 shows the result of the arithmetic operation of subtraction, correct2.        
            label9.Text = correct3.ToString();                                                                                              //label9 shows the result of the arithmetic operation of multiplication, correct3.                
            label10.Text = correct4.ToString();                                                                                             //label10 shows the result of the arithmetic operation of division, correct4.                        
        }

        private void timer1_Tick(object sender, EventArgs e)                                                                                //timer1_Tick void.                   
        {
            player.time--;                                                                                                                  //At every click, player.time decreases itself by 1.                                
            label1.Text = player.time.ToString() + "sec.";                                                                                  //label1 shows player's "regular" time.  
            
            if (player.time > 60)                                                                                                           //If player.time is over 60 (seconds), then:                                        
            {
                label1.ForeColor = Color.Green;                                                                                             //label1's forecolor changes to green.                                        
            }
            else if ((player.time <= 60) && (player.time > 30))                                                                             //Else if player.time is under/or 60 (seconds) but over 30 (seconds), then:                                                             
            {
                label1.ForeColor = Color.Orange;                                                                                            //label1's forecolor changes to orange.                                    
            }
            else if (player.time <= 30)                                                                                                     //Else if player.time is under/or 30 (seconds), then:                                     
            {
                label1.ForeColor = Color.Red;                                                                                               //label1's forecolor changes to red.                        
            }

            if (player.time == 0)                                                                                                           //If player.time equals to 0, then:                                         
            {
                extratime = true;                                                                                                           //Bool variable extratime is true (Extra time starts).                                                                        
                timer1.Stop();                                                                                                              //timer1 stops ("Regular" time is over).                            
                label17.Visible = true;                                                                                                     //label17 is visible.                                    
                label2.Visible = true;                                                                                                      //label2 is visible.                                
                timer2.Start();                                                                                                             //timer2 starts (Extra time's timer).                                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)                                                                                //timer2_Tick void.           
        {
            player.extra++;                                                                                                                 //At every click, player.extra increases itself by 1.            
            label2.Text = player.extra.ToString() + "sec.";                                                                                 //label2 shows player's extra time.                
        }

        private void button2_Click(object sender, EventArgs e)                                                                              //Submit button void (button2_Click).             
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")                                   //If textBox1, textBox2, textBox3, textBox4 are not empty, then:                        
            {
                if (Regex.IsMatch(textBox2.Text, @"-*\d+"))                                                                                 //If textBox2 is matched with this regular expression for zero or one (-) and one or more digits,then:
                {
                    timer2.Stop();                                                                                                          //timer2 stops.                     
                    timer1.Stop();                                                                                                          //timer1 stops.                                     
                    label7.Visible = label8.Visible = label9.Visible = label10.Visible = true;                                              //label7, label8, label9, label10 are visible.  

                    if (Convert.ToInt32(textBox1.Text) == correct1)                                                                         //If textbox1, int corverted, text matches correct1, then:                                            
                    {
                        score++;                                                                                                            //Int variable, score increases itself by 1.                     
                        textBox1.BackColor = Color.Green;                                                                                   //Back color of textBox1 changes to green.                      
                        success1++;                                                                                                         //Int variable, success1 increases itself by 1.                       
                    }
                    else                                                                                                                    //Else:                                
                    {
                        textBox1.BackColor = Color.Red;                                                                                     //Back color of textBox1 changes to red.                     
                    }
                    if (Convert.ToInt32(textBox2.Text) == correct2)                                                                         //If textbox2, int corverted, text matches correct2, then:                                      
                    {
                        score++;                                                                                                            //Int variable, score increases itself by 1.                       
                        textBox2.BackColor = Color.Green;                                                                                   //Back color of textBox2 changes to green.                 
                        success2++;                                                                                                         //Int variable, success2 increases itself by 1.                               
                    }
                    else                                                                                                                    //Else:                             
                    {
                        textBox2.BackColor = Color.Red;                                                                                     //Back color of textBox2 changes to red.                             
                    }
                    if (Convert.ToInt32(textBox3.Text) == correct3)                                                                         //If textbox3, int corverted, text matches correct3, then:                          
                    {
                        score++;                                                                                                            //Int variable, score increases itself by 1.                           
                        textBox3.BackColor = Color.Green;                                                                                   //Back color of textBox3 changes to green.                         
                        success3++;                                                                                                         //Int variable, success3 increases itself by 1.                       
                    }
                    else                                                                                                                   //Else:             
                    {
                        textBox3.BackColor = Color.Red;                                                                                    //Back color of textBox3 changes to red.                 
                    }
                    if (Convert.ToInt32(textBox4.Text) == correct4)                                                                         //If textbox4, int corverted, text matches correct4, then:                  
                    {
                        score++;                                                                                                            //Int variable, score increases itself by 1.                               
                        textBox4.BackColor = Color.Green;                                                                                   //Back color of textBox4 changes to green.                             
                        success4++;                                                                                                         //Int variable, success4 increases itself by 1.                                       
                    }
                    else                                                                                                                    //Else:                             
                    {
                        textBox4.BackColor = Color.Red;                                                                                    //Back color of textBox4 changes to red.                     
                    }
                    if (extratime)                                                                                                         //If bool variable, extratime is true, then:                              
                    {
                        player.finaltime = 90 + player.extra;                                                                              //player.finaltime is the sum of "regular" time (90sec.) and extra time.                                                    
                        games++;                                                                                                           //Int variable, games increases itself by 1.                                                                 
                        richTextBox1.Clear();                                                                                              //richTextBox1 clears.             
                        File.Delete("games.txt");                                                                                          //Deletes games.txt file.

                        StreamWriter sw = new StreamWriter("games.txt", true);                                                             //A StreamWriter variable, sw writes on games.txt file (recreate it if does not exist).                                                
                        {
                            sw.Write(games + Environment.NewLine + success1 + Environment.NewLine + success2                               //StreamWriter variable, sw writes on five lines, one for each of the following int variables:        
                                           + Environment.NewLine + success3 + Environment.NewLine + success4);                             //games, success1, success2, success3, success4.                
                        }

                        sw.Close();                                                                                                        //StreamWriter variable, sw closes.            

                        DialogResult dialogresult = MessageBox.Show("YOU SCORED " + score + "/4" + " IN " + player.finaltime.ToString() + "sec." + Environment.NewLine + "WITH EXTRA TIME");
                        //Result message appears.
                        if (dialogresult == DialogResult.OK)                                                                               //If DialogResult is OK, then:                                                                                        
                        {
                            callonload();                                                                                                  //Loads again the form (Refresh).
                        }

                    }
                    else                                                                                                                   //Else (If extratime is not true):         
                    {
                        player.finaltime = 90 - player.time;                                                                               //                                            
                        games++;                                                                                                           //Int variable, games increases itself by 1.          
                        richTextBox1.Clear();                                                                                              //richTextBox1 clears.                     
                        File.Delete("games.txt");                                                                                          //Deletes games.txt file.             

                        StreamWriter sw = new StreamWriter("games.txt", true);                                                             //A StreamWriter variable, sw writes on games.txt file (recreate it if does not exist).                                       
                        {
                            sw.Write(games + Environment.NewLine + success1 + Environment.NewLine + success2                               //StreamWriter variable, sw writes on five lines, one for each of the following int variables:                                     
                                           + Environment.NewLine + success3 + Environment.NewLine + success4);                             //games, success1, success2, success3, success4.                                                        
                        }
                        sw.Close();

                        DialogResult dialogresult = MessageBox.Show("YOU SCORED " + score + "/4" + " IN " + player.finaltime.ToString() + "sec." + Environment.NewLine + "WITHOUT EXTRA TIME");
                        //Result message appears.
                        if (dialogresult == DialogResult.OK)                                                                               //If DialogResult is OK, then: 
                        {
                            callonload();                                                                                                  //Loads again the form (Refresh).                
                        }

                    }
                }
                else
                {
                    textBox2.BackColor = Color.Red;                                                                                        //Back color of textBox2 changes to red.
                    textBox2.ForeColor = Color.White;                                                                                      //Fore color of textBox2 changes to white.
                    DialogResult dialogresult = MessageBox.Show("WRONG FORMAT");                                                           //Result message appears.
                    if(dialogresult == DialogResult.OK)                                                                                    //If DialogResult is OK, then:  
                    {
                        textBox2.Clear();                                                                                                  //textBox2 content is cleared.
                        textBox2.BackColor = Color.White;                                                                                  //Back color of textBox2 changes to white.
                        textBox2.ForeColor = Color.Black;                                                                                  //Fore color of textBox2 changes to black.
                    }
                }
            }
            else                                                                                                                           //Else (If one or more of textbox1, textbox2, textbox3, textbox4 empty):        
            {
                MessageBox.Show("GUESS ALL THE OUTCOMES");                                                                                 //A warning MessageBox appears.                    
            }
        }

        string oldText;                                                                                                                    //A string variable, oldText.                                                                                                                                                               
        private void textBox1_TextChanged(object sender, EventArgs e)                                                                      //textBox1_TextChanged void.                        
        {
            if (textBox1.Text.All(chr => char.IsNumber(chr)))                                                                              //If textbox1's text contains only numbers, then:                 
            {  
                oldText = textBox1.Text;                                                                                                   //String variable, oldText gets textBox1's text.                           
                textBox1.Text = oldText;                                                                                                   //textBox1's text gets oldText content.                            
                textBox1.BackColor = System.Drawing.Color.White;                                                                           //Back color of textBox1 changes to white.                     
                textBox1.ForeColor = System.Drawing.Color.Black;                                                                           //Fore color of textBox1 changes to black.                                                 
            }
            else                                                                                                                           //Else (If contains numbers):            
            {
                textBox1.Text = oldText;                                                                                                   //textBox1's text gets oldText content.        
                textBox1.BackColor = System.Drawing.Color.Red;                                                                             //Back color of textBox1 changes to red.                                                                      
                textBox1.ForeColor = System.Drawing.Color.White;                                                                           //Fore color of textBox1 changes to white.                                 
                MessageBox.Show("USE ONLY NUMBERS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);                                  //Error message appears.                                     
                {
                    textBox1.BackColor = System.Drawing.Color.White;                                                                        //Back color of textBox1 changes to white.                                    
                    textBox1.ForeColor = System.Drawing.Color.Black;                                                                        //Fore color of textBox1 changes to black.                     
                }
                textBox1.SelectionStart = textBox1.Text.Length;                                                                             //textBox1 starting selection.              
            }
        }

        string oldText2;                                                                                                                   //A string variable, oldText2.                                          
        private void textBox3_TextChanged(object sender, EventArgs e)                                                                       //textBox3_TextChanged void.                                           
        {
            if (textBox3.Text.All(chr => char.IsNumber(chr)))                                                                               //If textbox3's text contains only numbers, then:                                
            {
                oldText2 = textBox3.Text;                                                                                                   //String variable, oldText2 gets textBox3's text.                                               
                textBox3.Text = oldText2;                                                                                                   //textBox3's text gets oldText2 content.                                
                textBox3.BackColor = System.Drawing.Color.White;                                                                            //Back color of textBox3 changes to white.                          
                textBox3.ForeColor = System.Drawing.Color.Black;                                                                            //Fore color of textBox3 changes to black.                                         
            }
            else                                                                                                                            //Else (If contains numbers):                     
            {
                textBox3.Text = oldText2;                                                                                                   //textBox3's text gets oldText2 content.                                    
                textBox3.BackColor = System.Drawing.Color.Red;                                                                              //Back color of textBox3 changes to red.                                          
                textBox3.ForeColor = System.Drawing.Color.White;                                                                            //Fore color of textBox3 changes to white.                                      
                MessageBox.Show("USE ONLY NUMBERS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);                                   //Error message appears.                                                         
                {
                    textBox3.BackColor = System.Drawing.Color.White;                                                                        //Back color of textBox3 changes to white.                                            
                    textBox3.ForeColor = System.Drawing.Color.Black;                                                                        //Fore color of textBox3 changes to black.                                                          
                }
                textBox3.SelectionStart = textBox3.Text.Length;                                                                             //textBox3 starting selection.                                    
            }
        }

        string oldText3;                                                                                                                    //A string variable, oldText3.                                      
        private void textBox4_TextChanged(object sender, EventArgs e)                                                                       //textBox4_TextChanged void.                                               
        {
            if (textBox4.Text.All(chr => char.IsNumber(chr)))                                                                               //If textbox4's text contains only numbers, then:                                                
            {
                oldText3 = textBox4.Text;                                                                                                   //String variable, oldText3 gets textBox4's text.                                               
                textBox4.Text = oldText3;                                                                                                   //textBox4's text gets oldText3 content.                                        
                textBox4.BackColor = System.Drawing.Color.White;                                                                            //Back color of textBox4 changes to white.                          
                textBox4.ForeColor = System.Drawing.Color.Black;                                                                            //Fore color of textBox4 changes to black.                                                         
            }
            else                                                                                                                            //Else (If contains numbers):                                     
            {   
                textBox4.Text = oldText3;                                                                                                   //textBox4's text gets string variable, oldText3.     
                textBox4.BackColor = System.Drawing.Color.Red;                                                                              //Back color of textBox4 changes to red.                                                     
                textBox4.ForeColor = System.Drawing.Color.White;                                                                            //Fore color of textBox4 changes to white.                                                     
                MessageBox.Show("USE ONLY NUMBERS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);                                   //Error message appears.                                                                                    
                {
                    textBox4.BackColor = System.Drawing.Color.White;                                                                        //Back color of textBox4 changes to white.                                 
                    textBox4.ForeColor = System.Drawing.Color.Black;                                                                        //Fore color of textBox4 changes to black.                                     
                }
                textBox4.SelectionStart = textBox4.Text.Length;                                                                             //textBox1 starting selection.                                     
            }
        }

        private void button3_Click(object sender, EventArgs e)                                                                              //Calculator button void (button3_Click).                                    
        {
            Form2 Calculator = new Form2();                                                                                                 //Initialize Calculator Form.                                                
            Calculator.ShowDialog();                                                                                                        //Opens the Calculator's Form.                                    

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)                                                               //Exit menu button void.
        {
            Application.Exit();                                                                                                            //Exits from the Application.
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)                                                              //About menu button void.
        {
                MessageBox.Show("This game was made by Panagiotis Apostolopoulos, Dimitris Matsanganis and Pavlos Roumeliotis.");
                //A Messagebox pops up with editors's name.
        }

        private void aDVICEToolStripMenuItem_Click(object sender, EventArgs e)                                                             //Advice menu button void.
        {
            int index1 = 0;                                                                                                                //An int variable, index1 equals to zero, initially.                       
            int index2 = 0;                                                                                                                //An int variable, index2 equals to zero, initially.                               
            double max = array[0];                                                                                                         //A double variable, max equals to first double type variable of the array, array, initially.                            
            double min = array[0];                                                                                                         //A double variable, min equals to first double type variable of the array, array, initially.                            
            for (int i = 1; i < 4; i++)                                                                                                    //A for loop (Max and Min sorts).                    
            {
                if (array[i] > max)                                                                                                        //If i-double variable of the array, array is greater than double variable, max then:             
                {
                    max = array[i];                                                                                                        //Double variable, max equals to i-double variable of the array, array.                     
                    index1 = i;                                                                                                            //Int variable, index1 equals to i.                            
                }
                if (array[i] < min)                                                                                                        //If i-double variable of the array, array is less than double variable, min then:                            
                {
                    min = array[i];                                                                                                        //Double variable, min equals to i-double variable of the array, array.          
                    index2 = i;                                                                                                            //Int variable, index2 equals to i.                              
                }
            }

            MessageBox.Show("YOU ARE GOOD AT " + names[index1].ToString() + " AND YOU NEED TO IMPROVE " + names[index2].ToString());       //Messagebox shows the biggest and the lowest stat (index1 and index2).
        }

        private void cALCULATORToolStripMenuItem_Click(object sender, EventArgs e)                                                        //Calculator menu button void.
        {
            this.button3.PerformClick();                                                                                                  //At every click calls calculator button void (button3_Click).
        }

        private void pLAYToolStripMenuItem_Click(object sender, EventArgs e)                                                              //Play menu button void.
        {
            this.button1.PerformClick();                                                                                                  //At every click calls play button void (button_Click).
        }
    }
}
