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

        protected Dictionary<string, string> Translate = new Dictionary<string, string>
        {
            {"next", "next" },
            {"previous", "Previous" },
            {"pages", "Page __curpage__ of __totalpages__" },
            {"totalresult", "__totalcount__ item" },
            {"totalresultplural", "__totalcount__ items"},
            {"filteredresults", "__filteredcount__ result of __totalcount__ items" },
            {"filteredresultsplural", "__filteredcount__ results of __totalcount__ items"  },
            {"selector", "Items per page:"}
        };

        protected Dictionary<string, int> PageSelector = new Dictionary<string, int>
        {
            {"5", 5 },
            {"10", 10 },
            {"20", 20 },
            {"30", 30 },
            {"All", 0 }
        };
    }
}