using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int dakika = 0, saniye = 1, salise = 1;

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (saniye == 60)
			{
				saniye = 0;
			}
			saniye++;
			label2.Text = saniye.ToString();
			
			

		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			if (salise == 100)
			{
				salise = 0;
			}
			salise++;
			label3.Text = salise.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Start();timer2.Start();timer3.Start();
		}

		private void timer4_Tick(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Stop();timer2.Stop();timer3.Stop();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			dakika++;
			label1.Text = dakika.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Text = "0"; label2.Text = "0"; label3.Text = "0";
		}
	}
}
