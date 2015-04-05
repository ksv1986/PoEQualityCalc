namespace PoEQualityCalc
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
            this.solutionLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.sellBtn = new System.Windows.Forms.Button();
            this.sumLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 13);
            this.inputBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.inputBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 22);
            this.inputBox.TabIndex = 0;
            this.inputBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(12, 77);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(100, 27);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.AutoScrollMinSize = new System.Drawing.Size(120, 24);
            this.panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel.Location = new System.Drawing.Point(13, 110);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(263, 251);
            this.panel.TabIndex = 2;
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(119, 13);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(30, 58);
            this.prevBtn.TabIndex = 5;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(247, 13);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(30, 58);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // solutionLbl
            // 
            this.solutionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solutionLbl.Location = new System.Drawing.Point(155, 13);
            this.solutionLbl.Name = "solutionLbl";
            this.solutionLbl.Size = new System.Drawing.Size(86, 29);
            this.solutionLbl.TabIndex = 7;
            this.solutionLbl.Text = "0/0";
            this.solutionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // costLbl
            // 
            this.costLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLbl.Location = new System.Drawing.Point(155, 42);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(86, 27);
            this.costLbl.TabIndex = 8;
            this.costLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sellBtn
            // 
            this.sellBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellBtn.Location = new System.Drawing.Point(119, 77);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(158, 27);
            this.sellBtn.TabIndex = 4;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // sumLbl
            // 
            this.sumLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumLbl.Location = new System.Drawing.Point(13, 42);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(99, 27);
            this.sumLbl.TabIndex = 9;
            this.sumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 373);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.solutionLbl);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.inputBox);
            this.Name = "MainForm";
            this.Text = "QualityCalc";
            ((System.ComponentModel.ISupportInitialize)(this.inputBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown inputBox;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label solutionLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Label sumLbl;

    }
}

