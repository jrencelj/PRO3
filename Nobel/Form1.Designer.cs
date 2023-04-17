namespace Nobel
{
    partial class Okno
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.letoLabel = new System.Windows.Forms.Label();
            this.letoTextBox = new System.Windows.Forms.TextBox();
            this.poisciButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.podrocjeLabel = new System.Windows.Forms.Label();
            this.podrocjeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(8, 8);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(301, 304);
            this.textBox.TabIndex = 0;
            // 
            // letoLabel
            // 
            this.letoLabel.AutoSize = true;
            this.letoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letoLabel.ForeColor = System.Drawing.Color.White;
            this.letoLabel.Location = new System.Drawing.Point(327, 232);
            this.letoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.letoLabel.Name = "letoLabel";
            this.letoLabel.Size = new System.Drawing.Size(63, 27);
            this.letoLabel.TabIndex = 1;
            this.letoLabel.Text = "Leto:";
            // 
            // letoTextBox
            // 
            this.letoTextBox.Location = new System.Drawing.Point(433, 239);
            this.letoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.letoTextBox.Name = "letoTextBox";
            this.letoTextBox.Size = new System.Drawing.Size(68, 20);
            this.letoTextBox.TabIndex = 2;
            // 
            // poisciButton
            // 
            this.poisciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poisciButton.Location = new System.Drawing.Point(450, 276);
            this.poisciButton.Margin = new System.Windows.Forms.Padding(2);
            this.poisciButton.Name = "poisciButton";
            this.poisciButton.Size = new System.Drawing.Size(188, 36);
            this.poisciButton.TabIndex = 3;
            this.poisciButton.Text = "Poišči";
            this.poisciButton.UseVisualStyleBackColor = true;
            this.poisciButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Poisci);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Nobel.Properties.Resources.nobel;
            this.pictureBox1.Location = new System.Drawing.Point(450, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // podrocjeLabel
            // 
            this.podrocjeLabel.AutoSize = true;
            this.podrocjeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podrocjeLabel.ForeColor = System.Drawing.Color.White;
            this.podrocjeLabel.Location = new System.Drawing.Point(327, 207);
            this.podrocjeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.podrocjeLabel.Name = "podrocjeLabel";
            this.podrocjeLabel.Size = new System.Drawing.Size(109, 27);
            this.podrocjeLabel.TabIndex = 5;
            this.podrocjeLabel.Text = "Področje:";
            // 
            // podrocjeComboBox
            // 
            this.podrocjeComboBox.FormattingEnabled = true;
            this.podrocjeComboBox.Location = new System.Drawing.Point(432, 213);
            this.podrocjeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.podrocjeComboBox.Name = "podrocjeComboBox";
            this.podrocjeComboBox.Size = new System.Drawing.Size(229, 21);
            this.podrocjeComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nobelovi nagrajenci";
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(696, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.podrocjeComboBox);
            this.Controls.Add(this.podrocjeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.poisciButton);
            this.Controls.Add(this.letoTextBox);
            this.Controls.Add(this.letoLabel);
            this.Controls.Add(this.textBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Okno";
            this.Text = "Nobel";
            this.Load += new System.EventHandler(this.OknoNalozi);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label letoLabel;
        private System.Windows.Forms.TextBox letoTextBox;
        private System.Windows.Forms.Button poisciButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label podrocjeLabel;
        private System.Windows.Forms.ComboBox podrocjeComboBox;
        private System.Windows.Forms.Label label1;
    }
}

