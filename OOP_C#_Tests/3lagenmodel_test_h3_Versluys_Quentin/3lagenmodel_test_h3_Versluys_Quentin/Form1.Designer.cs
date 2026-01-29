namespace _3lagenmodel_test_h3_Versluys_Quentin
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
            label1 = new Label();
            label2 = new Label();
            DochterButton = new Button();
            ZoonButton = new Button();
            AantalVoorspellingenLabel = new Label();
            HoogteLabel = new Label();
            ManTextBox = new TextBox();
            VrouwTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 51);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 1;
            label1.Text = "lengte man in cm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 98);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 2;
            label2.Text = "lengte vrouw in cm:";
            // 
            // DochterButton
            // 
            DochterButton.Location = new Point(525, 175);
            DochterButton.Name = "DochterButton";
            DochterButton.Size = new Size(239, 39);
            DochterButton.TabIndex = 3;
            DochterButton.Text = "Bereken Lengte Dochter";
            DochterButton.UseVisualStyleBackColor = true;
            DochterButton.Click += DochterButton_Click;
            // 
            // ZoonButton
            // 
            ZoonButton.Location = new Point(525, 237);
            ZoonButton.Name = "ZoonButton";
            ZoonButton.Size = new Size(242, 36);
            ZoonButton.TabIndex = 4;
            ZoonButton.Text = "Bereken Lengte Zoon";
            ZoonButton.UseVisualStyleBackColor = true;
            ZoonButton.Click += ZoonButton_Click;
            // 
            // AantalVoorspellingenLabel
            // 
            AantalVoorspellingenLabel.AutoSize = true;
            AantalVoorspellingenLabel.BackColor = SystemColors.ControlLightLight;
            AantalVoorspellingenLabel.Location = new Point(32, 396);
            AantalVoorspellingenLabel.Name = "AantalVoorspellingenLabel";
            AantalVoorspellingenLabel.Size = new Size(213, 25);
            AantalVoorspellingenLabel.TabIndex = 5;
            AantalVoorspellingenLabel.Text = "Nog geen voorspellingen";
            // 
            // HoogteLabel
            // 
            HoogteLabel.AutoSize = true;
            HoogteLabel.BackColor = SystemColors.ActiveCaptionText;
            HoogteLabel.Font = new Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HoogteLabel.ForeColor = SystemColors.ButtonHighlight;
            HoogteLabel.Location = new Point(333, 308);
            HoogteLabel.Name = "HoogteLabel";
            HoogteLabel.Size = new Size(149, 61);
            HoogteLabel.TabIndex = 6;
            HoogteLabel.Text = "Leeg";
            HoogteLabel.Visible = false;
            // 
            // ManTextBox
            // 
            ManTextBox.Location = new Point(212, 51);
            ManTextBox.Name = "ManTextBox";
            ManTextBox.Size = new Size(150, 31);
            ManTextBox.TabIndex = 7;
            // 
            // VrouwTextBox
            // 
            VrouwTextBox.Location = new Point(212, 95);
            VrouwTextBox.Name = "VrouwTextBox";
            VrouwTextBox.Size = new Size(150, 31);
            VrouwTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.kind;
            ClientSize = new Size(800, 450);
            Controls.Add(VrouwTextBox);
            Controls.Add(ManTextBox);
            Controls.Add(HoogteLabel);
            Controls.Add(AantalVoorspellingenLabel);
            Controls.Add(ZoonButton);
            Controls.Add(DochterButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button DochterButton;
        private Button ZoonButton;
        private Label AantalVoorspellingenLabel;
        private Label HoogteLabel;
        private TextBox ManTextBox;
        private TextBox VrouwTextBox;
    }
}
