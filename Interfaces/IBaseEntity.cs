using System;

namespace NewsKeeper.Interfaces
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        DateTime CreationDate { get; set; }
    }
}
