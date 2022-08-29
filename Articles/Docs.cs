using System.Collections.Generic;
using System.Text.Json.Serialization;



namespace CodeHelper.API.NYTimes.Articles
{
    public class Docs
    {

        #region Properties        
        [JsonPropertyName("docs")] public List<Doc> Articles { get; set; } = new();

        [JsonPropertyName("meta")] public MetaData Meta { get; set; } = new();
        #endregion

        #region Constrcutor
        public Docs() { }
        #endregion
    }
}
