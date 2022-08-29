# CodeHelper.API.NYTimes
CodeHelper.API.NYTimes is a lightweight and simple .NET Wrapper to get links and metadata for Times' articles as soon as they are published on NYTimes.com. The Times Newswire API provides an up-to-the-minute stream of published articles. You can filter results by source (all, nyt, inyt) and section (arts, business, ...).

## Question?
* NYTimes API: <https://developer.nytimes.com/apis>
* Frederik van Lierde <https://twitter.com/@frederik_vl/>
* GitHub <https://github.com/frederikvanlierde/CodeHelper.API.NYTimes>
* NuGet <https://www.nuget.org/packages/CodeHelper.API.NYTimes>

## Version
* 1.0.0 : Get Sections, Get Latest Articles, Get Top Stories, Get Most Popular, Article Search, Article Archives 

## Methods
* NYTimesHelper.GetSections() :  Returns the available sections, like Arts, Business,...
* NYTimesHelper.GetLatestArticles(string source = SourceTypes.All, string section = "all") : Get links and metadata for NY Times' articles as soon as they are published on NYTimes.com.
* NYTimesHelper.GetTopStories(string section = "home") : Returns an array of articles currently on the specified section (arts, business, ...).
* NYTimesHelper.GetMostPopularArticles(string resourceType = "", int period=1, string sharedType = "") : Returns the most popular articles on NYTimes.com based on emails, shares, or views for specified period of time (1 day, 7 days, or 30 days).
* NYTimesHelper.ArticleSearch(string qurey, int page = 0) : Look up articles by keyword. 
* NYTimesHelper.GetArticleArchive(int year, int month) : Returns an array of NYT articles for a given month, going back to 1851.

## Use of Code
´´´C#
using CodeHelper.API.NYTimes;
using CodeHelper.API.NYTimes.Articles;

NYTimesHelper _helper = new() { ApiKey = "YOUR_NYTIMES_API_TOKEN"" };
var _articles = _helper.GetTopStories("arts");
´´´

## Authentication
NY Times API uses API key to authenticate requests. You can view and manage your API keys in the My Apps page <https://developer.nytimes.com/my-apps>

## Usage
* Free Plan, API KEY is mandatory <https://developer.nytimes.com/get-started>