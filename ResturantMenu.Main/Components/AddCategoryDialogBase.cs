using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ResturantMenu.Main.Services;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Components
{
    public class AddCategoryDialogBase : ComponentBase
    {
        public bool ShowDialog { get; set; }
        public bool ShowError { get; set; }
        public List<ApiError> Errors { get; set; } = new List<ApiError>();
        public Category Category { get; set; } = new Category();

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        [Inject] 
        public ICategoryDataService CategoryDataService { get; set; }
        
        public void Show()
        {
            ShowDialog = true;
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        //protected async Task HandleValidSubmit()
        //{
        //    await CategoryDataService.Add(Category);
        //    ShowDialog = false;

        //    await CloseEventCallback.InvokeAsync(true);
        //    StateHasChanged();
        //}
        protected async Task HandleValidSubmit()
        {
            var response = await CategoryDataService.Add(Category);
            if (response.Errors.Any())
            {
                ShowError = true;
                Errors = response.Errors;
            }
            else
            {
                ShowDialog = false;
                await CloseEventCallback.InvokeAsync(true);
                StateHasChanged();
            }
        }
    }
}
