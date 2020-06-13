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
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            int.TryParse(CategoryId, out var categoryId);
            Category = await CategoryDataService.Get(categoryId);
        }

        protected async Task HandleValidSubmit()
        {
            if (Category.CategoryId == 0)
            {
                var category = await CategoryDataService.Add(Category);
                if (category != null)
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
