using System;
using System.Collections.Generic;
using ArtNews.ViewModels;
using Xamarin.Forms;

namespace ArtNews.Views
{
    public partial class ArtDetailPage : ContentPage
    {
        ArtDetailViewModel viewModel;

        public ArtDetailPage(object parameter)
        {
            InitializeComponent();
            BindingContext = viewModel = new ArtDetailViewModel();
        }
    }
}
