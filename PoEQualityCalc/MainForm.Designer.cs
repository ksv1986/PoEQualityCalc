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
            this.decBtn = new System.Windows.Forms.Button();
            this.incBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(42, 12);
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
            this.inputBox.Size = new System.Drawing.Size(54, 24);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            // 
            // resetBtn
            // 
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Location = new System.Drawing.Point(14, 87);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(112, 30);
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
            this.panel.Location = new System.Drawing.Point(15, 123);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 3, 2, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(296, 282);
            this.panel.TabIndex = 2;
            // 
            // prevBtn
            // 
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBtn.Location = new System.Drawing.Point(134, 12);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(33, 68);
            this.prevBtn.TabIndex = 5;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Location = new System.Drawing.Point(278, 12);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(33, 68);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // solutionLbl
            // 
            this.solutionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solutionLbl.Location = new System.Drawing.Point(174, 12);
            this.solutionLbl.Name = "solutionLbl";
            this.solutionLbl.Size = new System.Drawing.Size(96, 36);
            this.solutionLbl.TabIndex = 7;
            this.solutionLbl.Text = "0/0";
            this.solutionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // costLbl
            // 
            this.costLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLbl.Location = new System.Drawing.Point(174, 47);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(96, 30);
            this.costLbl.TabIndex = 8;
            this.costLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sellBtn
            // 
            this.sellBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn.Location = new System.Drawing.Point(134, 87);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(177, 30);
            this.sellBtn.TabIndex = 4;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // decBtn
            // 
            this.decBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decBtn.Location = new System.Drawing.Point(12, 12);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(24, 24);
            this.decBtn.TabIndex = 10;
            this.decBtn.Text = "-";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // incBtn
            // 
            this.incBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incBtn.Location = new System.Drawing.Point(102, 12);
            this.incBtn.Name = "incBtn";
            this.incBtn.Size = new System.Drawing.Size(24, 24);
            this.incBtn.TabIndex = 11;
            this.incBtn.Text = "+";
            this.incBtn.UseVisualStyleBackColor = true;
            this.incBtn.Click += new System.EventHandler(this.incBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(12, 47);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(114, 30);
            this.addBtn.TabIndex = 12;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 420);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.incBtn);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.solutionLbl);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.inputBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
        private System.Windows.Forms.Button decBtn;
        private System.Windows.Forms.Button incBtn;
        private System.Windows.Forms.Button addBtn;

    }
}

