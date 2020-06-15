using Microsoft.AspNetCore.Components;

namespace ResturantMenu.Main.Components.Tabs
{
    public interface ITab
    {
        RenderFragment ChildContent { get; set; }
    }
}
