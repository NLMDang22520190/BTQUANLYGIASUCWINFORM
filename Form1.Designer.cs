namespace BTQUANLYGIASUCWINFORM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dETextBox = new TextBox();
            CuuTextBox = new TextBox();
            boTextBox = new TextBox();
            boLabel = new Label();
            addBtn = new Button();
            soundBtn = new Button();
            lastBtn = new Button();
            cuuLabel = new Label();
            deLabel = new Label();
            SuspendLayout();
            // 
            // dETextBox
            // 
            dETextBox.Location = new Point(528, 101);
            dETextBox.Name = "dETextBox";
            dETextBox.Size = new Size(150, 31);
            dETextBox.TabIndex = 0;
            // 
            // CuuTextBox
            // 
            CuuTextBox.Location = new Point(339, 101);
            CuuTextBox.Name = "CuuTextBox";
            CuuTextBox.Size = new Size(150, 31);
            CuuTextBox.TabIndex = 1;
            // 
            // boTextBox
            // 
            boTextBox.Location = new Point(129, 101);
            boTextBox.Name = "boTextBox";
            boTextBox.Size = new Size(150, 31);
            boTextBox.TabIndex = 2;
            // 
            // boLabel
            // 
            boLabel.AutoSize = true;
            boLabel.Location = new Point(159, 62);
            boLabel.Name = "boLabel";
            boLabel.Size = new Size(112, 25);
            boLabel.TabIndex = 3;
            boLabel.Text = "Số lượng bò";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(306, 156);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(223, 34);
            addBtn.TabIndex = 6;
            addBtn.Text = "Xác nhận số lượng";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // soundBtn
            // 
            soundBtn.Location = new Point(159, 281);
            soundBtn.Name = "soundBtn";
            soundBtn.Size = new Size(192, 34);
            soundBtn.TabIndex = 7;
            soundBtn.Text = "HIện tiếng kêu";
            soundBtn.UseVisualStyleBackColor = true;
            soundBtn.Click += soundBtn_Click;
            // 
            // lastBtn
            // 
            lastBtn.Location = new Point(528, 281);
            lastBtn.Name = "lastBtn";
            lastBtn.Size = new Size(112, 34);
            lastBtn.TabIndex = 8;
            lastBtn.Text = "Thống kê";
            lastBtn.UseVisualStyleBackColor = true;
            lastBtn.Click += lastBtn_Click;
            // 
            // cuuLabel
            // 
            cuuLabel.AutoSize = true;
            cuuLabel.Location = new Point(367, 62);
            cuuLabel.Name = "cuuLabel";
            cuuLabel.Size = new Size(119, 25);
            cuuLabel.TabIndex = 9;
            cuuLabel.Text = "Số lượng cừu";
            // 
            // deLabel
            // 
            deLabel.AutoSize = true;
            deLabel.Location = new Point(555, 62);
            deLabel.Name = "deLabel";
            deLabel.Size = new Size(110, 25);
            deLabel.TabIndex = 10;
            deLabel.Text = "Số lượng dê";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deLabel);
            Controls.Add(cuuLabel);
            Controls.Add(lastBtn);
            Controls.Add(soundBtn);
            Controls.Add(addBtn);
            Controls.Add(boLabel);
            Controls.Add(boTextBox);
            Controls.Add(CuuTextBox);
            Controls.Add(dETextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dETextBox;
        private TextBox CuuTextBox;
        private TextBox boTextBox;
        private Label boLabel;
        private Button addBtn;
        private Button soundBtn;
        private Button lastBtn;
        private Label cuuLabel;
        private Label deLabel;
    }
}
