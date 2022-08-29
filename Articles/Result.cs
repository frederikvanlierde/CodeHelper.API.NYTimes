using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace CodeHelper.API.NYTimes.Articles
{
    public class Result : BaseResult
    {
        #region Properties       
        [JsonPropertyName("results")]       public List<SectionDetail> Sections { get; set; } = new();
        #endregion

        #region constructors
        public Result() { }
        #endregion
    }
}
