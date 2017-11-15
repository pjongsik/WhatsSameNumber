using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WhatsSameNumber.Controls;

namespace WhatsSameNumber
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitalizationForm();
            
        }

        List<ButtonEx> _buttons = new List<ButtonEx>();

        private void OnClick(object sender, EventArgs e)
        {
            ButtonEx button = sender as ButtonEx;

            if (button.IsOpen == false)
            {
                button.ShowNumber();
                Application.DoEvents();

                CheckSameNuber();
            }
            else
            {
                button.HiddenNumber();
            }
        }

        private int CreateButtonLayout()
        {
            // 버튼 한변길이
            int width = 40;
            if (int.TryParse(txtWidth.Text, out width) == false)
                width = 40;

            // 버튼 사이 간격
            int gap = 10;
            if (int.TryParse(txtGap.Text, out gap) == false)
                gap = 10;

            // 한행의 버튼수
            int length = 4;
            if (int.TryParse(txtLength.Text, out length) == false)
                length = 4;

            // 창 전체크기
            int windowWidth = ((width + gap) * length) + pnlNotice.Width + (gap * length);
            this.Size = new Size(windowWidth, windowWidth);

            int buttonCol = length;
            int buttonRow = length;
            int buttonCount = buttonCol * buttonRow;
            int buttonHeight = width;
            int buttonWidth = width;
            
            int pointX = gap;
            int pointY = gap;

            int index = 0;
            while (index < buttonCount)
            {
                var button = new ButtonEx();
                button.Location = new System.Drawing.Point(pointX, pointY);
                button.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                button.TabIndex = index++;
                button.Visible = true;
                this.Controls.Add(button);
                _buttons.Add(button);

                pointX += buttonWidth + gap;

                if (index % buttonCol == 0)
                {
                    pointY += buttonHeight + gap;
                    pointX = gap;
                }
            }

            return buttonCount;
        }

        private void InitalizationForm()
        {
            CreateButtonLayout();

            //
            WriteNumberOnButton();

            // 시간 레벨
            lbLevel.Text = "1";
           
            //
            _timer.Interval = 10;
            _timer.Tick += timer_Tick;

            // 
            _buttons.ForEach(x => x.Enabled = false);
        }

        private void WriteNumberOnButton()
        {
            NumberStore ns = new NumberStore();
            var resultMessage = ns.CreateNumbers(_buttons.Count);
            if (string.IsNullOrEmpty(resultMessage) == false)
            {
                MessageBox.Show(resultMessage);
                return;
            }

            var numbers = ns.Numbers;

            //_buttons = Utility.GetChildren<ButtonEx>(this);

            int count = 0;
            foreach (var button in _buttons)
            {
                button.Number = numbers[count++];
                
                button.Click -= new System.EventHandler(OnClick);
                button.Click += new System.EventHandler(OnClick);
            }
        }

        System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        int _time = 1000 * 15;
        void timer_Tick(object sender, EventArgs e)
        {
            DisplayTime();
        }

        private void DisplayTime()
        {
            lbTime.Text = (_time / 1000.00).ToString("0#.00");
            _time -= 10;
            if (_time <= 0)
            {
                lbTime.Text = "00.00";
                GameOver();
                MessageBox.Show("Mission Fail");
            }
        }
        
        private void CheckSameNuber()
        {
            var openedButons = _buttons.Where(x => x.IsClosed == false && x.IsOpen == true).ToList();
            if (openedButons.Count == 2)
            {
                Thread.Sleep(200);

                if (openedButons.GroupBy(x => x.Number).Count() == 1)
                    openedButons.ForEach(x => x.IsClosed = true);
                else
                    openedButons.ForEach(x => x.HiddenNumber());
            }

            if (_buttons.Any(x => x.IsOpen == false) == false)
            {
                GameOver();
                MessageBox.Show("Mission Clear~!");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _buttons.ForEach(x =>
            {
                x.Enabled = true;
                x.IsOpen = false;
                x.IsClosed = false;
                x.Text = string.Empty;
            });
            
            WriteNumberOnButton();
            _timer.Start();
            btnStart.Enabled = false;
        }

        private void GameOver()
        {
            _timer.Stop();
            _time = 1000 * 15;
            btnStart.Enabled = true;
        }

        private void btnReCreate_Click(object sender, EventArgs e)
        {
            foreach (var button in _buttons)
                this.Controls.Remove(button);
            _buttons.Clear();

            CreateButtonLayout();
        }
    }
}
