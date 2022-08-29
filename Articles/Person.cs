using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Articles
{
    public class Person
    {
        #region Properties
        [JsonPropertyName("firstname")]     public string Firstname { get; set; } = "";
        [JsonPropertyName("middlename")]    public string Middlename { get; set; } = "";
        [JsonPropertyName("lastname")]      public string Lastname { get; set; } = "";
        [JsonPropertyName("qualifier")]     public object Qualifier { get; set; }
        [JsonPropertyName("title")]         public object Title { get; set; }
        [JsonPropertyName("role")]          public string Role { get; set; } = "";
        [JsonPropertyName("organization")]  public string Organization { get; set; } = "";
        [JsonPropertyName("rank")]          public int Rank { get; set; }
        #endregion

        #region Properties
        public Person() { }
        #endregion

    }

}
