using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace adaugareControaleInGrilaRandColoana
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

       public void drawallbuttons()
       {
        //afisare rand x coloane pentru un grup de controale

            //nr de controale de pe formular
            int ctrlscounter = Controls.Count;
            //controlul curent
            int cc = 0;
            int counter = 0;
            //coloana i , randul j
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //a catelea control adaugat
                    counter++;
                    //adauga controlul nou pe form
                    Controls.Add(new Button());
                    //al catealea control este cel curent
                    ctrlscounter++;
                    cc = ctrlscounter - 1;
                    //adauga setarile pentru controlul curent
                    Controls[cc].Left = j * 60 + 30; //rand
                    Controls[cc].Top = i * 50 + 30; //coloana
                    Controls[cc].Height = 50;
                    Controls[cc].Width = 60;
                    Controls[cc].Visible = true;
                    //textul afisat pe buton
                    Controls[cc].Text = i.ToString() + " : ";
                    Controls[cc].Text += j.ToString() + " : ";
                    //text rand nou
                    Controls[cc].Text += " \r\n ";
                    Controls[cc].Text += cc.ToString() + " : ";
                    Controls[cc].Text += counter.ToString() + " : ";
                    //fontul afisat pe buton
                    Controls[cc].Font = new Font("Arial", 7);

                }
            }
       }

       private void Form1_Shown(object sender, EventArgs e)
       {
           drawallbuttons();
       }
    }
}
