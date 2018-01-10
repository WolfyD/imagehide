using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagehide
{
	public partial class Form1 : Form
	{
		List<Bitmap> imgs = new List<Bitmap>();

		OpenFileDialog ofd = new OpenFileDialog();

		public Form1()
		{
			InitializeComponent();
		}

		private void btn_OpenImage_Click(object sender, EventArgs e)
		{
			if(ofd.ShowDialog() == DialogResult.OK)
			{

			}
		}
	}
}
