using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class register : formInheritance
	{
		public register()
		{
			InitializeComponent();
		}

		private void register_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox2.Items.Clear();
			if (comboBox1.SelectedItem != null)
			{

				switch (comboBox1.SelectedItem.ToString())
				{
					case "Province No. 1":
						comboBox2.Items.AddRange(new string[]
						{   "Bhojpur",
							"Dhankuta",
							"Ilam",
							"Jhapa",
							"Khotang",
							"Morang",
							"Okhaldhunga",
							"Panchthar",
							"Sankhuwasabha",
							"Solukhumbu",
							"Sunsari",
							"Taplejung",
							"Terhathum",
							"Udayapur"
						});
						break;
					case "Madhesh Province":
						comboBox2.Items.AddRange(new string[] {"Bara",
						"Dhanusha",
						"Mahottari",
						"Parsa",
						"Rautahat",
						"Saptari",
						"Sarlahi",
						"Siraha"});
						break;
					case "Bagmati Province":
						comboBox2.Items.AddRange(new string[] {"Bhaktapur",
						"Chitwan",
						"Dhading",
						"Dolakha",
						"Kathmandu",
						"Kavrepalanchok",
						"Lalitpur",
						"Makwanpur",
						"Nuwakot",
						"Ramechhap",
						"Rasuwa",
						"Sindhuli",
						"Sindhupalchok"});
						break;
					case "Gandaki Province":
						comboBox2.Items.AddRange(new string[] {"Baglung",
						"Gorkha",
						"Kaski",
						"Lamjung",
						"Manang",
						"Mustang",
						"Myagdi",
						"Nawalpur",
						"Parbat",
						"Syangja",
						"Tanahun"});
						break;
					case "Lumbini Province":
						comboBox2.Items.AddRange(new string[] {"Arghakhanchi",
						"Banke",
						"Bardiya",
						"Dang",
						"Gulmi",
						"Kapilvastu",
						"Nawalparasi (West of Bardaghat Susta)",
						"Palpa",
						"Pyuthan",
						"Rolpa",
						"Rupandehi"});
						break;
					case "Karnali Province":
						comboBox2.Items.AddRange(new string[] {"Dailekh",
						"Dolpa",
						"Humla",
						"Jajarkot",
						"Jumla",
						"Kalikot",
						"Mugu",
						"Rukum (East)",
						"Salyan",
						"Surkhet"});
						break;
					case "Sudurpashchim Province":
						comboBox2.Items.AddRange(new string[] {"Achham",
						"Baitadi",
						"Bajhang",
						"Bajura",
						"Dadeldhura",
						"Darchula",
						"Doti",
						"Kailali",
						"Kanchanpur"});
						break;

				}
			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
