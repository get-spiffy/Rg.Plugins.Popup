using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Animations;
using Spiffy.Plugins.Popup.Pages;
using Spiffy.Plugins.Popup.Services;
using Xamarin.Forms;

namespace Demo.Pages
{
    public partial class UserAnimationPage : PopupPage
    {
        public UserAnimationPage()
        {
            InitializeComponent();
        }

        private void OnClose(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
        }
    }
}
