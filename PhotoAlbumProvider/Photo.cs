using Newtonsoft.Json;

namespace LTPhotoAlbumProvider
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class Photo
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("albumId")]
		public int AlbumID { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; } = string.Empty;

		[JsonProperty("url")]
		public string URL { get; set; } = string.Empty;

		[JsonProperty("thumbnailUrl")]
		public string ThumbnailURL { get; set; } = string.Empty;
	}
}
