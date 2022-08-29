using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Articles
{
    public class Byline
    {

        #region Properties
        [JsonPropertyName("original")]      public string Original { get; set; }
        [JsonPropertyName("person")]        public List<Person> Person { get; set; }
        [JsonPropertyName("organization")]  public object Organization { get; set; }
        #endregion
        #region Constructors
        public Byline() { }
        #endregion
    }

}
