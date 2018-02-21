using System.Collections.Generic;

namespace NewsKeeper.Interfaces
{
    public interface INewsFeedAboDto : IBaseEntity
    {
        string FeedName { get; set; }
        string Description { get; set; }
        string FeedUrl { get; set; }
        bool IsActive { get; set; }
        IEnumerable<INewsFeedItemDto> NewsItems { get; set; }
    }
}