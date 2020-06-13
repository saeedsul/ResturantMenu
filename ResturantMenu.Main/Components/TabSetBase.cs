using System.Collections.Generic;
using Microsoft.AspNetCore.Components; 

namespace ResturantMenu.Main.Components
{
    public class TabSetBase : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public EventCallback<int> TabChanged { get; set; }

        [Parameter]
        public int SelectedIndex { get; set; }
        
        public List<Tab> Tabs = new List<Tab>();

        public void AddTab(Tab tab)
        {
            Tabs.Add(tab);
            StateHasChanged();
        }

        public void RemoveTab(Tab tab)
        {
            Tabs.Remove(tab);
        }

        public bool HasActiveTab { get { return SelectedIndex >= 0 && SelectedIndex < Tabs.Count; } }

        public bool IsActiveTab(Tab tab)
        {
            if (!HasActiveTab)
                return false;

            int tabIndex = Tabs.IndexOf(tab);
            return tabIndex == SelectedIndex;
        }

        // Note : unsafe to call before the parent has rendered all its children (i.e. ChildContent)
        // instead use IsActiveTab
        public Tab ActiveTab
        {
            get
            {
                return Tabs[SelectedIndex];
            }
            set
            {
                SelectedIndex = this.Tabs.IndexOf(value);
                TabChanged.InvokeAsync(SelectedIndex);
                StateHasChanged();
            }
        }
    }
}