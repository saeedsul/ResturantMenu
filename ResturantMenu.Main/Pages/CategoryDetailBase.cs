using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ResturantMenu.Main.Services;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Pages
{
    public class CategoryDetailBase : ComponentBase
    {
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string CategoryId { get; set; }
        public Category Category { get; set; } = new Category();
        public List<ApiError> Errors { get; set; } = new List<ApiError>();
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        public bool ShowError { get; set; }

        protected override async Task OnInitializedAsync()
        {
            int.TryParse(CategoryId, out var categoryId);
            Category = await CategoryDataService.Get(categoryId);
        }

        protected async Task HandleValidSubmit()
        {
            if (Category.CategoryId == 0)
            {
                var response = await CategoryDataService.Add(Category);
                if (response.Errors.Any())
                {
                    ShowError = true;
                    Errors = response.Errors;
                    StatusClass = "alert-danger";
                }
                else
                {
                    StatusClass = "alert-success";
                    Message = "New category added successfully.";
                }
            }
            else
            {
                await CategoryDataService.Update(Category);
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
