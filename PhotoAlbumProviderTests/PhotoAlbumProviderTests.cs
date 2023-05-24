using Moq.Protected;
using System.Net;

namespace PhotoAlbumProviderTests
{
	public class PhotoAlbumProviderTests
	{
		private readonly Mock<HttpMessageHandler> _msgHandler;
		private readonly Photo photo = new()
		{
			Id = 1,
			AlbumID = 1,
			Title = "accusamus beatae ad facilis cum similique qui sunt",
			URL = "https://via.placeholder.com/600/92c952",
			ThumbnailURL = "https://via.placeholder.com/150/92c952"
		};
		private readonly string albumJSON = @"
			[
				{
					albumId: 1,
					id: 1,
					title: ""accusamus beatae ad facilis cum similique qui sunt"",
					url: ""https://via.placeholder.com/600/92c952"",
					thumbnailUrl: ""https://via.placeholder.com/150/92c952""
				}
			]";

		public PhotoAlbumProviderTests()
		{
			_msgHandler = new Mock<HttpMessageHandler>();
			_msgHandler
				.Protected()
				.Setup<Task<HttpResponseMessage>>(
					"SendAsync",
					ItExpr.IsAny<HttpRequestMessage>(),
					ItExpr.IsAny<CancellationToken>())
				.ReturnsAsync(new HttpResponseMessage
				{
					StatusCode = HttpStatusCode.OK,
					Content = new StringContent(albumJSON)
				});

			PhotoAlbumProvider.SetHttpMessageHandler(_msgHandler.Object);
		}

		[Fact]
		public async void ShouldGetPhotoAlbum()
		{
			List<Photo>? photos = (List<Photo>?)await PhotoAlbumProvider.GetPhotoAlbum();

			if (photos != null && photos.Count > 0)
			{
				var p = photos[0];
				Assert.Equal(photo.Id, p.Id);
				Assert.Equal(photo.AlbumID, p.AlbumID);
				Assert.Equal(photo.Title, p.Title);
				Assert.Equal(photo.URL, p.URL);
				Assert.Equal(photo.ThumbnailURL, p.ThumbnailURL);
			}
			else
				Assert.Fail("Photos should not be empty");
		}

		[Fact]
		public async void ShouldGetPhoto()
		{
			Photo? p = await PhotoAlbumProvider.GetPhoto(photo.Id);

			if (p != null)
			{
				Assert.Equal(photo.Id, p.Id);
				Assert.Equal(photo.AlbumID, p.AlbumID);
				Assert.Equal(photo.Title, p.Title);
				Assert.Equal(photo.URL, p.URL);
				Assert.Equal(photo.ThumbnailURL, p.ThumbnailURL);
			}
			else
				Assert.Fail("Photo should not be null");
		}
	}
}