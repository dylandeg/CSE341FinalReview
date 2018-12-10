using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE341_final_review
{
    public partial class Form1 : Form
    {
        string _HWnum;
        string _Qnum;

        int[] _Qs;

        public Form1()
        {
            InitializeComponent();
            HwSelectPanel.Visible = true;
            HWViewPanel.Visible = false;

            HWSelectRangeRB.Checked = true;

            comboBox1.Text = "1";
            comboBox2.Text = "9";
        }

        private void HWIncludeListRB_CheckedChanged(object sender, EventArgs e)
        {
            if (HWIncludeListRB.Checked)
            {
                HWSelectRangeRB.Checked = false;
            }
        }

        private void HWSelectRangeRB_CheckedChanged(object sender, EventArgs e)
        {
            if (HWSelectRangeRB.Checked)
            {
                HWIncludeListRB.Checked = false;
            }
        }

        private void HWSelectLoadButton_Click(object sender, EventArgs e)
        {
            HwSelectPanel.Visible = false;
            HWViewPanel.Visible = true;
        }

        private void HWSelectNEWButton_Click(object sender, EventArgs e)
        {
            HwSelectPanel.Visible = false;
            HWViewPanel.Visible = true;

            if (HWIncludeListRB.Checked)
            {
                
                string[] inStrs = HWSelectInput.Text.Split(',');
                int ech;
                for(int i = 0; i < inStrs.Count(); ++i)
                {
                    ech = Int32.Parse(inStrs[i]);
                    inStrs[i] = ech.ToString();

                }
                Random rnd = new Random();
                _HWnum = inStrs[rnd.Next(0,inStrs.Count())];
            }
            else
            {
                int a = Int32.Parse(comboBox1.Text);
                int b = Int32.Parse(comboBox2.Text);

                a = Math.Min(a, b);
                b = Math.Max(a, b);

                Random rnd = new Random();
                _HWnum = rnd.Next(a, b + 1).ToString();
                
            }
            switch (_HWnum)
            {
                case "1":
                    _Qs = new int[]{1};
                    break;
                case "2":
                    _Qs = new int[] { 1 };
                    break;
                case "3":
                    _Qs = new int[] { 1 };
                    break;
                case "4":
                    _Qs = new int[] { 1 };
                    break;
                case "5":
                    _Qs = new int[] { 1 };
                    break;
                case "6":
                    _Qs = new int[] { 1 };
                    break;
                case "7":
                    _Qs = new int[] { 1 };
                    break;
                case "8":
                    _Qs = new int[] { 1 };
                    break;
                case "9":
                    _Qs = new int[] { 1 };
                    break;
            }
            Random rndQ = new Random();
            _Qnum = _Qs[rndQ.Next(0, _Qs.Count())].ToString();

            HWViewTitle.Text = "HW#" + _HWnum +" Q#" + _Qnum;
        }

        private void gotoMenu_Click(object sender, EventArgs e)
        {
            HWViewPanel.Visible = false;
            HwSelectPanel.Visible = true;
        }
    }
}
