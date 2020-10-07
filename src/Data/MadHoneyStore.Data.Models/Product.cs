namespace MadHoneyStore.Data.Models
{
    using MadHoneyStore.Data.Common.Models;
    using System;

    public class Product : IDeletableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Img { get; set; }

        public double Price { get; set; }

        public virtual CartItem Cart { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
