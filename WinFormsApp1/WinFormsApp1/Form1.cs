namespace WinFormsApp1
{
	public partial class Form1 : formInheritance
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "admin" && textBox2.Text == "dipen")
			{
				MessageBox.Show("Login Successful");
			}
			else
			{
				MessageBox.Show("Login Failed");
			}
		}
	}
}
