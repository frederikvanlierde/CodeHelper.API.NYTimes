using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Articles
{
    public class MetaData
    {
        #region Properties
        
        [JsonPropertyName("hits")]      public int Hits { get; set; }
        [JsonPropertyName("offset")]    public int Offset { get; set; }
        [JsonPropertyName("time")]      public int Time { get; set; }
        #endregion

        #region Constructors
        public MetaData() { }
        #endregion
    }
}
