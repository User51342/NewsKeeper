using System;
using System.ComponentModel.DataAnnotations;

namespace NewsKeeper.SQLDataAccess.Entities
{
    public class BaseEntity
    {
        #region Fields
        private DateTime? creationDate = DateTime.Now;
        #endregion

        [Key]
        public int Id { get; set; }
        public DateTime? CreationDate
        {
            get => creationDate ?? DateTime.Now;
            set => creationDate = value ?? DateTime.Now;
        }
    }
}
