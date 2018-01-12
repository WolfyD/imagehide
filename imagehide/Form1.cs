using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
		string[] extensions = new string[] { "bmp", "jpg", "png", "gif", "tif" };
		int maxHeight = 0;
		int maxWidth = 0;
		int numOfImgs = 0;
		int maxMessageLength = 0;
		public string outputFolder = "";

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

			foreach (KeyValuePair<string, Bitmap> kvp in imgs)
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
				foreach (string s in ofd.FileNames)
				{
					addImage(s);
				}
			}

			fillList();
		}

		public void addImage(string s)
		{
			string ext = s.Substring(s.Length - 3);

			if (extensions.Contains(ext.ToLower()))
			{

				if (!imgs.Keys.Contains(s))
				{
					imgs.Add(s, (Bitmap)Image.FromFile(s));
				}
			}
		}

		private void lv_ImagesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lv_ImagesList.FocusedItem != null)
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


			if (lv_ImagesList.SelectedItems != null)
			{
				foreach (ListViewItem l in lv_ImagesList.SelectedItems)
				{
					if (imgs.Keys.Contains(((KeyValuePair<string, Bitmap>)l.Tag).Key))
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

		private void lv_ImagesList_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void lv_ImagesList_DragDrop(object sender, DragEventArgs e)
		{
			foreach (String s in e.Data.GetData(DataFormats.FileDrop) as string[])
			{
				if (Directory.Exists(s))
				{
					foreach (String ss in Directory.GetFiles(s, "*.*", SearchOption.AllDirectories)) { addImage(ss); }
				}
				else if (File.Exists(s))
				{
					addImage(s);
				}
			}

			fillList();
		}

		public KeyValuePair<string, Bitmap> getTag(object o)
		{
			try
			{
				return (KeyValuePair<string, Bitmap>)o;
			}
			catch
			{
				return new KeyValuePair<string, Bitmap>("-", new Bitmap(1, 1));
			}
		}

		public string prettynumber(int i)
		{
			string s = "";
			string ii = i.ToString();

			for (int n = 0; n < ii.Length; n++)
			{
				if(n % 3 == 0 && n != 0) { s = "`" + s; }
				s = s.Insert(0, ii[ii.Length - (n + 1)].ToString());
			}
			
			return s;
		}

		public void checkAvailableSpace()
		{
			maxWidth = 0;
			maxHeight = 0;
			maxMessageLength = 0;
			numOfImgs = lv_ImagesList.CheckedItems.Count;

			foreach(ListViewItem lvi in lv_ImagesList.CheckedItems)
			{
				var k = getTag(lvi.Tag);
				if (k.Key != "-")
				{
					int w = k.Value.Width;
					int h = k.Value.Height;

					w = w - 2;
					if(w > 1000) { w = 1000; }

					h = h - 2;
					if(h > 1000) { h = 1000; }

					maxWidth += w;
					maxHeight += h;

					maxMessageLength += maxWidth * maxHeight;
				}
			}
			string mml = maxMessageLength.ToString();
			try
			{
				mml = prettynumber(maxMessageLength);
			}
			catch { }
			lbl_ImageInfo.Text = "Selected images: " + numOfImgs + " | Max message length: " + mml + " characters (" + ")";
		}

		private void btn_Check_Click(object sender, EventArgs e)
		{
			checkAvailableSpace();
		}

		public static byte[] ImageToByte(Image img)
		{
			using (var stream = new MemoryStream())
			{
				img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
				return stream.ToArray();
			}
		}

		private void btn_HideData_Click(object sender, EventArgs e)
		{
			outputFolder = tb_OutputFolder1.Text;
			if(outputFolder != "" && Directory.Exists(outputFolder))
			{
				/*TEST*/
				int i = 0;
				foreach(ListViewItem v in lv_ImagesList.CheckedItems)
				{
					var tag = getTag(v.Tag);
					string fn = v.SubItems[1].Text;
					fn = fn.Substring(0, fn.LastIndexOf("."));

					string path = outputFolder + "\\" + i.ToString().PadLeft(2, '0') + "_" + fn + ".png";

					File.WriteAllBytes(path, ImageToByte(tag.Value));
					//tag.Value.Save(outputFolder + "\\" + i + "_" + fn + ".png", System.Drawing.Imaging.ImageFormat.Png);
					i++;
				}
			}
		}

		private void btn_BrowseOutput1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				tb_OutputFolder1.Text = fbd.SelectedPath;
			}
		}
	}
}
