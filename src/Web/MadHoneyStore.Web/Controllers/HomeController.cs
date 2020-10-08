namespace MadHoneyStore.Web.Controllers
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using MadHoneyStore.Data;
    using MadHoneyStore.Data.Common.Repositories;
    using MadHoneyStore.Data.Models;
    using MadHoneyStore.Data.Models.Enum;
    using MadHoneyStore.Web.ViewModels;
    using MadHoneyStore.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IDeletableEntityRepository<Product> productsRepository;

        public HomeController(IDeletableEntityRepository<Product> productsRepository)
        {
            
            this.productsRepository = productsRepository;
        }

        public IActionResult Index()
        {

            var viewModel = new IndexViewModel();
            var categories = Enum.GetValues(typeof(CategoryType)).Cast<CategoryType>().ToList();
            
            var categoryList = categories
                .Select(c => new IndexCategoryViewModel()
                {
                    Name = c.ToString()
                            .Replace("_", " & "),
                })
                .ToList();

            var products = this.productsRepository.All()
                .Select(p => new IndexProductViewModel()
                {
                    Title = p.Title,
                    Price = p.Price,
                    Description = p.Description,
                    Category = p.Category.ToString(),
                    Image = p.Img,
                })
                .ToList();
            viewModel.Categories = categoryList;
            viewModel.Products = products;

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
