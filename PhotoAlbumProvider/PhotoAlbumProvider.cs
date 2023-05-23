using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LTPhotoAlbumProvider
{
	public class PhotoAlbumProvider
	{
		private static HttpClient client = new HttpClient();

		public static async Task<IList<Photo>> GetPhotoAlbum(int albumId = 0)
		{
			List<Photo> photos = new List<Photo>();

			try
			{
				string url = albumId > 0 ? string.Format("{0}?albumId={1}", Settings.Default.APIUrl, albumId) : Settings.Default.APIUrl;
				using (HttpResponseMessage response = await client.GetAsync(url))
				{
					response.EnsureSuccessStatusCode();
					photos = JsonConvert.DeserializeObject<List<Photo>>(await response.Content.ReadAsStringAsync());
				}
			}
			catch (Exception exc)
			{
				Console.WriteLine(exc.Message);
			}

			return photos;
		}

		public static async Task<Photo> GetPhoto(int id = 0)
		{
			Photo photo = null;

			try
			{
				if (id > 0)
				{
					string url = string.Format(Settings.Default.APIUrl, "?id=", id);
					using (HttpResponseMessage response = await client.GetAsync(url))
					{
						response.EnsureSuccessStatusCode();
						List<Photo> photos = JsonConvert.DeserializeObject<List<Photo>>(await response.Content.ReadAsStringAsync());
						if (photos != null && photos.Count > 0)
							photo = photos.FirstOrDefault();
					}
				}
			}
			catch (Exception exc)
			{
				Console.WriteLine(exc.Message);
			}

			return photo;
		}

		public static void SetHttpMessageHandler(HttpMessageHandler handler)
		{
			if (handler != null)
				client = new HttpClient(handler);
		}
	}
}