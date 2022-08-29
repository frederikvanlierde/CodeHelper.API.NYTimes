using System.Text.Json.Serialization;

namespace CodeHelper.API.NYTimes
{
    public  class SectionDetail
    {
        #region Properties
        [JsonPropertyName("section")]       public string Section { get; set; } = "";
        [JsonPropertyName("display_name")]  public string DisplayName { get; set; } = "";
        #endregion

        #region Constructor
        public SectionDetail() { }
        #endregion
    }
}
