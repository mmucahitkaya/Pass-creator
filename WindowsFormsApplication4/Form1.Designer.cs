namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.NewPassLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.GenPassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPassLabel
            // 
            this.NewPassLabel.AutoSize = true;
            this.NewPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewPassLabel.Location = new System.Drawing.Point(52, 32);
            this.NewPassLabel.Name = "NewPassLabel";
            this.NewPassLabel.Size = new System.Drawing.Size(188, 25);
            this.NewPassLabel.TabIndex = 0;
            this.NewPassLabel.Text = "Your New Password";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(57, 60);
            this.PassBox.Multiline = true;
            this.PassBox.Name = "PassBox";
            this.PassBox.ReadOnly = true;
            this.PassBox.Size = new System.Drawing.Size(183, 40);
            this.PassBox.TabIndex = 1;
            this.PassBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GenPassButton
            // 
            this.GenPassButton.Location = new System.Drawing.Point(110, 106);
            this.GenPassButton.Name = "GenPassButton";
            this.GenPassButton.Size = new System.Drawing.Size(75, 23);
            this.GenPassButton.TabIndex = 2;
            this.GenPassButton.Text = "Generate Password";
            this.GenPassButton.UseVisualStyleBackColor = true;
            this.GenPassButton.Click += new System.EventHandler(this.GenPassButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.GenPassButton);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.NewPassLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewPassLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button GenPassButton;
    }
}

