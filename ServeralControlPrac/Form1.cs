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

            Label lb1 = new Label();
            lb1.Text = "레이블입니다";
            lb1.Location = new Point(140, 200);
            Controls.Add(lb1);

            CheckBox cb1 = new CheckBox();
            CheckBox cb2 = new CheckBox();
            CheckBox cb3 = new CheckBox();
            Button btn = new Button();

            cb1.Text = "감자";
            cb2.Text = "고구마";
            cb3.Text = "토마토";
            btn.Text = "클릭!";
            btn.Name = "check";

            cb1.Location = new Point(10, 10);
            cb2.Location = new Point(10, 40);
            cb3.Location = new Point(10, 70);
            btn.Location = new Point(10, 100);

            btn.Click += ButtonClick;
            Controls.Add(cb1);
            Controls.Add(cb2);
            Controls.Add(cb3);
            Controls.Add(btn);

            GroupBox gb1 = new GroupBox();
            GroupBox gb2 = new GroupBox();
            gb1.Text = "식물";
            gb2.Text = "물고기";

            RadioButton rb1 = new RadioButton();  
            RadioButton rb2 = new RadioButton();  
            RadioButton rb3 = new RadioButton();
            RadioButton rb4 = new RadioButton();
            RadioButton rb5 = new RadioButton();
            Button btn2 = new Button();
            Button btn3 = new Button();

            rb1.Text = "감자";
            rb2.Text = "고구마";
            rb3.Text = "토마토";
            rb4.Text = "광어";
            rb5.Text = "우럭";

            btn2.Text = "식물 클릭!";
            btn2.Name = "radio1";

            btn3.Text = "물고기 클릭!";
            btn3.Name = "radio2";

            gb1.Size = new Size(120, 140);
            gb2.Size = new Size(120, 140);
            gb1.Location = new Point(140, 10);
            gb2.Location = new Point(260, 10);

            rb1.Location = new Point(10, 30);
            rb2.Location = new Point(10, 60);
            rb3.Location = new Point(10, 90);

            rb4.Location = new Point(10, 30);
            rb5.Location = new Point(10, 60);

            btn2.Location = new Point(140, 160);
            btn2.Click += ButtonClick;
            btn3.Location = new Point(260, 160);
            btn3.Click += ButtonClick;

            gb1.Controls.Add(rb1);
            gb1.Controls.Add(rb2);
            gb1.Controls.Add(rb3);

            gb2.Controls.Add(rb4);
            gb2.Controls.Add(rb5);

            Controls.Add(gb1);
            Controls.Add(gb2);
            Controls.Add(btn2);
            Controls.Add(btn3);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "check":
                    showCheckboxResult();
                    break;
                case "radio1":
                case "radio2":
                    showRadioResult(btn.Name);
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

        private void showRadioResult(string btnName)
        {
            foreach(var item in Controls)
            {

                GroupBox gb = item as GroupBox;
                if(gb != null)
                {
                    if(gb.Text == "식물" && btnName == "radio1")
                    {
                        foreach(var it in gb.Controls)
                        {
                            RadioButton rb = it as RadioButton;
                            if(rb != null && rb.Checked)
                            {
                                MessageBox.Show(rb.Text);
                            }
                        }
                    }
                    else if(gb.Text == "물고기" && btnName == "radio2")
                    {
                        foreach (var it in gb.Controls)
                        {
                            RadioButton rb = it as RadioButton;
                            if (rb != null && rb.Checked)
                            {
                                MessageBox.Show(rb.Text);
                            }
                        }
                    }
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
