using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace PoEQualityCalc
{
    public partial class MainForm : Form
    {
        private class Solution : IComparable<Solution>
        {
            public int[] quantity;
            public int sum;
            public Solution(int[] stack, int sum)
            {
                quantity = new int[stack.Length];
                Array.Copy(stack, quantity, stack.Length);
                this.sum = sum;
            }

            public int CompareTo(Solution other)
            {
                return sum.CompareTo(other.sum);
            }
        };

        // We have quantity[X-1] items of quality X
        int[] quantity = new int[20];
        int sum = 0;
        List<Solution> solutions = new List<Solution>();
        int currentSolution = 0;

        public MainForm()
        {
            InitializeComponent();
            inputBox.Select(0, inputBox.Text.Length);
            Font BoldFont = new Font(costLbl.Font.FontFamily,
                costLbl.Font.Size, 
                costLbl.Font.Style | FontStyle.Bold);
            costLbl.Font = BoldFont;
        }

        private void print(int x, int s, int[] stack)
        {
            Console.Write(x + ": (" + s + ")");
            for (int i = 0; i < 20; i++)
                Console.Write(" " + stack[i]);
            Console.WriteLine();
        }

        private void VerifySolution(int sum, int[] s)
        {
            int check = 0;
            for (int x = 0; x < 20; x++)
                check += s[x] * (x + 1);
            if (check != sum)
                throw new Exception(check + " != " + sum);
        }

        private bool SubSolution(int sum, int pos, int[] stack)
        {
            if (sum >= 40) {
                solutions.Add(new Solution(stack, sum));
                return true;
            }

            if (pos >= 20)
                return false;

            for (int x = pos; x < 20; x++)
            {
                for (int y = stack[x]; y < quantity[x]; y++)
                {
                    stack[x]++;
                    if (SubSolution(sum + (x + 1) * (y + 1), x + 1, stack))
                        break;
                }
                stack[x] = 0;
            }
            return false;
        }

        private void FindSolutions()
        {
            addBtn.Text = sum.ToString();

            currentSolution = 0;
            solutions.Clear();

            if (sum >= 40)
            {
                SubSolution(0, 0, new int[20]);
                solutions.Sort();
            }
            PresentSolution();
        }

        private void RenumberLabels()
        {
            int i = 0;
            for (int x = 0; x < 20; x++)
                for (int y = 0; y < quantity[x]; y++)
                    (panel.Controls[i++] as Label).Text = (x + 1).ToString();
        }

        private void Add()
        {
            int value = Convert.ToInt32(inputBox.Value);
            if (value < 1 || value > 20)
                return;

            sum += value;
            quantity[value - 1]++;

            Label nu = new Label();
            nu.AutoSize = false;
            nu.Height = inputBox.Height;
            nu.Width  = inputBox.Width;
            nu.Margin = new Padding(0, 0, 2, 2);
            nu.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(nu);

            RenumberLabels();
            FindSolutions();
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            e.Handled = true;
            inputBox.Select(0, inputBox.Text.Length);

            Add();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            sum = 0;
            Array.Clear(quantity, 0, quantity.Length);
            currentSolution = 0;
            solutions.Clear();
            addBtn.Text = "";
            PresentSolution();
            inputBox.Focus();
            inputBox.Select(0, inputBox.Text.Length);
        }

        private void PresentSolution()
        {
            costLbl.ForeColor = ForeColor;

            if (currentSolution >= solutions.Count)
            {
                costLbl.BackColor = BackColor;
                foreach (Control c in panel.Controls)
                    c.BackColor = BackColor;

                solutionLbl.Text = "0/0";
                costLbl.Text = "";
                return;
            }

            Solution s = solutions[currentSolution];
            solutionLbl.Text = (currentSolution + 1) + "/" + solutions.Count;
            costLbl.Text = s.sum.ToString();
            if (s.sum > 45)
            {
                costLbl.BackColor = Color.OrangeRed;
                costLbl.ForeColor = Color.White;
            }
            else if (s.sum > 40)
            {
                costLbl.BackColor = Color.Orange;
            }
            else
            {
                costLbl.BackColor = Color.LightGreen;
            }

            int i = 0;
            for (int x = 0; x < 20; x++)
                for (int y = 0; y < quantity[x]; y++)
                    (panel.Controls[i++] as Label).BackColor = y < s.quantity[x] ? costLbl.BackColor : BackColor;
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

            Solution s = solutions[currentSolution];
            int newCount = 0;
            for (int x = 0; x < 20; x++)
            {
                sum -= (x + 1) * s.quantity[x];
                quantity[x] -= s.quantity[x];
                newCount += quantity[x];
            }

            while (panel.Controls.Count > newCount)
                panel.Controls.RemoveAt(newCount);

            RenumberLabels();
            FindSolutions();
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.Value > inputBox.Minimum)
                inputBox.Value--;
        }

        private void incBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.Value < inputBox.Maximum)
                inputBox.Value++;
        }
    }
}
