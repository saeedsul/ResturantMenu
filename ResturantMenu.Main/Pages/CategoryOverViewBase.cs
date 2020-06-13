using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ResturantMenu.Main.Components;
using ResturantMenu.Main.Services;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Pages
{
    public class CategoryOverViewBase : ComponentBase
    {
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }
        
        public List<Category> Categories { get; set; } = new List<Category>();

        public AddCategoryDialogBase AddCategoryDialog { get; set; }

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            Categories = await CategoryDataService.Get();
        }

        protected async Task Delete(int categoryId)
        {
            await CategoryDataService.Delete(categoryId);

            StatusClass = "alert-success";
            Message = "Deleted successfully";
        }

        public async void AddCategoryDialog_OnDialogClose()
        {
            Categories = (await CategoryDataService.Get());
            StateHasChanged();
        }

        protected void QuickAddCategory()
        {
            AddCategoryDialog.Show();
        }
    }
}