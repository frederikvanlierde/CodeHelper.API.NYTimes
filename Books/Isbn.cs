using System.Text.Json.Serialization;


namespace CodeHelper.API.NYTimes.Books
{
    public class Isbn
    {

        #region Properties
        [JsonPropertyName("isbn10")]    public string Isbn10 { get; set; } = "";
        [JsonPropertyName("isbn13")]    public string Isbn13 { get; set; } = "";
        #endregion
        #region Constructors
        public Isbn() { }
        #endregion
    }
}
