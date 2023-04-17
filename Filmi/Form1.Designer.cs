namespace filmi
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reziser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letoTextBox = new System.Windows.Forms.TextBox();
            this.letoLabel = new System.Windows.Forms.Label();
            this.poisciButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.naslov,
            this.leto,
            this.reziser});
            this.dataGridView.Location = new System.Drawing.Point(264, 42);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(666, 305);
            this.dataGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // naslov
            // 
            this.naslov.HeaderText = "Naslov";
            this.naslov.MinimumWidth = 8;
            this.naslov.Name = "naslov";
            this.naslov.Width = 150;
            // 
            // leto
            // 
            this.leto.HeaderText = "Leto";
            this.leto.MinimumWidth = 8;
            this.leto.Name = "leto";
            this.leto.Width = 150;
            // 
            // reziser
            // 
            this.reziser.HeaderText = "Režiser";
            this.reziser.MinimumWidth = 8;
            this.reziser.Name = "reziser";
            this.reziser.Width = 150;
            // 
            // letoTextBox
            // 
            this.letoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letoTextBox.Location = new System.Drawing.Point(540, 425);
            this.letoTextBox.Name = "letoTextBox";
            this.letoTextBox.Size = new System.Drawing.Size(100, 44);
            this.letoTextBox.TabIndex = 1;
            // 
            // letoLabel
            // 
            this.letoLabel.AutoSize = true;
            this.letoLabel.BackColor = System.Drawing.Color.Transparent;
            this.letoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letoLabel.ForeColor = System.Drawing.Color.White;
            this.letoLabel.Location = new System.Drawing.Point(420, 431);
            this.letoLabel.Name = "letoLabel";
            this.letoLabel.Size = new System.Drawing.Size(83, 32);
            this.letoLabel.TabIndex = 2;
            this.letoLabel.Text = "Leto:";
            // 
            // poisciButton
            // 
            this.poisciButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.poisciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poisciButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.poisciButton.Location = new System.Drawing.Point(684, 421);
            this.poisciButton.Name = "poisciButton";
            this.poisciButton.Size = new System.Drawing.Size(106, 48);
            this.poisciButton.TabIndex = 3;
            this.poisciButton.Text = "Poišči";
            this.poisciButton.UseVisualStyleBackColor = false;
            this.poisciButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Poisci);
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::filmi.Properties.Resources.slikaFilmi1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 562);
            this.Controls.Add(this.poisciButton);
            this.Controls.Add(this.letoLabel);
            this.Controls.Add(this.letoTextBox);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Okno";
            this.Text = "Filmi";
            this.Load += new System.EventHandler(this.OknoNalozi);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn leto;
        private System.Windows.Forms.DataGridViewTextBoxColumn reziser;
        private System.Windows.Forms.TextBox letoTextBox;
        private System.Windows.Forms.Label letoLabel;
        private System.Windows.Forms.Button poisciButton;
    }
}

