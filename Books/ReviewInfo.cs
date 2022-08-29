using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace CodeHelper.API.NYTimes.Books
{
    public class ReviewInfo
    {

        #region Properties
        [JsonPropertyName("url")]           public string Url { get; set; }
        [JsonPropertyName("publication_dt")]public string PublicationDt { get; set; }
        [JsonPropertyName("byline")]        public string Byline { get; set; }
        [JsonPropertyName("book_title")]    public string BookTitle { get; set; }
        [JsonPropertyName("book_author")]   public string BookAuthor { get; set; }
        [JsonPropertyName("summary")]       public string Summary { get; set; }
        [JsonPropertyName("uuid")]          public string Uuid { get; set; }
        [JsonPropertyName("uri")]           public string Uri { get; set; }
        [JsonPropertyName("isbn13")]        public List<string> Isbn13 { get; set; } = new();
        #endregion

        #region Constructors
        public ReviewInfo() { }
        #endregion
    }
}
