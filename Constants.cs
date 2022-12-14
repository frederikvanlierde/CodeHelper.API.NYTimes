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
        public const string API_URL_BOOKS_BESTSELLERLISTS = "https://api.nytimes.com/svc/books/v3/lists/names.json?api-key={APIKEY}";
        public const string API_URL_BOOKS_ONLIST = "https://api.nytimes.com/svc/books/v3/lists/{DATE}/{LISTNAME}.json?api-key={APIKEY}";
        public const string API_URL_REVIEWS_GETBY = "https://api.nytimes.com/svc/books/v3/reviews.json?{REVIEWBYTYPE}={REVIEWBYVALUE}&api-key={APIKEY}";
        public const string API_URL_MOVIES_GETCRITICSNAMES = "https://api.nytimes.com/svc/movies/v2/critics/all.json?api-key={APIKEY}";
        public const string API_URL_MOVIES_GETREVIEWSBYCRTIC = "https://api.nytimes.com/svc/movies/v2/critics/{CRITICNAME}?api-key={APIKEY}";
        public const string API_URL_MOVIES_GETCRITICSPICKS = "https://api.nytimes.com/svc/movies/v2/reviews/picks.json?api-key={APIKEY}";
        public const string API_URL_MOVIES_SEARCH = "https://api.nytimes.com/svc/movies/v2/reviews/search.json?query{QUERY}&ate={DATEPERIOD}&api-key={APIKEY}";
        #endregion
    }
}
