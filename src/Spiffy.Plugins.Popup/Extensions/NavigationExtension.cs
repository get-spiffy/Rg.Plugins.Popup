﻿using System.Threading.Tasks;
using Spiffy.Plugins.Popup.Pages;
using Spiffy.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Spiffy.Plugins.Popup.Extensions
{
    public static class NavigationExtension
    {
        public static Task PushPopupAsync(this INavigation sender, PopupPage page, bool animate = true)
        {
            return PopupNavigation.Instance.PushAsync(page, animate);
        }

        public static Task PopPopupAsync(this INavigation sender, bool animate = true)
        {
            return PopupNavigation.Instance.PopAsync(animate);
        }

        public static Task PopAllPopupAsync(this INavigation sender, bool animate = true)
        {
            return PopupNavigation.Instance.PopAllAsync(animate);
        }

        public static Task RemovePopupPageAsync(this INavigation sender, PopupPage page, bool animate = true)
        {
            return PopupNavigation.Instance.RemovePageAsync(page, animate);
        }
    }
}
