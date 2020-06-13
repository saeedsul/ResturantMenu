using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ResturantMenu.Main.Components;
using ResturantMenu.Main.Services;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Pages
{
    public class ProductOverViewBase : ComponentBase
    {
        [Inject]
        public IProductDataService ProductDataService { get; set; }
        
        public List<Product> Products { get; set; } = new List<Product>();

        public AddProductDialogBase AddProductDialog { get; set; }

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductDataService.Get();
        }

        protected async Task Delete(int productId)
        {
            await ProductDataService.Delete(productId);

            StatusClass = "alert-success";
            Message = "Deleted successfully";
        }

        public async void AddProductDialog_OnDialogClose()
        {
            Products = (await ProductDataService.Get());
            StateHasChanged();
        }

        protected void QuickAddProduct()
        {
            AddProductDialog.Show();
        }
    }
}