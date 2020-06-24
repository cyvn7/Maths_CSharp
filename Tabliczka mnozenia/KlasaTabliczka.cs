using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace MultiplicationTableNamespace
{
    class MultiplicationTableData
    {
        private Random rnd = new Random();
        public int maximumNumber = 4;
        private int level = 1;
        private int time = 15;
        int[][] tabLevelFirstNumber = new int[4][];
        int[] tabLevelSecondNumber = new int[50];
        int[,] tabWyniki = new int[60, 4];
        string gmail;
        int mistakes = 0;
        string[] wynik = new string[50];
        int times = 0;
        int timesAll = 0;

        public void RandomTab(char mode)
        {
            Console.Write(mode);
            tabLevelFirstNumber[0] = new int[5];
            tabLevelFirstNumber[1] = new int[10];
            tabLevelFirstNumber[2] = new int[15];
            tabLevelFirstNumber[3] = new int[20];
            string liczba;
            //int tmp3 = 0;
            int poziom = 0;
            int maxpoziom = 4;
            int tmp2 = 0;
            int pierwszaLiczba = 2;
            int drugaLiczba = 26;
            for (int i = 0; i <= 19; i++)
            {
                if ((i == 5 && poziom == 0) || (i == 10 && poziom == 1) || (i == 15 && poziom == 2))
                {
                    poziom++;
                    i -= poziom * 5;
                    switch(mode)
                    {
                        case '+':
                        case '-':
                            pierwszaLiczba += 10;
                            drugaLiczba += 25;
                            break;
                        case '*':
                            maxpoziom += 2;
                            break;
                        case ':':
                            maxpoziom += 4;
                            break;

                    }
                }


                switch (mode)
                {
                    case '+':
                        tabLevelFirstNumber[poziom][i] = rnd.Next(pierwszaLiczba, drugaLiczba);
                        tabLevelSecondNumber[tmp2] = rnd.Next(10, 99);
                        break;
                    case '-':
                        tabLevelFirstNumber[poziom][i] = rnd.Next(pierwszaLiczba, drugaLiczba);
                        tabLevelSecondNumber[tmp2] = rnd.Next(1, tabLevelFirstNumber[poziom][i]);
                        break;
                    case '*':
                    case ':':
                        tabLevelFirstNumber[poziom][i] = rnd.Next(2, maxpoziom);
                        tabLevelSecondNumber[tmp2] = rnd.Next(2, 10);
                        break;

                }
                    liczba = tabLevelFirstNumber[poziom][i] + " " + mode + " "  + tabLevelSecondNumber[tmp2];
                
                
                if (i > 0)
                {
                    for(int tmp3 = 0; tmp3 < tmp2; tmp3++)
                    {
                        while (wynik.Contains(liczba))
                        {
                            switch (mode)
                            {
                                case '+':
                                    tabLevelFirstNumber[poziom][i] = rnd.Next(pierwszaLiczba, drugaLiczba);
                                    tabLevelSecondNumber[tmp2] = rnd.Next(10, 99);
                                    break;
                                case '-':
                                    tabLevelFirstNumber[poziom][i] = rnd.Next(pierwszaLiczba, drugaLiczba);
                                    tabLevelSecondNumber[tmp2] = rnd.Next(1, tabLevelFirstNumber[poziom][i]);
                                    break;
                                case '*':
                                case ':':
                                    tabLevelFirstNumber[poziom][i] = rnd.Next(2, maxpoziom);
                                    tabLevelSecondNumber[tmp2] = rnd.Next(2, 9);
                                    break;

                            }
                            liczba = tabLevelFirstNumber[poziom][i] + " " + mode + " " + tabLevelSecondNumber[tmp2];
                        }
                    }
                }
                wynik[tmp2] = liczba;
                tmp2++;
            }

            for (int o = 0; o <= 49; o++)
            {
                Console.WriteLine(wynik[o]);
            }

            //for (int i = 0; i < 50; i++)
            //{
            //    tabLevelSecondNumber[i] = rnd.Next(2, 9);
            //    if (i > 0)
            //    {
            //        while (tabLevelSecondNumber[i] == tabLevelSecondNumber[i - 1])
            //        {
            //            tabLevelSecondNumber[i] = rnd.Next(2, 9);
            //        }

            //    }
            //}

        }

        public void resetTimer(char mode)
        {
            switch (mode)
            {
                default:
                    time = 10 + level * 5;
                    break;
                case '+':
                case '-':
                    time = 30 + level * 10;
                    break;

            }
        }

        public int getFirstNumber()
        {
            return this.tabLevelFirstNumber[level - 1][times];
        }

        public int getLevel()
        {
            return this.level;
        }

        public int getTime()
        {
            return this.time;
        }

        public void goTimer()
        {
            time--;
        }

        public int getSecondNumber()
        {
            return this.tabLevelSecondNumber[timesAll];
        }

        public int[,] getTab()
        {
            return this.tabWyniki;
        }

        public void  Mistakes()
        {
            mistakes++;
        }
        public void levelUp(char mode)
        {
            if (level == 4)
            {

                if(mistakes == 0)
                {
                    MessageBox.Show("Przeszłaś całą grę, i nie zrobiłaś żadnego błędu! Twoja ocena to 6! Zobacz swoje wyniki!", "Gratulacje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(mistakes * 2 <= 12)
                {
                    MessageBox.Show("Przeszłaś całą grę, poszło ci świetnie! Twoja ocena to 5! Zobacz swoje wyniki!", "Gratulacje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (mistakes * 2 <= 27)
                {
                    MessageBox.Show("Przeszłaś całą grę, nieźle ci poszło! Twoja ocena to 4! Zobacz swoje wyniki!", "Gratulacje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (mistakes * 2 <= 44)
                {
                    MessageBox.Show("Przeszłaś całą grę, nie jest tak źle. Twoja ocena to 3. Zobacz swoje wyniki!", "Gratulacje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (mistakes * 2 <= 60)
                {
                    MessageBox.Show("Przeszłaś całą grę, ale musisz jeszcze się pouczyć. Twoja ocena to 2. Zobacz swoje wyniki!", "Gratulacje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Przeszłaś całą grę, ale poszło ci bardzo źle. Twoja ocena to 1. Zobacz swoje wyniki!", "Gratulacje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                for (int i = 0; i <= 49; i++)
                {
                    switch(mode)
                    {
                        default:
                            if (tabWyniki[i, 2] == tabWyniki[i, 3])
                            {
                                gmail = gmail + tabWyniki[i, 0] + " " + mode + " " + tabWyniki[i, 1] + " = " + tabWyniki[i, 3] + " Dobrze :-)" + "<br />";
                            }
                            else
                            {
                                gmail = gmail + tabWyniki[i, 0] + " " + mode + " " + tabWyniki[i, 1] + " = " + tabWyniki[i, 3] + " ŹLE!!! (" + tabWyniki[i, 2] + ") " + "<br />";
                            }
                            break;
                        case ':':
                            if (tabWyniki[i, 2] == tabWyniki[i, 3])
                            {
                                gmail = gmail + tabWyniki[i, 0] + " " + mode + " " + tabWyniki[i, 1] + " = " + tabWyniki[i, 3] + " Dobrze :-)" + "<br />";
                            }
                            else
                            {
                                gmail = gmail + tabWyniki[i, 0] + " " + mode + " " + tabWyniki[i, 1] + " = " + tabWyniki[i, 3] + " ŹLE!!! (" + tabWyniki[i, 2] + ") " + "<br />";
                            }
                            break;

                    }

                }
                System.IO.File.WriteAllText(@"D:\wyniki.htm", gmail);
                System.Diagnostics.Process.Start(@"D:\wyniki.htm");

                //var client = new SmtpClient("smtp.gmail.com", 587)
                //{
                //    Credentials = new NetworkCredential("tabliczka.mnozenia.program@gmail.com", "maciek123"),
                //    EnableSsl = true
                //};
                //client.Send("tabliczka.mnozenia.program@gmail.com", "maciek.przybylski.03@gmail.com", "Wyniki tabliczki mnożenia", getMail());
                //Console.WriteLine("Sent");
                //Console.ReadLine();

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("tabliczka.mnozenia.program@gmail.com");
                mail.To.Add("dev.m.przybylski@gmail.com");
                mail.Subject = "Wyniki tabliczki mnożenia";

                mail.IsBodyHtml = true;
                string htmlBody;

                htmlBody = gmail;

                mail.Body = htmlBody;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("tabliczka.mnozenia.program@gmail.com", "maciek123");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //MessageBox.Show("Email został wysłany");
                Application.Restart();



            }
            else
            {
                times = 0;
                level++;
                time = time + 5;
                maximumNumber = maximumNumber + 2;
                Console.WriteLine("udało się");
                timesAll++;
            }
            
        }

        public void clickUp()
        {
            times++;
            timesAll++;
        }
        
        //class Program
       // {
            //static void Main(string[] args)
            //{
            //    var client = new SmtpClient("smtp.gmail.com", 587)
            //    {
            //        Credentials = new NetworkCredential("tabliczka.mnozenia.program@gmail.com", "maciek123"),
            //        EnableSsl = true
            //    };
            //    client.Send("tabliczka.mnozenia.program@gmail.com", "macio2013@outlook.com", "test", "testbody");
            //    Console.WriteLine("Sent");
            //    Console.ReadLine();
            //}
       // }
    }
    }

    

    