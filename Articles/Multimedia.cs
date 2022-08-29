using System.Text.Json.Serialization;
namespace CodeHelper.API.NYTimes.Articles
{
    public  class Multimedia
    {
        #region Properties
        [JsonPropertyName("url")]           public string Url { get; set; } = "";
        [JsonPropertyName("format")]        public string Format { get; set; } = "";
        [JsonPropertyName("height")]        public int Height { get; set; }
        [JsonPropertyName("width")]         public int Width { get; set; }
        [JsonPropertyName("type")]          public string Type { get; set; } = "";
        [JsonPropertyName("subtype")]       public string Subtype { get; set; } = "";
        [JsonPropertyName("caption")]       public string Caption { get; set; } = "";
        [JsonPropertyName("copyright")]     public string Copyright { get; set; } = "";
        #endregion

        #region Constructors
        public Multimedia() { }
        #endregion
    }
}
