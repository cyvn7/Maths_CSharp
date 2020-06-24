using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace MultiplicationTableNamespace
{
    public partial class MultiplicationTableForm : Form
    {
        private MultiplicationTableData table;

        int times = 0;

        int seconds = 15;

        int resultForm;

        int allTimes = 0;

        public char mode = '*';

        int equalNum = 0;

        int secondNum = 0;

        int firstNum = 0;

        bool firstTime = true;

        public MultiplicationTableForm()
        {
            InitializeComponent();
            table = new MultiplicationTableData();
            nextButton.Enabled = false;
            aTimer.Stop();
            this.AcceptButton = nextButton;

        }

        public void MultiplicationTableForm_Load(object sender, EventArgs e)
        {
            
            
        }


        public void start_Click(object sender, EventArgs e)
        {
            if (firstTime == true)
            {
                this.table.RandomTab(mode);
                firstTime = false;
            }
            aTimer.Start();
            time.Text = seconds.ToString();
            start.Enabled = false;
            mode_add.Enabled = false;
            mode_divide.Enabled = false;
            mode_minus.Enabled = false;
            mode_multiply.Enabled = false;
            nextButton.Enabled = true;
            setStart();
        }
    
        private void setStart()
        {
            allTimes++;
            this.table.resetTimer(mode);
            level.Text = table.getLevel().ToString();
            time.Text = table.getTime().ToString();
            sum.Select(0, 2);
            switch(mode)
            {
                default:
                    firstNumberText.Text = table.getFirstNumber().ToString();
                    secondNumberText.Text = table.getSecondNumber().ToString();
                    break;
                case ':':
                    equalNum = table.getFirstNumber();
                    secondNum = table.getSecondNumber();
                    firstNum = equalNum * secondNum;
                    firstNumberText.Text = firstNum.ToString();
                    secondNumberText.Text = secondNum.ToString();
                    break;


            }
        }

        public void Repeat()
        {
            checkNumbers();
            this.table.clickUp();
            times++;
            sum.Text = "";
            sum.Value = 0;
            //Console.WriteLine("Kliknięto " + times + " razy");
            setStart();
        }


        private void checkNumbers()
        {
            int firstNumber = this.table.getFirstNumber();
            int secondNumber = this.table.getSecondNumber();
            switch (mode)
            {
                case '*':
                    resultForm = firstNumber * secondNumber;
                    break;
                case '-':
                    resultForm = firstNumber - secondNumber;
                    break;
                case '+':
                    resultForm = firstNumber + secondNumber;
                    break;
                case ':':
                    resultForm = firstNumber;
                    break;
            }
            //Console.WriteLine(resultForm.ToString());
           // Console.WriteLine(sum.Value);
            int[,] tabWyniki = this.table.getTab();

            switch (mode)
            {
                default:

                    tabWyniki[allTimes - 1, 0] = firstNumber;
                    tabWyniki[allTimes - 1, 2] = resultForm;
                    break;
                case ':':
                    tabWyniki[allTimes - 1, 0] = resultForm * secondNumber;
                    tabWyniki[allTimes - 1, 2] = firstNumber
                        ;
                    break;
            }
                    tabWyniki[allTimes - 1, 1] = secondNumber;
                    tabWyniki[allTimes - 1, 3] = (int)sum.Value;
           

            if (resultForm == (int)sum.Value)
            {
                goodOrBad.Text = "Dobrze!";
                goodOrBad.BackColor = Color.Green;
            }
            else
            {
                goodOrBad.Text = "ŹLE!!!";
                goodOrBad.BackColor = Color.Red;
                this.table.Mistakes();
            }
            //Console.WriteLine("allTimes = " + allTimes);
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("allTimes = " + allTimes);
            Next();
            
        }

        public void Next()
        {
            int levelInt = table.getLevel();
            int timesL = levelInt * 5;
            if (times >= timesL - 1)
            {
                checkNumbers();
                aTimer.Stop();
                seconds = seconds + 2;
                start.Enabled = true;
                nextButton.Enabled = false;
                this.table.levelUp(mode);
                times = 0;
                firstNumberText.Text = " ";
                secondNumberText.Text = " ";
            }
            else
            {
                Repeat();
            }
        }

        private void aTimer_Tick(object sender, EventArgs e)
        {

            int timeLeft = this.table.getTime();

            this.table.goTimer();

            //Console.WriteLine("Zostało " + timeLeft + " sekund");

            if (timeLeft > 1)
            {
                timeLeft--;
                time.Text = timeLeft.ToString();
            }
            else
            {
                //Console.WriteLine("Zostało " + timeLeft + " sekund");
                Next();
            }



        }

        private void MultiplicationTableForm_Load_1(object sender, EventArgs e)
        {

        }

        private void mode_multiply_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightSeaGreen;
            symbol_text.Text = "*";
            mode = '*';
        }

        private void mode_divide_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightPink;
            symbol_text.Text = ":";
            mode = ':';
        }

        private void mode_add_Click(object sender, EventArgs e)
        {
            BackColor = Color.MediumSlateBlue;
            symbol_text.Text = "+";
            mode = '+';
        }

        private void mode_minus_Click(object sender, EventArgs e)
        {
            BackColor = Color.Crimson;
            symbol_text.Text = "-";
            mode = '-';
        }
    }
}
