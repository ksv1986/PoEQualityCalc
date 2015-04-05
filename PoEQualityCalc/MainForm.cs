using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace PoEQualityCalc
{
    public partial class MainForm : Form
    {
        private class Solution
        {
            public int[] indexes;
            public int sum;
            public Solution(int[] stack, int solutionSum)
            {
                indexes = stack;
                sum = solutionSum;
            }
        };

        int[] values = new int[0];
        List<Solution> solutions = new List<Solution>();
        int currentSolution = 0;

        private int len { get { return values.Length;} }
        private int Sum()
        {
            int sum = 0;
            foreach (int v in values)
                sum += v;
            return sum;
        }

        public MainForm()
        {
            InitializeComponent();
            inputBox.Select(0, inputBox.Text.Length);
            Font BoldFont = new Font(costLbl.Font.FontFamily,
                costLbl.Font.Size, 
                costLbl.Font.Style | FontStyle.Bold);
            costLbl.Font = BoldFont;
        }

        private void SubSolution(int sum, int pos, int[] stack, int stackSize)
        {
            if (sum >= 40) {
                int[] s = new int[stackSize];
                Array.Copy(stack, s, stackSize);
                solutions.Add(new Solution(s, sum));
                return;
            }
            if (pos >= len)
                return;
            for (int i = pos; i < len; i++)
            {
                stack[stackSize] = i;
                SubSolution(sum + values[i], i + 1, stack, stackSize + 1);
            }
        }

        private void FindSolutions()
        {
            int sum = Sum();
            sumLbl.Text = sum.ToString();

            currentSolution = 0;
            solutions.Clear();

            if (sum >= 40)
            {

                int[] stack = new int[len];

                SubSolution(0, 0, stack, 0);

                int minSum = 99;
                for (int i = 0; i < solutions.Count; i++)
                {
                    if (minSum > solutions[i].sum)
                    {
                        minSum = solutions[i].sum;
                        currentSolution = i;
                    }
                }
            }
            PresentSolution();
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            e.Handled = true;
            inputBox.Select(0, inputBox.Text.Length);

            if (inputBox.Value < 1 || inputBox.Value > 20)
                return;

            int index = len;
            Array.Resize(ref values, len + 1);
            values[index] = (int)inputBox.Value;
            Array.Sort(values);
            Label nu = new Label();
            nu.AutoSize = false;
            nu.Height = inputBox.Height;
            nu.Width  = inputBox.Width;
            nu.Margin = new Padding(0, 0, 2, 2);
            nu.Location = new Point(0, panel.Controls.Count * (inputBox.Height + 2));
            nu.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(nu);

            for (int i = 0; i < len; i++)
                (panel.Controls[i] as Label).Text = values[i].ToString();

            FindSolutions();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            values = new int[0];
            currentSolution = 0;
            solutions.Clear();
            sumLbl.Text = "";
            PresentSolution();
            inputBox.Focus();
            inputBox.Select(0, inputBox.Text.Length);
        }

        private void PresentSolution()
        {
            foreach (Control c in panel.Controls)
                c.BackColor = panel.BackColor;

            if (currentSolution >= solutions.Count)
            {
                solutionLbl.Text = "0/0";
                costLbl.Text = "";
                return;
            }

            Solution s = solutions[currentSolution];
            solutionLbl.Text = (currentSolution + 1).ToString() + "/" + solutions.Count.ToString();
            costLbl.Text = s.sum.ToString();
            if (s.sum > 45)
                costLbl.ForeColor = Color.Red;
            else if (s.sum > 40)
                costLbl.ForeColor = Color.DarkOrange;
            else
                costLbl.ForeColor = Color.Green;

            for (int i = 0; i < s.indexes.Length; i++)
                (panel.Controls[s.indexes[i]] as Label).BackColor = Color.LightGreen;
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentSolution <= 0)
                return;
            currentSolution--;
            PresentSolution();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentSolution >= solutions.Count - 1)
                return;
            currentSolution++;
            PresentSolution();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            if (currentSolution >= solutions.Count)
                return;
            List<int> list = new List<int>(values);
            Solution s = solutions[currentSolution];
            for (int i = s.indexes.Length - 1; i >= 0; i--)
            {
                list.RemoveAt(s.indexes[i]);
                panel.Controls.RemoveAt(s.indexes[i]);
            }
            values = list.ToArray();
            FindSolutions();
        }
    }
}
