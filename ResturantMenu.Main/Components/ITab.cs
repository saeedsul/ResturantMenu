using Microsoft.AspNetCore.Components;

namespace ResturantMenu.Main.Components
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }

    public class TabChild : ITab
    {
        public RenderFragment ChildContent { get; }
    }
}