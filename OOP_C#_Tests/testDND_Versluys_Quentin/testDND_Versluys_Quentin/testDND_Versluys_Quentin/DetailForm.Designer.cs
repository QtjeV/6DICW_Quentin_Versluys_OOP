namespace DnDPresentation
{
    partial class DetailForm
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
            NaamLabel = new Label();
            StrengthLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // NaamLabel
            // 
            NaamLabel.AutoSize = true;
            NaamLabel.Location = new Point(343, 90);
            NaamLabel.Name = "NaamLabel";
            NaamLabel.Size = new Size(59, 25);
            NaamLabel.TabIndex = 0;
            NaamLabel.Text = "label1";
            // 
            // StrengthLabel
            // 
            StrengthLabel.AutoSize = true;
            StrengthLabel.Location = new Point(334, 171);
            StrengthLabel.Name = "StrengthLabel";
            StrengthLabel.Size = new Size(59, 25);
            StrengthLabel.TabIndex = 1;
            StrengthLabel.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 75);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 2;
            label3.Text = "Naam:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 164);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 3;
            label4.Text = "Strength:";
            // 
            // DetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(StrengthLabel);
            Controls.Add(NaamLabel);
            Name = "DetailForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NaamLabel;
        private Label StrengthLabel;
        private Label label3;
        private Label label4;
    }
}