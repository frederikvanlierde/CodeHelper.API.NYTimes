using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace CodeHelper.API.NYTimes.Movies
{
    public class CriticsResults : BaseResult
    {

        #region Properties        
        [JsonPropertyName("results")]       public List<CriticInfo> Critics { get; set; }
        #endregion
        #region Constructors
        public CriticsResults() { }
        #endregion
    }
}
