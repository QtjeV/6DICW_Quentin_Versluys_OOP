namespace testDND_Versluys_Quentin
{
    partial class StartForm
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
            NaamBox = new TextBox();
            StrengthBox = new TextBox();
            VoegToeButton = new Button();
            FormulierButton = new Button();
            ToonHierButton = new Button();
            CharachterBox = new ComboBox();
            ToonHierLabel = new Label();
            SuspendLayout();
            // 
            // NaamBox
            // 
            NaamBox.Location = new Point(57, 60);
            NaamBox.Name = "NaamBox";
            NaamBox.Size = new Size(150, 31);
            NaamBox.TabIndex = 0;
            // 
            // StrengthBox
            // 
            StrengthBox.Location = new Point(56, 124);
            StrengthBox.Name = "StrengthBox";
            StrengthBox.Size = new Size(150, 31);
            StrengthBox.TabIndex = 1;
            // 
            // VoegToeButton
            // 
            VoegToeButton.Location = new Point(366, 83);
            VoegToeButton.Name = "VoegToeButton";
            VoegToeButton.Size = new Size(112, 34);
            VoegToeButton.TabIndex = 2;
            VoegToeButton.Text = "Voeg Toe...";
            VoegToeButton.UseVisualStyleBackColor = true;
            VoegToeButton.Click += VoegToeButton_Click;
            // 
            // FormulierButton
            // 
            FormulierButton.Location = new Point(272, 264);
            FormulierButton.Name = "FormulierButton";
            FormulierButton.Size = new Size(182, 34);
            FormulierButton.TabIndex = 3;
            FormulierButton.Text = "Toon Formulier";
            FormulierButton.UseVisualStyleBackColor = true;
            FormulierButton.Click += FormulierButton_Click;
            // 
            // ToonHierButton
            // 
            ToonHierButton.Location = new Point(272, 334);
            ToonHierButton.Name = "ToonHierButton";
            ToonHierButton.Size = new Size(182, 34);
            ToonHierButton.TabIndex = 4;
            ToonHierButton.Text = "Toon Hier";
            ToonHierButton.UseVisualStyleBackColor = true;
            ToonHierButton.Click += ToonHierButton_Click;
            // 
            // CharachterBox
            // 
            CharachterBox.FormattingEnabled = true;
            CharachterBox.Location = new Point(272, 202);
            CharachterBox.Name = "CharachterBox";
            CharachterBox.Size = new Size(182, 33);
            CharachterBox.TabIndex = 5;
            // 
            // ToonHierLabel
            // 
            ToonHierLabel.AutoSize = true;
            ToonHierLabel.Location = new Point(550, 339);
            ToonHierLabel.Name = "ToonHierLabel";
            ToonHierLabel.Size = new Size(26, 25);
            ToonHierLabel.TabIndex = 6;
            ToonHierLabel.Text = "\"\"";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ToonHierLabel);
            Controls.Add(CharachterBox);
            Controls.Add(ToonHierButton);
            Controls.Add(FormulierButton);
            Controls.Add(VoegToeButton);
            Controls.Add(StrengthBox);
            Controls.Add(NaamBox);
            Name = "StartForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NaamBox;
        private TextBox StrengthBox;
        private Button VoegToeButton;
        private Button FormulierButton;
        private Button ToonHierButton;
        private ComboBox CharachterBox;
        private Label ToonHierLabel;
    }
}
