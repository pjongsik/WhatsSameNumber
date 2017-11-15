using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhatsSameNumber.Controls
{
    class ButtonEx : Button
    {
        public int Number
        {
            get;
            set;
        }

        public bool IsOpen
        {
            get;
            set;
        }

        bool _isClosed = false;
        public bool IsClosed
        {
            get
            {
                return _isClosed;
            }
            set
            {
                if (value)
                {
                    this.Enabled = false;
                }

                _isClosed = value;
            }
        }

        public void ShowNumber()
        {
            Text = Number.ToString();
            IsOpen = true;
        }

        public void HiddenNumber()
        {
            Text = string.Empty;
            IsOpen = false;
        }
    }
}
