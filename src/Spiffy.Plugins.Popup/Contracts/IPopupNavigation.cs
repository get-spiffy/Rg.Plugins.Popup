using System.Collections.Generic;
using System.Threading.Tasks;
using Spiffy.Plugins.Popup.Pages;

namespace Spiffy.Plugins.Popup.Contracts
{
    public interface IPopupNavigation
    {
        IReadOnlyList<PopupPage> PopupStack { get; }

        Task PushAsync(PopupPage page, bool animate = true);

        Task PopAsync(bool animate = true);

        Task PopAllAsync(bool animate = true);

        Task RemovePageAsync(PopupPage page, bool animate = true);
    }
}
