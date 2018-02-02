using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using NewsKeeper.Interfaces;
using NewsKeeper.Interfaces.Entities;
using NewsKeeper.SQLDataAccess;
using NewsKeeper.SQLDataAccess.Entities;

namespace NewsKeeper.LogicLayer
{
    public class NewsFeedService : INewsService
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly SqlUnitOfWork _UnitOfWork;
        #endregion

        #region Construction / Initialization / Deconstruction
        public NewsFeedService()
        {
            _UnitOfWork = new SqlUnitOfWork();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<NewsFeedAbo, NewsFeedAboDto>();
                c.CreateMap<NewsFeedAboDto, NewsFeedAbo>();
                c.CreateMap<NewsFeedItemDto, NewsFeedItem>();
            });
            _mapper = config.CreateMapper();
        }
        #endregion

        #region Public implemenations
        public IEnumerable<NewsFeedAboDto> GetNewsFeeds()
        {
            var allFeeds = _UnitOfWork.NewsFeedAbos.GetAll().Where(a => a.IsActive);
            var newsFeedAboDtos = _mapper.Map<IEnumerable<NewsFeedAboDto>>(allFeeds);
            return newsFeedAboDtos;
        }

        public void UpdateAbo(NewsFeedAboDto abo)
        {
            var newsFeedAbo = _mapper.Map<NewsFeedAbo>(abo);
            _UnitOfWork.NewsFeedAbos.Update(newsFeedAbo);
            _UnitOfWork.commit();
        }

        public void StoreFeedItems(IEnumerable<INewsFeedItemDto> newsFeedItems)
        {
            foreach (var item in newsFeedItems)
            {
                var newItem = _mapper.Map<NewsFeedItem>(item);
                if (_UnitOfWork.NewsFeedItems.GetAll().All(n => n.Url != newItem.Url))
                {
                    _UnitOfWork.NewsFeedItems.Add(newItem);
                }
            }
            _UnitOfWork.commit();
        }
        #endregion
    }
}
