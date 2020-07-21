using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeralControlPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckBox cb1 = new CheckBox();
            CheckBox cb2 = new CheckBox();
            CheckBox cb3 = new CheckBox();
            Button btn = new Button();

            cb1.Text = "감자";
            cb2.Text = "고구마";
            cb3.Text = "토마토";
            btn.Text = "클릭!";
            btn.Name = "check";

            cb1.Location = new Point(100, 10);
            cb2.Location = new Point(100, 40);
            cb3.Location = new Point(100, 70);
            btn.Location = new Point(100, 100);

            btn.Click += ButtonClick;
            Controls.Add(cb1);
            Controls.Add(cb2);
            Controls.Add(cb3);
            Controls.Add(btn);

            RadioButton rb1 = new RadioButton();  
            RadioButton rb2 = new RadioButton();  
            RadioButton rb3 = new RadioButton();
            Button btn2 = new Button();

            rb1.Text = "감자";
            rb2.Text = "고구마";
            rb3.Text = "토마토";
            btn2.Text = "클릭!";
            btn2.Name = "radio";

            rb1.Location = new Point(200, 10);
            rb2.Location = new Point(200, 40);
            rb3.Location = new Point(200, 70);
            btn2.Location = new Point(200, 100);
            btn2.Click += ButtonClick;

            Controls.Add(rb1);
            Controls.Add(rb2);
            Controls.Add(rb3);
            Controls.Add(btn2);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "check":
                    showCheckboxResult();
                    break;
                case "radio":
                    showRadioResult();
                    break;
            }

            
        }

        private void showCheckboxResult()
        {
            List<string> list = new List<string>();

            foreach (var item in Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    if (checkBox.Checked)
                    {
                        list.Add(checkBox.Text);
                    }
                }
            }

            MessageBox.Show(string.Join(", ", list));
        }

        private void showRadioResult()
        {
            foreach(var item in Controls)
            {
                RadioButton rb = item as RadioButton;
                if (rb != null && rb.Checked)
                {
                    MessageBox.Show(rb.Text);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.co.kr/");
        }
    }
}
