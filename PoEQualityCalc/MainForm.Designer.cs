/*
This file is part of PoEQualityCalc.

PoEQualityCalc is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 2 of the License, or
(at your option) any later version.

PoEQualityCalc is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with PoEQualityCalc.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace PoE
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.NumericUpDown();
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.indexLbl = new System.Windows.Forms.Label();
            this.sellBtn = new System.Windows.Forms.Button();
            this.decBtn = new System.Windows.Forms.Button();
            this.incBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.sumLbl = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.dealBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(45, 14);
            this.inputBox.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.inputBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(58, 25);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnInputBoxKeyPress);
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Location = new System.Drawing.Point(150, 48);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(140, 29);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.OnResetButtonClick);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.AutoScrollMinSize = new System.Drawing.Size(120, 24);
            this.panel.Location = new System.Drawing.Point(9, 85);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(281, 189);
            this.panel.TabIndex = 2;
            // 
            // prevBtn
            // 
            this.prevBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBtn.Location = new System.Drawing.Point(154, 280);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(29, 29);
            this.prevBtn.TabIndex = 5;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.OnPreviousButtonClick);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Location = new System.Drawing.Point(261, 280);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(29, 29);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.OnNextButtonClick);
            // 
            // solutionLbl
            // 
            this.indexLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.indexLbl.Location = new System.Drawing.Point(189, 280);
            this.indexLbl.Name = "solutionLbl";
            this.indexLbl.Size = new System.Drawing.Size(70, 29);
            this.indexLbl.TabIndex = 7;
            this.indexLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sellBtn
            // 
            this.sellBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellBtn.Enabled = false;
            this.sellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn.Location = new System.Drawing.Point(9, 316);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(281, 29);
            this.sellBtn.TabIndex = 4;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.OnSellButtonClick);
            // 
            // decBtn
            // 
            this.decBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decBtn.Location = new System.Drawing.Point(9, 11);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(29, 29);
            this.decBtn.TabIndex = 10;
            this.decBtn.Text = "-";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.OnDecreaseButtonClick);
            // 
            // incBtn
            // 
            this.incBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incBtn.Location = new System.Drawing.Point(110, 11);
            this.incBtn.Name = "incBtn";
            this.incBtn.Size = new System.Drawing.Size(29, 29);
            this.incBtn.TabIndex = 11;
            this.incBtn.Text = "+";
            this.incBtn.UseVisualStyleBackColor = true;
            this.incBtn.Click += new System.EventHandler(this.OnIncreaseButtonClick);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(150, 11);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(140, 29);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Location = new System.Drawing.Point(63, 51);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(34, 17);
            this.sumLbl.TabIndex = 13;
            this.sumLbl.Text = "total";
            this.sumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(9, 48);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(45, 25);
            this.totalBox.TabIndex = 14;
            // 
            // dealBox
            // 
            this.dealBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dealBox.Location = new System.Drawing.Point(9, 283);
            this.dealBox.Name = "dealBox";
            this.dealBox.ReadOnly = true;
            this.dealBox.Size = new System.Drawing.Size(45, 25);
            this.dealBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "deal cost";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealBox);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.incBtn);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.indexLbl);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.inputBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "QualityCalc";
            ((System.ComponentModel.ISupportInitialize)(this.inputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown inputBox;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label indexLbl;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Button decBtn;
        private System.Windows.Forms.Button incBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.TextBox dealBox;
        private System.Windows.Forms.Label label1;
    }
}

