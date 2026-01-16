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
            Show_Toevoegen = new Button();
            Score_Show = new TextBox();
            Show_Invoer = new TextBox();
            Gemiddelde_Score = new Label();
            Laatste_Show = new Label();
            Aantal_Shows = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // Show_Toevoegen
            // 
            Show_Toevoegen.Location = new Point(243, 198);
            Show_Toevoegen.Name = "Show_Toevoegen";
            Show_Toevoegen.Size = new Size(241, 34);
            Show_Toevoegen.TabIndex = 0;
            Show_Toevoegen.Text = "Show toevoegen";
            Show_Toevoegen.UseVisualStyleBackColor = true;
            Show_Toevoegen.Click += Show_Toevoegen_Click;
            // 
            // Score_Show
            // 
            Score_Show.Location = new Point(399, 138);
            Score_Show.Name = "Score_Show";
            Score_Show.Size = new Size(150, 31);
            Score_Show.TabIndex = 1;
            Score_Show.TextChanged += Score_Show_TextChanged;
            // 
            // Show_Invoer
            // 
            Show_Invoer.Location = new Point(399, 91);
            Show_Invoer.Name = "Show_Invoer";
            Show_Invoer.Size = new Size(150, 31);
            Show_Invoer.TabIndex = 2;
            Show_Invoer.TextChanged += Show_Invoer_TextChanged;
            // 
            // Gemiddelde_Score
            // 
            Gemiddelde_Score.AutoSize = true;
            Gemiddelde_Score.Location = new Point(421, 265);
            Gemiddelde_Score.Name = "Gemiddelde_Score";
            Gemiddelde_Score.Size = new Size(0, 25);
            Gemiddelde_Score.TabIndex = 3;
            Gemiddelde_Score.Click += Gemiddelde_Score_Click;
            // 
            // Laatste_Show
            // 
            Laatste_Show.AutoSize = true;
            Laatste_Show.Location = new Point(425, 299);
            Laatste_Show.Name = "Laatste_Show";
            Laatste_Show.Size = new Size(0, 25);
            Laatste_Show.TabIndex = 4;
            Laatste_Show.Click += Laatste_Show_Click;
            // 
            // Aantal_Shows
            // 
            Aantal_Shows.AutoSize = true;
            Aantal_Shows.BackColor = SystemColors.ButtonHighlight;
            Aantal_Shows.Location = new Point(421, 336);
            Aantal_Shows.Name = "Aantal_Shows";
            Aantal_Shows.Size = new Size(0, 25);
            Aantal_Shows.TabIndex = 5;
            Aantal_Shows.Click += Aantal_Shows_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 257);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 6;
            label4.Text = "Gemiddelde score:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 301);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 7;
            label5.Text = "Laatste show:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 338);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 8;
            label6.Text = "Aantal:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(155, 138);
            label7.Name = "label7";
            label7.Size = new Size(165, 25);
            label7.TabIndex = 9;
            label7.Text = "Score van de show:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(155, 91);
            label8.Name = "label8";
            label8.Size = new Size(143, 25);
            label8.TabIndex = 10;
            label8.Text = "Voer de show in:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Aantal_Shows);
            Controls.Add(Laatste_Show);
            Controls.Add(Gemiddelde_Score);
            Controls.Add(Show_Invoer);
            Controls.Add(Score_Show);
            Controls.Add(Show_Toevoegen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Show_Toevoegen;
        private TextBox Score_Show;
        private TextBox Show_Invoer;
        private Label Gemiddelde_Score;
        private Label Laatste_Show;
        private Label Aantal_Shows;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
