using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PoE
{
    public partial class MainForm : Form
    {
        QualityQuantities inventory = new QualityQuantities();
        List<QualityQuantities> allDeals = new List<QualityQuantities>();
        List<QualityQuantities> bestDeals = new List<QualityQuantities>();
        int selectedDeal = 0;
        Color[] colors = {
            Color.LightGreen,
            Color.LightBlue,
            Color.LightCyan,
            Color.LightSalmon,
            Color.Gold,
            Color.Yellow,
            Color.White,
            Color.Bisque,
            Color.Khaki,
            Color.Olive,
        };

        public MainForm()
        {
            InitializeComponent();

            /// Put initial inventory here
            /// Add(6); Add(7); Add(8); Add(9); Add(10);

            RefreshInterface();
        }

        private void RefreshInterface()
        {
            RenumberLabels();
            FindDeals();

            inputBox.Focus();
            inputBox.Select(0, inputBox.Text.Length);
        }

        private void PrintDeal(string title, QualityQuantities deal)
        {
            Console.Write(title + ": (" + deal.Sum + ")");
            for (var i = 1; i <= Limits.MaxQuality; i++)
                Console.Write(" " + deal.At(i));

            Console.WriteLine();
        }

        private void RenumberLabels()
        {
            var index = 0;
            for (var quality = 1; quality <= Limits.MaxQuality; quality++)
            {
                for (var value = 0; value < inventory.At(quality); value++)
                {
                    var label = panel.Controls[index++] as Label;
                    label.Text = quality.ToString();
                    label.Tag = quality;
                }
            }
        }

        private void Add(int value)
        {
            inventory.IncreaseQuantityOf(value);

            var label = new Label();
            label.AutoSize = false;
            label.Height = decBtn.Height;
            label.Width = decBtn.Width;
            label.Margin = new Padding(3, 3, 3, 3);
            label.BorderStyle = BorderStyle.FixedSingle;
            label.ForeColor = SystemColors.GrayText;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.MouseClick += new MouseEventHandler(OnItemLabelMouseClick);

            panel.Controls.Add(label);
        }

        private void ProcessInput()
        {
            var value = Convert.ToInt32(inputBox.Value);
            if (value < 1 || value > Limits.MaxQuality)
                return;

            Add(value);

            RenumberLabels();
            FindDeals();
        }

        private void OnInputBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            e.Handled = true;
            inputBox.Select(0, inputBox.Text.Length);

            ProcessInput();
        }

        private void OnAddButtonClick(object sender, EventArgs e)
        {
            ProcessInput();
        }

        private void OnResetButtonClick(object sender, EventArgs e)
        {
            inventory.Clear();
            allDeals.Clear();
            bestDeals.Clear();

            panel.Controls.Clear();

            RefreshInterface();
        }

        private void FindDeals()
        {
            totalBox.Text = inventory.Sum > 0 ? inventory.Sum.ToString() : "";
            selectedDeal = 0;
            allDeals.Clear();
            bestDeals.Clear();

            if (inventory.Sum >= Limits.VendoredQuality)
            {
                allDeals = inventory.FindAllPossibleDeals();

                if (inventory.Sum >= 2 * Limits.VendoredQuality)
                    bestDeals = inventory.FindBestDeals(allDeals);
            }

            ShowDeal();
        }

        private void ShowNoDeal()
        {
            sellBtn.Enabled = false;
            sellBtn.BackColor = BackColor;

            foreach (Control label in panel.Controls)
            {
                label.BackColor = BackColor;
                label.ForeColor = SystemColors.GrayText;
            }

            indexLbl.Text = "";
            dealBox.Text = "";
        }

        private void ShowMultipleDeals()
        {
            var lastQuality = 0;
            var quantity = 0;
            var dealIndex = 0;
            for (var i = 0; i < panel.Controls.Count; i++)
            {
                var label = panel.Controls[i] as Label;
                var quality = Convert.ToInt32(label.Tag);
                label.BackColor = BackColor;
                label.ForeColor = SystemColors.GrayText;

                if (lastQuality != quality)
                {
                    lastQuality = quality;
                    dealIndex = 0;
                    quantity = 0;
                }

                while (dealIndex < bestDeals.Count)
                {
                    if (bestDeals[dealIndex].At(quality) > quantity)
                    {
                        quantity++;
                        label.BackColor = colors[dealIndex];
                        label.ForeColor = SystemColors.WindowText;
                        break;
                    }
                    quantity = 0;
                    dealIndex++;
                }
            }

            sellBtn.BackColor = Color.Gold;
            indexLbl.Text = bestDeals.Count + "/" + allDeals.Count;
            dealBox.Text = (Limits.VendoredQuality * bestDeals.Count).ToString();
        }

        private void ShowSingleDeal(QualityQuantities deal)
        {
            indexLbl.Text = (selectedDeal + 1) + "/" + allDeals.Count;
            dealBox.Text = deal.Sum.ToString();
            if (deal.Sum > Limits.VendoredQuality + 5)
            {
                sellBtn.BackColor = Color.OrangeRed;
                sellBtn.ForeColor = Color.White;
            }
            else if (deal.Sum > Limits.VendoredQuality)
            {
                sellBtn.BackColor = Color.Orange;
            }
            else
            {
                sellBtn.BackColor = Color.LightGreen;
            }

            var index = 0;
            for (var quality = 1; quality <= Limits.MaxQuality; quality++)
            {
                for (var quantity = 0; quantity < inventory.At(quality); quantity++)
                {
                    var label = panel.Controls[index++] as Label;
                    if (quantity < deal.At(quality))
                    {
                        label.BackColor = sellBtn.BackColor;
                        label.ForeColor = SystemColors.WindowText;
                    }
                    else
                    {
                        label.BackColor = BackColor;
                        label.ForeColor = SystemColors.GrayText;
                    }
                }
            }
        }

        private void ShowDeal()
        {
            sellBtn.ForeColor = ForeColor;
            prevBtn.Enabled = nextBtn.Enabled = false;

            if (selectedDeal >= allDeals.Count)
            {
                ShowNoDeal();
                return;
            }

            sellBtn.Enabled = true;
            if (bestDeals.Count > 1)
            {
                ShowMultipleDeals();
                return;
            }

            prevBtn.Enabled = nextBtn.Enabled = true;
            ShowSingleDeal(allDeals[selectedDeal]);
        }

        private void OnPreviousButtonClick(object sender, EventArgs e)
        {
            if (selectedDeal <= 0)
                return;

            selectedDeal--;
            ShowDeal();
        }

        private void OnNextButtonClick(object sender, EventArgs e)
        {
            if (selectedDeal >= allDeals.Count - 1)
                return;

            selectedDeal++;
            ShowDeal();
        }

        private void OnSellButtonClick(object sender, EventArgs e)
        {
            if (selectedDeal >= allDeals.Count)
                return;

            if (bestDeals.Count > 1)
            {
                foreach (var deal in bestDeals)
                    inventory.Subtract(deal);
            }
            else
            {
                inventory.Subtract(allDeals[selectedDeal]);
            }

            panel.SuspendLayout();
            while (panel.Controls.Count > inventory.Count)
                panel.Controls.RemoveAt(inventory.Count);
            panel.ResumeLayout();

            RefreshInterface();
        }

        private void OnDecreaseButtonClick(object sender, EventArgs e)
        {
            if (inputBox.Value > inputBox.Minimum)
                inputBox.Value--;
        }

        private void OnIncreaseButtonClick(object sender, EventArgs e)
        {
            if (inputBox.Value < inputBox.Maximum)
                inputBox.Value++;
        }

        private void OnItemLabelMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Middle)
                return;

            var label = sender as Label;
            var quality = Convert.ToInt32(label.Tag);
            inventory.DecreaseQuantityOf(quality);

            panel.Controls.RemoveAt(panel.Controls.Count - 1);
            RefreshInterface();
        }
    }
}
