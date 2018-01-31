using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using NewsKeeper.Interfaces;
using NewsKeeper.Interfaces.Entities;

namespace NewsKeeper.Grabber.Parser
{
    public class RdfParser : IFeedParser
    {
        public IEnumerable<INewsFeedItemDto> Parse(NewsFeedAboDto feed, string input)
        {
            List<NewsFeedItemDto> result = new List<NewsFeedItemDto>();
            var serializer = new XmlSerializer(typeof(RDF));
            var bytes = Encoding.UTF8.GetBytes(input.ToCharArray());
            using (var stream = new MemoryStream(bytes))
            {
                var rdf = (RDF)serializer.Deserialize(stream);
                foreach (var rdfItem in rdf.Items)
                {
                    var typeName = rdfItem.GetType().Name;
                    if (typeName == "channel")
                    {
                        var feedChannel = (channel) rdfItem;
                        feed.FeedName = feedChannel.title;
                        feed.Description = feedChannel.description;
                    }
                    if (typeName == "item")
                    {

                        var feeditem = (item)rdfItem;
                        var newItem = new NewsFeedItemDto()
                        {
                            NewsFeedAbo = feed,
                            Description = feeditem.description,
                            Title = feeditem.title,
                            Url = feeditem.link
                        };
                        result.Add(newItem);
                    }
                }
            }

            return result;
        }
    }
}
