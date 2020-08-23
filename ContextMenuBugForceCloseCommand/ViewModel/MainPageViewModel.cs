using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContextMenuBugForceCloseCommand.ViewModel
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            TouchCommand = new Command(() => OnTouched());
        }

        public ICommand TouchCommand { get; set; }
        public ICommand ForceCloseCommand { get; set; }
        public bool AnimateCose { get; set; } = true;

        private void OnTouched()
        {
            MessagingCenter.Send<object>(this, "ShowDialog");
            if (AnimateCose)
                ForceCloseCommand?.Execute(null);
            else
                ForceCloseCommand?.Execute(false);
        }
    }
}
