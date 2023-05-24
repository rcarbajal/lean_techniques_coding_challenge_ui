using LTPhotoAlbumProvider;
using System;
using System.Collections.Generic;

namespace PhotoAlbumConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				while (true)
				{
					Console.WriteLine("Please enter an album ID: ");
					string albumIdStr = Console.ReadLine();

					if (int.TryParse(albumIdStr, out int albumId) && albumId > 0)
					{
						var photos = (List<Photo>) PhotoAlbumProvider.GetPhotoAlbum(albumId).Result;
						if (photos.Count > 0)
						{
							foreach (var photo in photos)
							{
								Console.WriteLine("[{0}] {1}", photo.Id, photo.Title);
							}

							Console.WriteLine();
							Console.WriteLine("Records found: {0}", photos.Count);
							Console.WriteLine();
						}
						else
						{
							Console.WriteLine("Records found: 0");
							Console.WriteLine();
						}
					}
					else
					{
						Console.WriteLine("Please enter a valid integer ID greater than zero");
						Console.WriteLine();
					}

					string answer = string.Empty;
					while (true)
					{
						Console.WriteLine("Search for another album ID (y/n)?");
						answer = Console.ReadLine();

						if (!string.IsNullOrEmpty(answer))
						{
							answer = answer.ToLower();
							if (answer == "y" || answer == "n") break;
						}
					}
					if (answer == "n") break;
				}
			}
			catch (Exception exc)
			{
				Console.WriteLine(exc.Message);
			}
		}
	}
}
