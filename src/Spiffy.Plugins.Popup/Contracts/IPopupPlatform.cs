using System;
using System.Threading.Tasks;
using Spiffy.Plugins.Popup.Pages;

namespace Spiffy.Plugins.Popup.Contracts
{
    internal interface IPopupPlatform
    {
        event EventHandler OnInitialized;

        bool IsInitialized { get; }

        bool IsSystemAnimationEnabled { get; }

        Task AddAsync(PopupPage page);

        Task RemoveAsync(PopupPage page);
    }
}
