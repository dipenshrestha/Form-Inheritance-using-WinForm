namespace WinFormsApp1
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label3 = new Label();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Showcard Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Yellow;
			label1.Location = new Point(420, 114);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(286, 52);
			label1.TabIndex = 0;
			label1.Text = "Login Panel";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.ForeColor = SystemColors.ButtonHighlight;
			label2.Location = new Point(436, 281);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(107, 21);
			label2.TabIndex = 1;
			label2.Text = "Username:";
			label2.Click += label2_Click;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox1.Location = new Point(663, 278);
			textBox1.Margin = new Padding(2, 3, 2, 2);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "username";
			textBox1.Size = new Size(255, 31);
			textBox1.TabIndex = 2;
			textBox1.TextAlign = HorizontalAlignment.Center;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox2.Location = new Point(663, 348);
			textBox2.Margin = new Padding(2, 3, 2, 2);
			textBox2.Name = "textBox2";
			textBox2.PlaceholderText = "password";
			textBox2.Size = new Size(255, 31);
			textBox2.TabIndex = 3;
			textBox2.TextAlign = HorizontalAlignment.Center;
			textBox2.UseSystemPasswordChar = true;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.ForeColor = SystemColors.ButtonHighlight;
			label3.Location = new Point(440, 351);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(102, 21);
			label3.TabIndex = 4;
			label3.Text = "Password:";
			label3.Click += label3_Click;
			// 
			// button1
			// 
			button1.Location = new Point(0, 0);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			// 
			// button2
			// 
			button2.BackColor = Color.ForestGreen;
			button2.FlatAppearance.BorderColor = Color.Green;
			button2.FlatStyle = FlatStyle.Flat;
			button2.ForeColor = SystemColors.ButtonHighlight;
			button2.Location = new Point(597, 379);
			button2.Margin = new Padding(2);
			button2.Name = "button2";
			button2.Padding = new Padding(5);
			button2.Size = new Size(205, 44);
			button2.TabIndex = 5;
			button2.Text = "Login";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(12F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = Color.CornflowerBlue;
			ClientSize = new Size(1045, 517);
			Controls.Add(label3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ForeColor = SystemColors.ButtonShadow;
			Margin = new Padding(4, 3, 4, 3);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			Controls.SetChildIndex(label2, 0);
			Controls.SetChildIndex(textBox1, 0);
			Controls.SetChildIndex(textBox2, 0);
			Controls.SetChildIndex(label3, 0);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
		private Button button2;
	}
}
