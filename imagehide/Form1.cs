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
		//List<Bitmap> imgs = new List<Bitmap>();
		Dictionary<string, Bitmap> imgs = new Dictionary<string, Bitmap>();
		OpenFileDialog ofd = new OpenFileDialog();

		public Form1()
		{
			InitializeComponent();
			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		public void fillList()
		{
			lv_ImagesList.Items.Clear();

			foreach(KeyValuePair<string,Bitmap> kvp in imgs)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = (lv_ImagesList.Items.Count + 1) + "";
				lvi.SubItems.Add(kvp.Key.Substring(kvp.Key.LastIndexOf("\\") + 1));
				lvi.SubItems.Add(kvp.Value.Width.ToString().PadRight(4, ' ') + " x " + kvp.Value.Height.ToString().PadRight(4, ' '));

				lvi.Tag = kvp;

				lv_ImagesList.Items.Add(lvi);
			}

			ch_Index.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
			ch_ImageName.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
			ch_Dimentions.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private void btn_OpenImage_Click(object sender, EventArgs e)
		{
			ofd.Multiselect = true;
			ofd.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
			ofd.Title = "Open Images";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				foreach(string s in ofd.FileNames)
				{
					if (!imgs.Keys.Contains(s))
					{
						imgs.Add(s, (Bitmap)Image.FromFile(s));
					}
				}
			}

			fillList();
		}

		private void lv_ImagesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lv_ImagesList.FocusedItem != null)
			{
				try
				{
					pb_Picture.Image = ((KeyValuePair<string, Bitmap>)lv_ImagesList.FocusedItem.Tag).Value;
				}
				catch { }
			}
		}

		private void btn_RemoveImage_Click(object sender, EventArgs e)
		{
			

			if(lv_ImagesList.SelectedItems != null)
			{
				foreach(ListViewItem l in lv_ImagesList.SelectedItems)
				{
					if(imgs.Keys.Contains(((KeyValuePair<string, Bitmap>)l.Tag).Key))
					{
						imgs[((KeyValuePair<string, Bitmap>)l.Tag).Key].Dispose();
					}

					l.Tag = null;
					lv_ImagesList.Items.Remove(l);
				}
				
				GC.Collect();
			}

			pb_Picture.Image = new Bitmap(1, 1);
		}
	}
}
