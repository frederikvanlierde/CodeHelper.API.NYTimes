using System.Text.Json.Serialization;


namespace CodeHelper.API.NYTimes.Books
{
    public class BuyLink
    {

        #region Properties
        [JsonPropertyName("name")]  public string Name { get; set; } = "";
        [JsonPropertyName("url")]    public string Url { get; set; } = "";
        #endregion

        #region Constructors
        public BuyLink() { }
        #endregion
    }
}
