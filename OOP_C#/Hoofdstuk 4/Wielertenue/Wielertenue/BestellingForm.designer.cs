namespace Wielertenue
{
    partial class BestellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestellingForm));
            this.wielertruiPictureBox = new System.Windows.Forms.PictureBox();
            this.wielertenuePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.waterdichtzakje = new System.Windows.Forms.CheckBox();
            this.wielbroekje = new System.Windows.Forms.CheckBox();
            this.prijsTextBox = new System.Windows.Forms.TextBox();
            this.superzeemcheckbox = new System.Windows.Forms.CheckBox();
            this.aantalBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wielertruiPictureBox
            // 
            this.wielertruiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertruiPictureBox.Image")));
            this.wielertruiPictureBox.Location = new System.Drawing.Point(24, 14);
            this.wielertruiPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wielertruiPictureBox.Name = "wielertruiPictureBox";
            this.wielertruiPictureBox.Size = new System.Drawing.Size(537, 531);
            this.wielertruiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertruiPictureBox.TabIndex = 0;
            this.wielertruiPictureBox.TabStop = false;
            // 
            // wielertenuePictureBox
            // 
            this.wielertenuePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertenuePictureBox.Image")));
            this.wielertenuePictureBox.Location = new System.Drawing.Point(45, 14);
            this.wielertenuePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wielertenuePictureBox.Name = "wielertenuePictureBox";
            this.wielertenuePictureBox.Size = new System.Drawing.Size(537, 531);
            this.wielertenuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertenuePictureBox.TabIndex = 0;
            this.wielertenuePictureBox.TabStop = false;
            this.wielertenuePictureBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aantal";
            // 
            // waterdichtzakje
            // 
            this.waterdichtzakje.AutoSize = true;
            this.waterdichtzakje.Location = new System.Drawing.Point(728, 168);
            this.waterdichtzakje.Name = "waterdichtzakje";
            this.waterdichtzakje.Size = new System.Drawing.Size(153, 24);
            this.waterdichtzakje.TabIndex = 3;
            this.waterdichtzakje.Text = "Waterdicht zakje";
            this.waterdichtzakje.UseVisualStyleBackColor = true;
            this.waterdichtzakje.CheckedChanged += new System.EventHandler(this.waterdichtzakje_CheckedChanged);
            // 
            // wielbroekje
            // 
            this.wielbroekje.AutoSize = true;
            this.wielbroekje.Location = new System.Drawing.Point(728, 234);
            this.wielbroekje.Name = "wielbroekje";
            this.wielbroekje.Size = new System.Drawing.Size(188, 24);
            this.wielbroekje.TabIndex = 4;
            this.wielbroekje.Text = "inclusief wielerbroekje";
            this.wielbroekje.UseVisualStyleBackColor = true;
            this.wielbroekje.CheckedChanged += new System.EventHandler(this.wielbroekje_CheckedChanged);
            // 
            // prijsTextBox
            // 
            this.prijsTextBox.Location = new System.Drawing.Point(691, 420);
            this.prijsTextBox.Name = "prijsTextBox";
            this.prijsTextBox.ReadOnly = true;
            this.prijsTextBox.Size = new System.Drawing.Size(158, 26);
            this.prijsTextBox.TabIndex = 5;
            // 
            // superzeemcheckbox
            // 
            this.superzeemcheckbox.AutoSize = true;
            this.superzeemcheckbox.Location = new System.Drawing.Point(728, 199);
            this.superzeemcheckbox.Name = "superzeemcheckbox";
            this.superzeemcheckbox.Size = new System.Drawing.Size(123, 24);
            this.superzeemcheckbox.TabIndex = 6;
            this.superzeemcheckbox.Text = "Super Zeem";
            this.superzeemcheckbox.UseVisualStyleBackColor = true;
            this.superzeemcheckbox.Visible = false;
            this.superzeemcheckbox.CheckedChanged += new System.EventHandler(this.superzeemcheckbox_CheckedChanged);
            // 
            // aantalBox
            // 
            this.aantalBox.Location = new System.Drawing.Point(729, 112);
            this.aantalBox.Name = "aantalBox";
            this.aantalBox.Size = new System.Drawing.Size(120, 26);
            this.aantalBox.TabIndex = 7;
            this.aantalBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aantalBox.ValueChanged += new System.EventHandler(this.aantalBox_ValueChanged);
            // 
            // BestellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 568);
            this.Controls.Add(this.aantalBox);
            this.Controls.Add(this.superzeemcheckbox);
            this.Controls.Add(this.prijsTextBox);
            this.Controls.Add(this.wielbroekje);
            this.Controls.Add(this.waterdichtzakje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wielertenuePictureBox);
            this.Controls.Add(this.wielertruiPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BestellingForm";
            this.Text = "BestellingWielertenueForm";
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wielertruiPictureBox;
        private System.Windows.Forms.PictureBox wielertenuePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox waterdichtzakje;
        private System.Windows.Forms.CheckBox wielbroekje;
        private System.Windows.Forms.TextBox prijsTextBox;
        private System.Windows.Forms.CheckBox superzeemcheckbox;
        private System.Windows.Forms.NumericUpDown aantalBox;
    }
}