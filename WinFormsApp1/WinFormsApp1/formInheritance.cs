﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class formInheritance : Form
	{
		private Form1 login;
		private calculator calc;
		private register register1;
		public formInheritance()
		{
			InitializeComponent();
		}

		private int CountOpenForms()
		{
			int openForms = 0;
			foreach (Form form in Application.OpenForms)
			{
				if (form.Visible)
				{
					openForms++;
				}
			}
			return openForms;
		}

		private void OpenNewForm(Form newForm, int a)
		{
			if (CountOpenForms() > 1)
			{
				MessageBox.Show("Only 2 forms can be opened at the same time.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				if (a == 1)
				{
					calc = new calculator();
					calc.ShowDialog();
				}
				else if (a == 2)
				{
					register1 = new register();
					register1.ShowDialog();
				}
				else
				{
					login = new Form1();
					login.ShowDialog();
				}
				
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form newForm = new formInheritance();
			OpenNewForm(newForm, 1);
		}

		private void formInheritance_Load(object sender, EventArgs e)
		{
			timer1.Interval = 1000;
			timer1.Start();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form newForm = new formInheritance();
			OpenNewForm(newForm,2);
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form newForm = new formInheritance();
			OpenNewForm(newForm,3);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label2.Text = DateTime.Now.ToString("HH:mm:ss");
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
