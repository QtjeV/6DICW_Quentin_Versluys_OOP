namespace OpDeWeegschaal
{
    partial class BMIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groote_label = new System.Windows.Forms.Label();
            this.groote_box = new System.Windows.Forms.TextBox();
            this.gewicht_box = new System.Windows.Forms.MaskedTextBox();
            this.gewicht_label = new System.Windows.Forms.Label();
            this.bmi_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.bmi_box = new System.Windows.Forms.TextBox();
            this.status_box = new System.Windows.Forms.TextBox();
            this.minus_button = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(390, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 432);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groote_label
            // 
            this.groote_label.AutoSize = true;
            this.groote_label.Location = new System.Drawing.Point(44, 61);
            this.groote_label.Name = "groote_label";
            this.groote_label.Size = new System.Drawing.Size(135, 20);
            this.groote_label.TabIndex = 1;
            this.groote_label.Text = "Grootte (in meter)";
            // 
            // groote_box
            // 
            this.groote_box.Location = new System.Drawing.Point(219, 61);
            this.groote_box.Name = "groote_box";
            this.groote_box.ReadOnly = true;
            this.groote_box.Size = new System.Drawing.Size(100, 26);
            this.groote_box.TabIndex = 2;
            // 
            // gewicht_box
            // 
            this.gewicht_box.Location = new System.Drawing.Point(219, 115);
            this.gewicht_box.Name = "gewicht_box";
            this.gewicht_box.ReadOnly = true;
            this.gewicht_box.Size = new System.Drawing.Size(100, 26);
            this.gewicht_box.TabIndex = 3;
            // 
            // gewicht_label
            // 
            this.gewicht_label.AutoSize = true;
            this.gewicht_label.Location = new System.Drawing.Point(65, 115);
            this.gewicht_label.Name = "gewicht_label";
            this.gewicht_label.Size = new System.Drawing.Size(114, 20);
            this.gewicht_label.TabIndex = 4;
            this.gewicht_label.Text = "Gewicht (in kg)";
            // 
            // bmi_label
            // 
            this.bmi_label.AutoSize = true;
            this.bmi_label.Location = new System.Drawing.Point(145, 194);
            this.bmi_label.Name = "bmi_label";
            this.bmi_label.Size = new System.Drawing.Size(34, 20);
            this.bmi_label.TabIndex = 5;
            this.bmi_label.Text = "bmi";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(126, 241);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(53, 20);
            this.status_label.TabIndex = 6;
            this.status_label.Text = "status";
            // 
            // bmi_box
            // 
            this.bmi_box.Location = new System.Drawing.Point(219, 194);
            this.bmi_box.Name = "bmi_box";
            this.bmi_box.ReadOnly = true;
            this.bmi_box.Size = new System.Drawing.Size(100, 26);
            this.bmi_box.TabIndex = 7;
            // 
            // status_box
            // 
            this.status_box.Location = new System.Drawing.Point(219, 241);
            this.status_box.Name = "status_box";
            this.status_box.ReadOnly = true;
            this.status_box.Size = new System.Drawing.Size(100, 26);
            this.status_box.TabIndex = 8;
            // 
            // minus_button
            // 
            this.minus_button.Location = new System.Drawing.Point(189, 117);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(24, 24);
            this.minus_button.TabIndex = 9;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = true;
            this.minus_button.Click += new System.EventHandler(this.minus_button_Click);
            // 
            // plus_button
            // 
            this.plus_button.Location = new System.Drawing.Point(326, 117);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(24, 24);
            this.plus_button.TabIndex = 10;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = true;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // BMIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 432);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.status_box);
            this.Controls.Add(this.bmi_box);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.bmi_label);
            this.Controls.Add(this.gewicht_label);
            this.Controls.Add(this.gewicht_box);
            this.Controls.Add(this.groote_box);
            this.Controls.Add(this.groote_label);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BMIForm";
            this.Text = "BMIForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label groote_label;
        private System.Windows.Forms.TextBox groote_box;
        private System.Windows.Forms.MaskedTextBox gewicht_box;
        private System.Windows.Forms.Label gewicht_label;
        private System.Windows.Forms.Label bmi_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.TextBox bmi_box;
        private System.Windows.Forms.TextBox status_box;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button plus_button;
    }
}

