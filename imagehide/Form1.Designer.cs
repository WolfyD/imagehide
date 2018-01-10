namespace imagehide
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.tc_Tabs_Main = new System.Windows.Forms.TabControl();
			this.tp_Encode = new System.Windows.Forms.TabPage();
			this.tp_Decode = new System.Windows.Forms.TabPage();
			this.btn_OpenImage = new System.Windows.Forms.Button();
			this.lv_ImagesList = new System.Windows.Forms.ListView();
			this.ch_Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_ImageName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Dimentions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gb_Images = new System.Windows.Forms.GroupBox();
			this.btn_RemoveImage = new System.Windows.Forms.Button();
			this.pb_Picture = new System.Windows.Forms.PictureBox();
			this.tc_Tabs_Data = new System.Windows.Forms.TabControl();
			this.tp_Datatype_Text = new System.Windows.Forms.TabPage();
			this.tp_Datatype_Binary = new System.Windows.Forms.TabPage();
			this.btn_HideData = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_OutputFolder1 = new System.Windows.Forms.TextBox();
			this.btn_BrowseOutput1 = new System.Windows.Forms.Button();
			this.tp_Datatype_Morse = new System.Windows.Forms.TabPage();
			this.tp_Datatype_BinaryText = new System.Windows.Forms.TabPage();
			this.rtb_DataText = new System.Windows.Forms.RichTextBox();
			this.btn_BrowseDataText = new System.Windows.Forms.Button();
			this.tc_Tabs_Main.SuspendLayout();
			this.tp_Encode.SuspendLayout();
			this.gb_Images.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).BeginInit();
			this.tc_Tabs_Data.SuspendLayout();
			this.tp_Datatype_Text.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 505);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(457, 32);
			this.panel1.TabIndex = 0;
			// 
			// tc_Tabs_Main
			// 
			this.tc_Tabs_Main.Controls.Add(this.tp_Encode);
			this.tc_Tabs_Main.Controls.Add(this.tp_Decode);
			this.tc_Tabs_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tc_Tabs_Main.Location = new System.Drawing.Point(0, 0);
			this.tc_Tabs_Main.Name = "tc_Tabs_Main";
			this.tc_Tabs_Main.SelectedIndex = 0;
			this.tc_Tabs_Main.Size = new System.Drawing.Size(457, 505);
			this.tc_Tabs_Main.TabIndex = 1;
			// 
			// tp_Encode
			// 
			this.tp_Encode.Controls.Add(this.btn_BrowseOutput1);
			this.tp_Encode.Controls.Add(this.tb_OutputFolder1);
			this.tp_Encode.Controls.Add(this.label1);
			this.tp_Encode.Controls.Add(this.btn_HideData);
			this.tp_Encode.Controls.Add(this.tc_Tabs_Data);
			this.tp_Encode.Controls.Add(this.gb_Images);
			this.tp_Encode.Location = new System.Drawing.Point(4, 22);
			this.tp_Encode.Name = "tp_Encode";
			this.tp_Encode.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Encode.Size = new System.Drawing.Size(449, 479);
			this.tp_Encode.TabIndex = 0;
			this.tp_Encode.Text = "Encode";
			this.tp_Encode.UseVisualStyleBackColor = true;
			// 
			// tp_Decode
			// 
			this.tp_Decode.Location = new System.Drawing.Point(4, 22);
			this.tp_Decode.Name = "tp_Decode";
			this.tp_Decode.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Decode.Size = new System.Drawing.Size(449, 388);
			this.tp_Decode.TabIndex = 1;
			this.tp_Decode.Text = "Decode";
			this.tp_Decode.UseVisualStyleBackColor = true;
			// 
			// btn_OpenImage
			// 
			this.btn_OpenImage.Location = new System.Drawing.Point(6, 19);
			this.btn_OpenImage.Name = "btn_OpenImage";
			this.btn_OpenImage.Size = new System.Drawing.Size(106, 23);
			this.btn_OpenImage.TabIndex = 0;
			this.btn_OpenImage.Text = "Open Image(s)";
			this.btn_OpenImage.UseVisualStyleBackColor = true;
			this.btn_OpenImage.Click += new System.EventHandler(this.btn_OpenImage_Click);
			// 
			// lv_ImagesList
			// 
			this.lv_ImagesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_ImagesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Index,
            this.ch_ImageName,
            this.ch_Dimentions});
			this.lv_ImagesList.Location = new System.Drawing.Point(6, 48);
			this.lv_ImagesList.Name = "lv_ImagesList";
			this.lv_ImagesList.Size = new System.Drawing.Size(238, 190);
			this.lv_ImagesList.TabIndex = 1;
			this.lv_ImagesList.UseCompatibleStateImageBehavior = false;
			this.lv_ImagesList.View = System.Windows.Forms.View.Details;
			// 
			// ch_Index
			// 
			this.ch_Index.Text = "#";
			this.ch_Index.Width = 29;
			// 
			// ch_ImageName
			// 
			this.ch_ImageName.Text = "Image";
			this.ch_ImageName.Width = 124;
			// 
			// ch_Dimentions
			// 
			this.ch_Dimentions.Text = "Dimentions";
			this.ch_Dimentions.Width = 76;
			// 
			// gb_Images
			// 
			this.gb_Images.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_Images.Controls.Add(this.pb_Picture);
			this.gb_Images.Controls.Add(this.btn_RemoveImage);
			this.gb_Images.Controls.Add(this.btn_OpenImage);
			this.gb_Images.Controls.Add(this.lv_ImagesList);
			this.gb_Images.Location = new System.Drawing.Point(8, 6);
			this.gb_Images.Name = "gb_Images";
			this.gb_Images.Size = new System.Drawing.Size(438, 248);
			this.gb_Images.TabIndex = 2;
			this.gb_Images.TabStop = false;
			this.gb_Images.Text = "Images";
			// 
			// btn_RemoveImage
			// 
			this.btn_RemoveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RemoveImage.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_RemoveImage.Location = new System.Drawing.Point(210, 20);
			this.btn_RemoveImage.Name = "btn_RemoveImage";
			this.btn_RemoveImage.Size = new System.Drawing.Size(34, 23);
			this.btn_RemoveImage.TabIndex = 2;
			this.btn_RemoveImage.Text = "(-)";
			this.btn_RemoveImage.UseVisualStyleBackColor = true;
			// 
			// pb_Picture
			// 
			this.pb_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pb_Picture.BackColor = System.Drawing.Color.DimGray;
			this.pb_Picture.Location = new System.Drawing.Point(250, 48);
			this.pb_Picture.Name = "pb_Picture";
			this.pb_Picture.Size = new System.Drawing.Size(182, 190);
			this.pb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_Picture.TabIndex = 3;
			this.pb_Picture.TabStop = false;
			// 
			// tc_Tabs_Data
			// 
			this.tc_Tabs_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tc_Tabs_Data.Controls.Add(this.tp_Datatype_Text);
			this.tc_Tabs_Data.Controls.Add(this.tp_Datatype_Binary);
			this.tc_Tabs_Data.Controls.Add(this.tp_Datatype_Morse);
			this.tc_Tabs_Data.Controls.Add(this.tp_Datatype_BinaryText);
			this.tc_Tabs_Data.Location = new System.Drawing.Point(8, 260);
			this.tc_Tabs_Data.Name = "tc_Tabs_Data";
			this.tc_Tabs_Data.SelectedIndex = 0;
			this.tc_Tabs_Data.Size = new System.Drawing.Size(438, 142);
			this.tc_Tabs_Data.TabIndex = 3;
			// 
			// tp_Datatype_Text
			// 
			this.tp_Datatype_Text.Controls.Add(this.btn_BrowseDataText);
			this.tp_Datatype_Text.Controls.Add(this.rtb_DataText);
			this.tp_Datatype_Text.Location = new System.Drawing.Point(4, 22);
			this.tp_Datatype_Text.Name = "tp_Datatype_Text";
			this.tp_Datatype_Text.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Datatype_Text.Size = new System.Drawing.Size(430, 116);
			this.tp_Datatype_Text.TabIndex = 0;
			this.tp_Datatype_Text.Text = "Text";
			this.tp_Datatype_Text.UseVisualStyleBackColor = true;
			// 
			// tp_Datatype_Binary
			// 
			this.tp_Datatype_Binary.Location = new System.Drawing.Point(4, 22);
			this.tp_Datatype_Binary.Name = "tp_Datatype_Binary";
			this.tp_Datatype_Binary.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Datatype_Binary.Size = new System.Drawing.Size(430, 116);
			this.tp_Datatype_Binary.TabIndex = 1;
			this.tp_Datatype_Binary.Text = "Binary";
			this.tp_Datatype_Binary.UseVisualStyleBackColor = true;
			// 
			// btn_HideData
			// 
			this.btn_HideData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_HideData.Location = new System.Drawing.Point(367, 450);
			this.btn_HideData.Name = "btn_HideData";
			this.btn_HideData.Size = new System.Drawing.Size(75, 23);
			this.btn_HideData.TabIndex = 4;
			this.btn_HideData.Text = "Hide Data";
			this.btn_HideData.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 416);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Output Folder: ";
			// 
			// tb_OutputFolder1
			// 
			this.tb_OutputFolder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_OutputFolder1.Location = new System.Drawing.Point(85, 413);
			this.tb_OutputFolder1.Name = "tb_OutputFolder1";
			this.tb_OutputFolder1.Size = new System.Drawing.Size(324, 20);
			this.tb_OutputFolder1.TabIndex = 6;
			// 
			// btn_BrowseOutput1
			// 
			this.btn_BrowseOutput1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_BrowseOutput1.Location = new System.Drawing.Point(410, 411);
			this.btn_BrowseOutput1.Name = "btn_BrowseOutput1";
			this.btn_BrowseOutput1.Size = new System.Drawing.Size(32, 23);
			this.btn_BrowseOutput1.TabIndex = 7;
			this.btn_BrowseOutput1.Text = "[B]";
			this.btn_BrowseOutput1.UseVisualStyleBackColor = true;
			// 
			// tp_Datatype_Morse
			// 
			this.tp_Datatype_Morse.Location = new System.Drawing.Point(4, 22);
			this.tp_Datatype_Morse.Name = "tp_Datatype_Morse";
			this.tp_Datatype_Morse.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Datatype_Morse.Size = new System.Drawing.Size(430, 116);
			this.tp_Datatype_Morse.TabIndex = 2;
			this.tp_Datatype_Morse.Text = "Morse";
			this.tp_Datatype_Morse.UseVisualStyleBackColor = true;
			// 
			// tp_Datatype_BinaryText
			// 
			this.tp_Datatype_BinaryText.Location = new System.Drawing.Point(4, 22);
			this.tp_Datatype_BinaryText.Name = "tp_Datatype_BinaryText";
			this.tp_Datatype_BinaryText.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Datatype_BinaryText.Size = new System.Drawing.Size(430, 116);
			this.tp_Datatype_BinaryText.TabIndex = 3;
			this.tp_Datatype_BinaryText.Text = "Binary Text";
			this.tp_Datatype_BinaryText.UseVisualStyleBackColor = true;
			// 
			// rtb_DataText
			// 
			this.rtb_DataText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtb_DataText.Location = new System.Drawing.Point(6, 6);
			this.rtb_DataText.Name = "rtb_DataText";
			this.rtb_DataText.Size = new System.Drawing.Size(391, 104);
			this.rtb_DataText.TabIndex = 0;
			this.rtb_DataText.Text = "";
			// 
			// btn_BrowseDataText
			// 
			this.btn_BrowseDataText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_BrowseDataText.Location = new System.Drawing.Point(401, 6);
			this.btn_BrowseDataText.Name = "btn_BrowseDataText";
			this.btn_BrowseDataText.Size = new System.Drawing.Size(23, 104);
			this.btn_BrowseDataText.TabIndex = 1;
			this.btn_BrowseDataText.Text = "BROWSE";
			this.btn_BrowseDataText.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 537);
			this.Controls.Add(this.tc_Tabs_Main);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tc_Tabs_Main.ResumeLayout(false);
			this.tp_Encode.ResumeLayout(false);
			this.tp_Encode.PerformLayout();
			this.gb_Images.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pb_Picture)).EndInit();
			this.tc_Tabs_Data.ResumeLayout(false);
			this.tp_Datatype_Text.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tc_Tabs_Main;
		private System.Windows.Forms.TabPage tp_Encode;
		private System.Windows.Forms.TabPage tp_Decode;
		private System.Windows.Forms.Button btn_OpenImage;
		private System.Windows.Forms.GroupBox gb_Images;
		private System.Windows.Forms.Button btn_RemoveImage;
		private System.Windows.Forms.ListView lv_ImagesList;
		private System.Windows.Forms.ColumnHeader ch_Index;
		private System.Windows.Forms.ColumnHeader ch_ImageName;
		private System.Windows.Forms.ColumnHeader ch_Dimentions;
		private System.Windows.Forms.PictureBox pb_Picture;
		private System.Windows.Forms.Button btn_HideData;
		private System.Windows.Forms.TabControl tc_Tabs_Data;
		private System.Windows.Forms.TabPage tp_Datatype_Text;
		private System.Windows.Forms.TabPage tp_Datatype_Binary;
		private System.Windows.Forms.Button btn_BrowseOutput1;
		private System.Windows.Forms.TextBox tb_OutputFolder1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tp_Datatype_Morse;
		private System.Windows.Forms.TabPage tp_Datatype_BinaryText;
		private System.Windows.Forms.Button btn_BrowseDataText;
		private System.Windows.Forms.RichTextBox rtb_DataText;
	}
}

