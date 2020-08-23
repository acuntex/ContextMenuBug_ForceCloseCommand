using System.Threading.Tasks;
using ContextMenuBugForceCloseCommand.ViewModel;
using Xamarin.Forms;

namespace ContextMenuBugForceCloseCommand
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<object>(this, "ShowDialog", async (obj) => await ShowDialog());
            BindingContext = new MainPageViewModel();
        }

        private async Task ShowDialog()
        {
            await DisplayAlert("SideContextMenuView should close", "It should have been closed, but does this only on iOS.", "Cancel");
        }
    }
}
