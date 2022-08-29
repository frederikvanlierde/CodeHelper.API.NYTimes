# CodeHelper.API.NYTimes
CodeHelper.API.NYTimes is a lightweight and simple .NET Wrapper to get links and metadata for Times' articles as soon as they are published on NYTimes.com. The Times Newswire API provides an up-to-the-minute stream of published articles. You can filter results by source (all, nyt, inyt) and section (arts, business, ...).

## Question?
* NYTimes API: <https://developer.nytimes.com/apis>
* Frederik van Lierde <https://twitter.com/@frederik_vl/>
* GitHub <https://github.com/frederikvanlierde/CodeHelper.API.NYTimes>
* NuGet <https://www.nuget.org/packages/CodeHelper.API.NYTimes>

## Version
* 1.0.0 : Get Sections, Get Articles

## Methods
* NYTimesHelper.GetSections() :  Returns the available sections, like Arts, Business,...
* NYTimesHelper.GetArticles(string source = SourceTypes.All, string section = "all") : Get links and metadata for NY Times' articles as soon as they are published on NYTimes.com.

## Authentication
NY Times API uses API key to authenticate requests. You can view and manage your API keys in the My Apps page <https://developer.nytimes.com/my-apps>

## Usage
* Free Plan