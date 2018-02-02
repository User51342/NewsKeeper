using System;

namespace NewsKeeper.Interfaces
{
    public interface INewsFeedItemDto
    {
        string Title { get; set; }
        string Description { get; set; }
        string Url { get; set; }
        DateTime CreationDate { get; set; }
    }
}