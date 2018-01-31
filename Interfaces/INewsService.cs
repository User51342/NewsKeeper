using System.Collections.Generic;
using NewsKeeper.Interfaces.Entities;

namespace NewsKeeper.Interfaces
{
    public interface INewsService
    {
        IEnumerable<NewsFeedAboDto> GetNewsFeeds();
        void StoreFeedItems(IEnumerable<INewsFeedItemDto> newsFeedItems);
    }
}
