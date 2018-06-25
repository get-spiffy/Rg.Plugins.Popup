
using System;
using Spiffy.Plugins.Popup.IOS.Impl;
using Spiffy.Plugins.Popup.IOS.Renderers;

namespace Spiffy.Plugins.Popup
{
    public static class Popup
    {
        internal static event EventHandler OnInitialized;

        internal static bool IsInitialized { get; private set; }

        public static void Init()
        {
            LinkAssemblies();

            IsInitialized = true;
            OnInitialized?.Invoke(null, EventArgs.Empty);
        }

        private static void LinkAssemblies()
        {
            if (false.Equals(true))
            {
                var i = new PopupPlatformIos();
                var r = new PopupPageRenderer();
            }
        }
    }
}
