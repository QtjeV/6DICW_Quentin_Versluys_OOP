namespace Presentation
{
    partial class StartForm
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
            dobbelsteen6Button = new Button();
            dobbelsteen12Button = new Button();
            dobbelsteenXButton = new Button();
            zijdenNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)zijdenNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // dobbelsteen6Button
            // 
            dobbelsteen6Button.Location = new Point(289, 72);
            dobbelsteen6Button.Name = "dobbelsteen6Button";
            dobbelsteen6Button.Size = new Size(229, 34);
            dobbelsteen6Button.TabIndex = 0;
            dobbelsteen6Button.Text = "Klassieke dobbelsteen";
            dobbelsteen6Button.UseVisualStyleBackColor = true;
            dobbelsteen6Button.Click += dobbelsteen6Button_Click;
            // 
            // dobbelsteen12Button
            // 
            dobbelsteen12Button.Location = new Point(289, 141);
            dobbelsteen12Button.Name = "dobbelsteen12Button";
            dobbelsteen12Button.Size = new Size(229, 34);
            dobbelsteen12Button.TabIndex = 1;
            dobbelsteen12Button.Text = "12 zijdige dobbelsteen";
            dobbelsteen12Button.UseVisualStyleBackColor = true;
            dobbelsteen12Button.Click += dobbelsteen12Button_Click;
            // 
            // dobbelsteenXButton
            // 
            dobbelsteenXButton.Location = new Point(289, 290);
            dobbelsteenXButton.Name = "dobbelsteenXButton";
            dobbelsteenXButton.Size = new Size(229, 34);
            dobbelsteenXButton.TabIndex = 2;
            dobbelsteenXButton.Text = "X dobbelsteen";
            dobbelsteenXButton.UseVisualStyleBackColor = true;
            dobbelsteenXButton.Click += dobbelsteenXButton_Click;
            // 
            // zijdenNumericUpDown
            // 
            zijdenNumericUpDown.Location = new Point(289, 228);
            zijdenNumericUpDown.Name = "zijdenNumericUpDown";
            zijdenNumericUpDown.Size = new Size(229, 31);
            zijdenNumericUpDown.TabIndex = 3;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(zijdenNumericUpDown);
            Controls.Add(dobbelsteenXButton);
            Controls.Add(dobbelsteen12Button);
            Controls.Add(dobbelsteen6Button);
            Name = "StartForm";
            Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)zijdenNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button dobbelsteen6Button;
        private Button dobbelsteen12Button;
        private Button dobbelsteenXButton;
        private NumericUpDown zijdenNumericUpDown;
    }
}