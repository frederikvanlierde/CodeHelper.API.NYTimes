namespace CodeHelper.API.NYTimes
{
    public static class Constants
    {
        #region Propertis
        public const string API_URL_SECTIONLISTS = "http://api.nytimes.com/svc/news/v3/content/section-list.json?api-key={APIKEY}";
        public const string API_URL_ARTICLES_GETLATEST = "https://api.nytimes.com/svc/news/v3/content/{SOURCE}/{SECTION}.json?api-key={APIKEY}";
        public const string API_URL_ARTICLES_TOPSTORIES = "https://api.nytimes.com/svc/topstories/v2/{SECTION}.json?api-key={APIKEY}";
        public const string API_URL_ARTICLES_MOSTPOPULAR = "https://api.nytimes.com/svc/mostpopular/v2/{RESOURCETYPE}/{PERIOD}/{SHAREDTYPE}.json?api-key={APIKEY}";
        public const string API_URL_ARTICLES_SEARCH = "https://api.nytimes.com/svc/search/v2/articlesearch.json?q={QUERY}&fq={FILTER}&api-key={APIKEY}";
        public const string API_URL_ARTICLES_ARCHIVE = "https://api.nytimes.com/svc/archive/v1/{YEAR}/{MONTH}.json?api-key={APIKEY}";
        #endregion
    }
}
