namespace MadHoneyStore.Web.ViewModels.Home
{
    using MadHoneyStore.Data.Models.Enum;
    public class IndexProductViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }

        public string Url => $"/{this.Title.Replace(' ', '-')}";
    }
}