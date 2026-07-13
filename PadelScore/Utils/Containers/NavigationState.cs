using System;
using System.Collections.Generic;
using System.Text;

namespace PadelScore.Utils.Containers
{
    public class NavigationState
    {
        public string CurrentTab { get; private set; } = "home";
        public event Action? OnChange;

        public void NavigateTo(string tab)
        {
            CurrentTab = tab;
            OnChange?.Invoke();
        }
    }
}
