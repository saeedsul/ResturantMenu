using System.Collections.Generic;
using System.Linq;
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
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }

        public ProductOverViewModel Model { get; set; } = new ProductOverViewModel();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Category> Categories { get; set; } = new List<Category>();

        public AddProductDialogBase AddProductDialog { get; set; }

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductDataService.Get();
            Categories = await CategoryDataService.Get();
            foreach (var product in Products)
            {
                Model.ProductViewItems.Add(new ProductViewItem
                {
                    CategoryId = product.CategoryId,
                    CategoryName = Categories.First(x=>x.CategoryId == product.CategoryId).Name,
                    Image = product.Image,
                    IsAvailable = product.IsAvailable,
                    Name = product.Name,
                    ProductId = product.ProductId,
                    UnitPrice = product.UnitPrice
                });
            }
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

    public class ProductOverViewModel
    {
        public List<ProductViewItem> ProductViewItems { get; set; } = new List<ProductViewItem>();
    }
    public class ProductViewItem
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Image { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}