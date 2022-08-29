﻿# CodeHelper.API.NYTimes
CodeHelper.API.NYTimes is a lightweight and simple .NET Wrapper to get links and metadata for Times' articles as soon as they are published on NYTimes.com. The Times Newswire API provides an up-to-the-minute stream of published articles. You can filter results by source (all, nyt, inyt) and section (arts, business, ...).

## Question?
* NYTimes API: <https://developer.nytimes.com/apis>
* Frederik van Lierde <https://twitter.com/@frederik_vl/>
* GitHub <https://github.com/frederikvanlierde/CodeHelper.API.NYTimes>
* NuGet <https://www.nuget.org/packages/CodeHelper.API.NYTimes>

## Version
* 1.1.0 : Get Best Seller Lists, Get Books on a specific list, Get NYT Book reviews by author¦isbn¦title
* 1.0.0 : Get Sections, Get Latest Articles, Get Top Stories, Get Most Popular, Article Search, Article Archives 

## Methods
* NYTimesArticlesHelper.GetSections() :  Returns the available sections, like Arts, Business,...
* NYTimesArticlesHelper.GetLatestArticles(string source = SourceTypes.All, string section = "all") : Get links and metadata for NY Times' articles as soon as they are published on NYTimes.com.
* NYTimesArticlesHelper.GetTopStories(string section = "home") : Returns an array of articles currently on the specified section (arts, business, ...).
* NYTimesArticlesHelper.GetMostPopularArticles(string resourceType = "", int period=1, string sharedType = "") : Returns the most popular articles on NYTimes.com based on emails, shares, or views for specified period of time (1 day, 7 days, or 30 days).
* NYTimesArticlesHelper.ArticleSearch(string qurey, int page = 0) : Look up articles by keyword. 
* NYTimesArticlesHelper.GetArticleArchive(int year, int month) : Returns an array of NYT articles for a given month, going back to 1851.

* NYTimesBooksHelper.GetBestSellerLists() : Returns a list of all the NYT Best Sellers Lists.
* NYTimesBooksHelper.GetBookReviews(string reviewByType, string reviewByValue) : Returns a list NYT book review by author, ISBN, or title.

## Use of Code 
 ```csharp
using CodeHelper.API.NYTimes;
using CodeHelper.API.NYTimes.Articles;

NYTimesArticlesHelper _helper = new() { ApiKey = "YOUR_NYTIMES_API_TOKEN"" };
var _articles = _helper.GetTopStories("arts");

NYTimesBooksHelper _helper = new() { ApiKey = "YOUR_NYTIMES_API_TOKEN"" };
var _lists = _helper.GetBestSellerLists();
var _books = _helper.GetBooksOnList("hardcover-fiction");
var _reviews = await _helper.GetBookReviews(ReviewByTypes.Author, "Stephen King");
```

## Authentication
NY Times API uses API key to authenticate requests. You can view and manage your API keys in the My Apps page <https://developer.nytimes.com/my-apps>

## Usage
* Free Plan, API KEY is mandatory <https://developer.nytimes.com/get-started>
