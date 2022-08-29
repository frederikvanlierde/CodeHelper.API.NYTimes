using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Articles
{
    public class ResultArticles
    {
        #region Properties
        [JsonPropertyName("status")] public string Status { get; set; } = "";
        [JsonPropertyName("copyright")] public string Copyright { get; set; } = "";
        [JsonPropertyName("num_results")] public int NumResults { get; set; }
        [JsonPropertyName("results")] public List<Article> Articles { get; set; } = new();
        #endregion

        #region constructors
        public ResultArticles() { }
        #endregion
    }
}
