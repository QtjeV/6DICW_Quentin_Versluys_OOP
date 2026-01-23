namespace demoles
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
            button1 = new Button();
            leeftijdbox = new TextBox();
            plus = new Button();
            min = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(306, 92);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // leeftijdbox
            // 
            leeftijdbox.Location = new Point(289, 157);
            leeftijdbox.Name = "leeftijdbox";
            leeftijdbox.Size = new Size(150, 31);
            leeftijdbox.TabIndex = 1;
            // 
            // plus
            // 
            plus.Location = new Point(454, 100);
            plus.Name = "plus";
            plus.Size = new Size(112, 34);
            plus.TabIndex = 2;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // min
            // 
            min.Location = new Point(197, 92);
            min.Name = "min";
            min.Size = new Size(112, 34);
            min.TabIndex = 3;
            min.Text = "-";
            min.UseVisualStyleBackColor = true;
            min.Click += min_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(min);
            Controls.Add(plus);
            Controls.Add(leeftijdbox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox leeftijdbox;
        private Button plus;
        private Button min;
    }
}
