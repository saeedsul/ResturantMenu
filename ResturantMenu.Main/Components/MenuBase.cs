using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ResturantMenu.Main.Services;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Components
{
    public class MenuBase : ComponentBase
    {
     
       public List<Category> Categories { get; set; } = new List<Category>();
        public List<Product> Products { get; set; } = new List<Product>();
        public Order Order{ get; set; } = new Order();

        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }

        [Inject]
        public IProductDataService ProductDataService { get; set; }

        [Inject]
        public IOrderDataService OrderDataService { get; set; }
        
        protected override async Task OnInitializedAsync()
        {
            Categories = await CategoryDataService.Get();

            Products = await ProductDataService.Get();
        }

        protected void AddToCart(Product item)
        {
            if(Order.Products.Any(x => x.ProductId == item.ProductId))
            {
                var product = Order.Products.First(x => x.ProductId == item.ProductId);
                product.ProductId = item.ProductId;
                product.Name = item.Name;
                product.Quantity ++;
                product.TotalPrice = item.UnitPrice * product.Quantity;
            }
            else
            {
                Order.Products.Add(new Product { ProductId = item.ProductId, Name = item.Name, UnitPrice = item.UnitPrice, TotalPrice = item.UnitPrice, Quantity = 1 });
            }

            Order.Total = Order.Products.Sum(x => x.TotalPrice);

            StateHasChanged();
        }

        protected void RemoveFromCart(Product item)
        {
            if (Order.Products.Any(x => x.ProductId == item.ProductId))
            {
                var product = Order.Products.First(x => x.ProductId == item.ProductId);
                if (product.Quantity == 1)
                {
                    Order.Products.Remove(Order.Products.Single(x => x.ProductId == item.ProductId));
                }
                else
                {
                    product.ProductId = item.ProductId;
                    product.Name = item.Name;
                    product.Quantity--;
                    product.TotalPrice = item.UnitPrice * product.Quantity;
                }
            }

            Order.Total = Order.Products.Sum(x => x.TotalPrice);

            StateHasChanged();
        }
        
        //protected async Task SelectCategory(int categoryId)
        //{
        //    await Task.Run(() => Message = $"categoryId : {categoryId}");
        //}
    }
}