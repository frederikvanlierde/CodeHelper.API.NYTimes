using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Articles
{
    public class ResultArticles : BaseResult
    {
        #region Properties        
        [JsonPropertyName("results")] public List<Article> Articles { get; set; } = new();
        #endregion

        #region constructors
        public ResultArticles() { }
        #endregion
    }
}
