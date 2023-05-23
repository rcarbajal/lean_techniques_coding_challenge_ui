using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTPhotoAlbumProvider;

namespace PhotoAlbum
{
	public partial class PhotoAlbum : Form
	{
		public PhotoAlbum()
		{
			InitializeComponent();
		}

		private async void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				if (int.TryParse(txtSearch.Text, out int albumId))
				{
					var photos = (List<Photo>) await PhotoAlbumProvider.GetPhotoAlbum(albumId);
					Console.WriteLine(photos.Count);
				}
			}
			catch (Exception exc)
			{
				Console.WriteLine(exc.Message);
			}
		}
	}
}
