using System;

using EFWTSMVVMTest.ViewModels;

using Windows.UI.Xaml.Controls;

namespace EFWTSMVVMTest.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
