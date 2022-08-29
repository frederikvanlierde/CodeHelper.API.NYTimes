
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes.Books
{
    public class ListResult : BaseResult
    {
        #region Properties        
        [JsonPropertyName("results")]       public List<ListInfo> Lists { get; set; } = new();
        #endregion

        #region Constructors
        public ListResult() { }
        #endregion

    }
}
