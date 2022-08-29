using System.Text.Json.Serialization;


namespace CodeHelper.API.NYTimes.Movies
{
    public class MutlimediaResource
    {
        #region Properties
        [JsonPropertyName("type")]      public string Type { get; set; } = "";
        [JsonPropertyName("src")]       public string Src { get; set; } = "";
        [JsonPropertyName("height")]    public int Height { get; set; }
        [JsonPropertyName("width")]     public int Width { get; set; }
        [JsonPropertyName("credit")]    public string Credit { get; set; } = "";
        #endregion
        #region Constructors
        public MutlimediaResource() { }
        #endregion
    }
}
