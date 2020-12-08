using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class Form1 : Form
    {
        int count = 1;
        public Form1()
        {
            InitializeComponent();
            
            truebt.Click  += buttonclick_Click;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int[] arr = { 1, 2, 3, 4,5 };
            int j = arr[i];
            
            switch (label3.BackColor.Name)
            {
                
                    case "Red":
                        label3.Text = (arr[0]).ToString();
                        Refresh();
                        logic.Text = "Yellow + && + 1";
                        Refresh();
                        label3.BackColor = Color.Yellow;
                    break;

                    case "Black":
                        label3.Text = (arr[1]).ToString();
                        Refresh();
                        logic.Text = "Blue + || + 2";
                        Refresh();
                        label3.BackColor = Color.Blue;
                    break;

                    case "White":
                         label3.Text = (arr[2]).ToString();
                        Refresh();
                        logic.Text = "Red + && + 1";
                        Refresh();
                        label3.BackColor = Color.Red;
                    break;

                    case "Yellow":
                        label3.Text = (arr[3]).ToString();
                        Refresh();
                        logic.Text = "Purple + || + 5";
                        Refresh();
                        label3.BackColor = Color.Purple;
                    break;

                default:
                    label3.Text = (arr[4]).ToString();
                    Refresh();
                    logic.Text = "Red + || + 3";
                        label3.BackColor = Color.Red;
                        break;
           
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
           

        }
        //fas
        private void buttonclick_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            truebt.Click += buttonclick_Click;
            while (score != null)
            {
                if (true)
                {
                    int val = 0;
                    val++;
                    String s = val.ToString();

                    score.Text = "Score:" + s;
                    Refresh();
                }
            }
        }
        protected void truebt_Click(object sender, EventArgs e)
        {
            
           /* count++;
            if(score != null)
            {
                score.Text = count.ToString();
                Refresh();
            }
           */

        }
        private void Btnclck_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void wha_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
           
        }

        private void logic_Click(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {

        }
    }
}
