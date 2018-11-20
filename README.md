# DTSExample
This is a quick and dirty example of an issue I am experiencing with Data Template Selectors for Group Headers in Xamarin.

Notice that the line that will raise the ArgumentOutOfRangeException is commented out in the MainPageVM

If you want to replace the groupheadertemplate with a groupdisplaybinding in MainPage.xaml you'll see that it works fine for groupings without children.

I am sorry if the code is confusing. I am just using color changes to demonstrate DataTemplateSelectors for both the items and the groupheaders. I created a Grouping.cs and an InheritedGrouping.cs because this is similar to something I am doing in my actual code, though I know there are other ways to create groupings in listviews.
