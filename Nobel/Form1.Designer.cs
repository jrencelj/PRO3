namespace Nobel
{
    partial class Okno
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
            this.letoTextBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.podrocjeComboBox = new System.Windows.Forms.ComboBox();
            this.poisciButton = new System.Windows.Forms.Button();
            this.podrocjeLabel = new System.Windows.Forms.Label();
            this.letoLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // letoTextBox
            // 
            this.letoTextBox.Location = new System.Drawing.Point(593, 371);
            this.letoTextBox.Name = "letoTextBox";
            this.letoTextBox.Size = new System.Drawing.Size(121, 23);
            this.letoTextBox.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(385, 489);
            this.textBox.TabIndex = 2;
            // 
            // podrocjeComboBox
            // 
            this.podrocjeComboBox.FormattingEnabled = true;
            this.podrocjeComboBox.Location = new System.Drawing.Point(593, 342);
            this.podrocjeComboBox.Name = "podrocjeComboBox";
            this.podrocjeComboBox.Size = new System.Drawing.Size(121, 23);
            this.podrocjeComboBox.TabIndex = 3;
            // 
            // poisciButton
            // 
            this.poisciButton.BackColor = System.Drawing.Color.White;
            this.poisciButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poisciButton.Location = new System.Drawing.Point(503, 434);
            this.poisciButton.Name = "poisciButton";
            this.poisciButton.Size = new System.Drawing.Size(199, 64);
            this.poisciButton.TabIndex = 4;
            this.poisciButton.Text = "Poišči";
            this.poisciButton.UseVisualStyleBackColor = false;
            this.poisciButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Poisci);
            // 
            // podrocjeLabel
            // 
            this.podrocjeLabel.AutoSize = true;
            this.podrocjeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.podrocjeLabel.ForeColor = System.Drawing.Color.White;
            this.podrocjeLabel.Location = new System.Drawing.Point(470, 338);
            this.podrocjeLabel.Name = "podrocjeLabel";
            this.podrocjeLabel.Size = new System.Drawing.Size(82, 21);
            this.podrocjeLabel.TabIndex = 5;
            this.podrocjeLabel.Text = "Področje:";
            // 
            // letoLabel
            // 
            this.letoLabel.AutoSize = true;
            this.letoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.letoLabel.ForeColor = System.Drawing.Color.White;
            this.letoLabel.Location = new System.Drawing.Point(470, 371);
            this.letoLabel.Name = "letoLabel";
            this.letoLabel.Size = new System.Drawing.Size(47, 21);
            this.letoLabel.TabIndex = 6;
            this.letoLabel.Text = "Leto:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Image = global::Nobel.Properties.Resources.nobel;
            this.pictureBox.Location = new System.Drawing.Point(491, 97);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(223, 215);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(491, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nobelovi nagrajenci";
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.letoLabel);
            this.Controls.Add(this.podrocjeLabel);
            this.Controls.Add(this.poisciButton);
            this.Controls.Add(this.podrocjeComboBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.letoTextBox);
            this.Name = "Okno";
            this.Text = "Nobel";
            this.Load += new System.EventHandler(this.OknoNalozi);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox letoTextBox;
        private TextBox textBox;
        private ComboBox podrocjeComboBox;
        private Button poisciButton;
        private Label podrocjeLabel;
        private Label letoLabel;
        private PictureBox pictureBox;
        private Label label1;
    }
}