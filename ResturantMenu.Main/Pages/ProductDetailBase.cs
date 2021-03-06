﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ResturantMenu.Main.Services;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Pages
{
    public class ProductDetailBase : ComponentBase
    {
        [Inject]
        public IProductDataService ProductDataService { get; set; }
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string ProductId { get; set; }
        protected string CategoryId;
        public List<ApiError> Errors { get; set; } = new List<ApiError>();
        public Product Product { get; set; } = new Product();
        public List<Category> Categories { get; set; } = new List<Category>();
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            int.TryParse(ProductId, out var productId);
            Product = await ProductDataService.Get(productId);

            CategoryId = Product.CategoryId.ToString();

            Categories = await CategoryDataService.Get();

            Categories.Insert(0, new Category { CategoryId = -1, Name = "Please select" });
        }

        protected async Task HandleValidSubmit()
        {
            Product.CategoryId = int.Parse(CategoryId);

            if (Product.ProductId == 0)
            {
                var product = await ProductDataService.Add(Product);
                if (product != null)
                {
                    StatusClass = "alert-success";
                    Message = "New category added successfully.";
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong adding the new category. Please try again.";
                }
            }
            else
            {
                await ProductDataService.Update(Product);
                StatusClass = "alert-success";
                Message = "Category updated successfully.";
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
        }

        protected void NavigateToMainMenu()
        {
            NavigationManager.NavigateTo("/mainMenu");
        }
    }
}
