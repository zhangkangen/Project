using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Feeds;
using Microsoft.Feeds.Interop;

namespace _01_Rss
{
	class Program
	{
		static void Main(string[] args)
		{
			FeedsManagerClass fm = new FeedsManagerClass();
			string url = @"http://news.163.com/special/00011K6L/rss_newstop.xml"; //URL
			IFeedFolder rootFolder = (IFeedFolder)fm.RootFolder;
			IFeed feed = null;
			if(!fm.IsSubscribed(url))
			{
				feed = (IFeed)rootFolder.CreateFeed(url, url);
				feed.Rename("Nord Pool Spot UMM");
			}
			else
			{
				feed = (IFeed)fm.GetFeed(@"Nord Pool Spot UMM");
			}
			feed.Download();

			IFeedItem tt = feed.GetItem(0) as IFeedItem;
			string title = tt.Title;

			string xml = feed.Xml(feed.ItemCount,
				FEEDS_XML_SORT_PROPERTY.FXSP_PUBDATE,
				FEEDS_XML_SORT_ORDER.FXSO_ASCENDING,
				FEEDS_XML_FILTER_FLAGS.FXFF_ALL,
				FEEDS_XML_INCLUDE_FLAGS.FXIF_CF_EXTENSIONS);
			StreamWriter sw = new StreamWriter(File.OpenWrite("test.xml"));
			sw.Write(xml);
			sw.Close();
		}
	}
}
