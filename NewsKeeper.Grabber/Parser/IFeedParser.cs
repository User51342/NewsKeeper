using System.Collections.Generic;
using NewsKeeper.Interfaces;
using NewsKeeper.Interfaces.Entities;

namespace NewsKeeper.Grabber.Parser
{
    public interface IFeedParser
    {
        IEnumerable<INewsFeedItemDto> Parse(NewsFeedAboDto feed, string input);
    }
}
