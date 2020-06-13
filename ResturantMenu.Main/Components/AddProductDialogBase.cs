using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ResturantMenu.Main.Services;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Components
{
    public class AddProductDialogBase : ComponentBase
    {
        public bool ShowDialog { get; set; }
        public bool ShowError { get; set; }
        protected string CategoryId;
        public List<ApiError> Errors { get; set; } = new List<ApiError>();
        public Product Product { get; set; } = new Product{CategoryId = 1};
        public List<Category> Categories { get; set; } = new List<Category>();
        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }
        [Inject]
        public IProductDataService ProductDataService { get; set; }
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            CategoryId = Product.CategoryId.ToString();
            
            Categories = await CategoryDataService.Get();

            Categories.Insert(0, new Category { CategoryId = -1, Name = "Please select" });
        }

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

        protected async Task HandleValidSubmit()
        {
            var response = await ProductDataService.Add(Product);
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
