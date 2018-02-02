using System.Collections.Generic;
using NewsKeeper.Interfaces.Entities;

namespace NewsKeeper.Interfaces
{
    public interface INewsService
    {
        IEnumerable<NewsFeedAboDto> GetNewsFeeds();
        IEnumerable<NewsFeedItemDto> GetNewsFeedItems(int id);
        void StoreFeedItems(IEnumerable<INewsFeedItemDto> newsFeedItems);

    }
}
