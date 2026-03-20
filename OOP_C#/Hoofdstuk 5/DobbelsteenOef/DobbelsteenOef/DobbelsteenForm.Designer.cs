namespace DobbelsteenOef
{
    partial class DobbelsteenForm
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
            dobbelsteenPictureBox = new PictureBox();
            dobbelsteenTextBox = new TextBox();
            werpenButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dobbelsteenPictureBox).BeginInit();
            SuspendLayout();
            // 
            // dobbelsteenPictureBox
            // 
            dobbelsteenPictureBox.Image = Presentation.Properties.Resources.DobbelsteenBlanco;
            dobbelsteenPictureBox.Location = new Point(175, 86);
            dobbelsteenPictureBox.Name = "dobbelsteenPictureBox";
            dobbelsteenPictureBox.Size = new Size(142, 141);
            dobbelsteenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            dobbelsteenPictureBox.TabIndex = 0;
            dobbelsteenPictureBox.TabStop = false;
            // 
            // dobbelsteenTextBox
            // 
            dobbelsteenTextBox.Location = new Point(216, 120);
            dobbelsteenTextBox.Name = "dobbelsteenTextBox";
            dobbelsteenTextBox.ReadOnly = true;
            dobbelsteenTextBox.Size = new Size(61, 31);
            dobbelsteenTextBox.TabIndex = 1;
            // 
            // werpenButton
            // 
            werpenButton.Location = new Point(190, 250);
            werpenButton.Name = "werpenButton";
            werpenButton.Size = new Size(112, 34);
            werpenButton.TabIndex = 2;
            werpenButton.Text = "WERPEN";
            werpenButton.UseVisualStyleBackColor = true;
            werpenButton.Click += werpenButton_Click;
            // 
            // DobbelsteenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(werpenButton);
            Controls.Add(dobbelsteenTextBox);
            Controls.Add(dobbelsteenPictureBox);
            Name = "DobbelsteenForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dobbelsteenPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox dobbelsteenPictureBox;
        private TextBox dobbelsteenTextBox;
        private Button werpenButton;
    }
}
