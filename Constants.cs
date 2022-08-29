namespace CodeHelper.API.NYTimes
{
    public static class Constants
    {
        #region Propertis
        public const string API_URL_SECTIONLISTS = "http://api.nytimes.com/svc/news/v3/content/section-list.json?api-key={APIKEY}";
        public const string API_URL_GETARTICLES = "https://api.nytimes.com/svc/news/v3/content/{SOURCE}/{SECTION}.json?api-key={APIKEY}";
        #endregion
    }
}
