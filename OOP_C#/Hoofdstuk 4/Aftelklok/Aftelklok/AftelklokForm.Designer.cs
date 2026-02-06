namespace Aftelklok
{
    partial class AftelklokForm
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
            this.components = new System.ComponentModel.Container();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.opnieuwOpStarttijd = new System.Windows.Forms.Button();
            this.aftelklokTimer = new System.Windows.Forms.Timer(this.components);
            this.START = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.Color.Black;
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.ForeColor = System.Drawing.Color.Lime;
            this.displayTextBox.Location = new System.Drawing.Point(40, 63);
            this.displayTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(190, 70);
            this.displayTextBox.TabIndex = 0;
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // opnieuwOpStarttijd
            // 
            this.opnieuwOpStarttijd.Location = new System.Drawing.Point(40, 18);
            this.opnieuwOpStarttijd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opnieuwOpStarttijd.Name = "opnieuwOpStarttijd";
            this.opnieuwOpStarttijd.Size = new System.Drawing.Size(192, 35);
            this.opnieuwOpStarttijd.TabIndex = 1;
            this.opnieuwOpStarttijd.Text = "Op starttijd";
            this.opnieuwOpStarttijd.UseVisualStyleBackColor = true;
            this.opnieuwOpStarttijd.Click += new System.EventHandler(this.opnieuwOpStarttijd_Click);
            // 
            // aftelklokTimer
            // 
            this.aftelklokTimer.Enabled = true;
            this.aftelklokTimer.Interval = 1000;
            this.aftelklokTimer.Tick += new System.EventHandler(this.aftelklokTimer_Tick);
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(13, 159);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(75, 23);
            this.START.TabIndex = 2;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // STOP
            // 
            this.STOP.Location = new System.Drawing.Point(158, 158);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(75, 23);
            this.STOP.TabIndex = 3;
            this.STOP.Text = "STOP";
            this.STOP.UseVisualStyleBackColor = true;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // AftelklokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 204);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.START);
            this.Controls.Add(this.opnieuwOpStarttijd);
            this.Controls.Add(this.displayTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AftelklokForm";
            this.Text = "Aftelklok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button opnieuwOpStarttijd;
        private System.Windows.Forms.Timer aftelklokTimer;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button STOP;
    }
}

