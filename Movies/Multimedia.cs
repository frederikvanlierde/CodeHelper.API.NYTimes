using System.Text.Json.Serialization;


namespace CodeHelper.API.NYTimes.Movies
{
    public class Multimedia
    {
        #region Properties
        [JsonPropertyName("resource")]  public MutlimediaResource Resource { get; set; }
        #endregion
        #region Constructors
        public Multimedia() { }
        #endregion
    }
}
