using LTPhotoAlbumProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace PhotoAlbum
{
	public partial class PhotoAlbum : Form
	{
		public PhotoAlbum()
		{
			InitializeComponent();
			picPhoto.LoadCompleted += PicPhoto_LoadCompleted;
		}

		private async void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				lblMessage.Visible = false;
				picPhoto.Visible = false;
				lblTitle.Visible = false;
				grpResults.Visible = false;
				dgvPhotos.Rows.Clear();

				if (int.TryParse(txtSearch.Text, out int albumId) && albumId > 0)
				{
					var photos = (List<Photo>) await PhotoAlbumProvider.GetPhotoAlbum(albumId);
					if (photos.Count > 0)
					{
						foreach (Photo photo in photos)
							dgvPhotos.Rows.Add(photo.Id, photo.Title, photo.URL);
					}

					lblRecordCount.Text = string.Format("Records found: {0}", photos.Count);
					grpResults.Visible = true;
				}
				else
				{
					lblMessage.Text = "Please enter a valid integer ID greater than zero";
					lblMessage.Visible = true;
				}
			}
			catch (Exception exc)
			{
				lblMessage.Text = exc.Message;
				lblMessage.Visible = true;
			}
		}

		private void dgvPhotos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var dgv = sender as DataGridView;
			dgv.Enabled = false;

			try
			{
				lblMessage.Visible = false;
				var row = dgvPhotos.CurrentRow;

				if (Uri.TryCreate(row.Cells[2].Value.ToString(), UriKind.Absolute, out Uri photoUri)
					&& (photoUri.Scheme == Uri.UriSchemeHttp || photoUri.Scheme == Uri.UriSchemeHttps))
				{
					picPhoto.LoadAsync(photoUri.ToString());
					picPhoto.Visible = true;
					lblTitle.Text = row.Cells[1].Value.ToString();
					lblTitle.Visible = true;
				}
				else
					dgv.Enabled = true;
			}
			catch (Exception exc)
			{
				lblMessage.Text = exc.Message;
				lblMessage.Visible = true;
				dgv.Enabled = true;
			}
		}

		private void PicPhoto_LoadCompleted(object sender, AsyncCompletedEventArgs e)
		{
			dgvPhotos.Enabled = true;
		}
	}
}
