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
        string _filepath_prob;
        string _filepath_soln;

        int[] _includedChapters;

        List<Point> _input;

        List<Point> _random;

        int _total;

        int _completed;
        

        public Form1()
        {
            InitializeComponent();
            HwSelectPanel.Visible = true;
            HWViewPanel.Visible = false;

            HWSelectRangeRB.Checked = true;
            HWSelectLoadButton.Enabled = false;

            comboBox1.Text = "1";
            comboBox2.Text = "9";

            _filepath_prob = Environment.CurrentDirectory + "\\Assets\\Problems\\";
            _filepath_soln = Environment.CurrentDirectory + "\\Assets\\Solutions\\";

            _input = new List<Point>();

            _random = new List<Point>();

            _total = 0;
            _completed = 0;

            
        }

        public void inputBuilder()
        {
            Point temp;
            int p;
            foreach(int i in _includedChapters)
            {
                switch (i)
                {
                    default:
                    case 1:
                        p = 2;
                        break;
                    case 2:
                        p = 3;
                        break;
                    case 3:
                        p = 11;
                        break;
                    case 4:
                        p = 2;
                        break;
                    case 5:
                        p = 7;
                        break;
                    case 6:
                        p = 3;
                        break;
                    case 7:
                        p = 1;
                        break;
                    case 8:
                        p = 6;
                        break;
                    case 9:
                        p = 3;
                        break;
                }

                for(int j = 1; j <= p; ++j)
                {
                    temp = new Point(i,j);
                    _input.Add(temp);
                }
            }
        }

        public void inputRandomizer()
        {
            Random rnd = new Random();
            int i;
            _total = 0;

            while(_input.Count() != 0)
            {
                i = rnd.Next(_input.Count());
                _random.Add(_input.ElementAt(i));
                _input.RemoveAt(i);

                ++_total;
            }
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

        private void questionBuilder()
        {
            if (HWIncludeListRB.Checked)
            {
                string[] inStrs = HWSelectInput.Text.Split(',');
                _includedChapters = new int[inStrs.Count()];
                for (int i = 0; i < inStrs.Count(); ++i)
                {
                    _includedChapters[i] = Int32.Parse(inStrs[i]);
                }
            }
            else
            {
                int a = Int32.Parse(comboBox1.Text);
                int b = Int32.Parse(comboBox2.Text);

                a = Math.Min(a, b);
                b = Math.Max(a, b);

                _includedChapters = new int[(b - a) + 1];
                int index = 0;

                for (int i = a; i <= b; ++i)
                {
                    _includedChapters[index] = i;
                    ++index;
                }
            }

            inputBuilder();
            inputRandomizer();
        }

        private void HWSelectNEWButton_Click(object sender, EventArgs e)
        {
            questionBuilder();
            Point current = _random.ElementAt(0);

            _completed = 0;

            HwSelectPanel.Visible = false;
            HWViewPanel.Visible = true;

            HWViewTitle.Text = "HW#" + current.X.ToString() + " Q#" + current.Y.ToString();
            QPanelView.BackgroundImage = Image.FromFile(_filepath_prob + current.X.ToString() + "_" + current.Y.ToString() + ".png");

            HWViewProgress.Text = _completed.ToString() + " / " + _total.ToString();
        }

        private void gotoMenu_Click(object sender, EventArgs e)
        {
            HWViewPanel.Visible = false;
            HwSelectPanel.Visible = true;

            HWSelectLoadButton.Enabled = true;
        }

        private void SKIP_Click(object sender, EventArgs e)
        {
            _random.Add(_random.ElementAt(0));
            _random.RemoveAt(0);

            Point current = _random.ElementAt(0);
            HWViewTitle.Text = "HW#" + current.X.ToString() + " Q#" + current.Y.ToString();
            QPanelView.BackgroundImage = Image.FromFile(_filepath_prob + current.X.ToString() + "_" + current.Y.ToString() + ".png");
            DoneMarker.Enabled = true;
        }

        private void ShowAnswer_Click(object sender, EventArgs e)
        {
            Point current = _random.ElementAt(0);
            HWViewTitle.Text = "HW#" + current.X.ToString() + " Q#" + current.Y.ToString() + " - Answer";
            QPanelView.BackgroundImage = Image.FromFile(_filepath_soln + current.X.ToString() + "_" + current.Y.ToString() + ".png");
            DoneMarker.Enabled = false;
        }

        private void DoneMarker_Click(object sender, EventArgs e)
        {
            _random.RemoveAt(0);

            ++_completed;

            HWViewProgress.Text = _completed.ToString() + " / " + _total.ToString();

            if (_random.Count() != 0)
            {
                Point current = _random.ElementAt(0);
                HWViewTitle.Text = "HW#" + current.X.ToString() + " Q#" + current.Y.ToString();
                QPanelView.BackgroundImage = Image.FromFile(_filepath_prob + current.X.ToString() + "_" + current.Y.ToString() + ".png");
            }
            else
            {
                MessageBox.Show("Selection Exhausted!");

                HWViewPanel.Visible = false;
                HwSelectPanel.Visible = true;

                HWSelectLoadButton.Enabled = false;
            }

        }
    }
}
