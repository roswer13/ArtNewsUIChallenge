using System;
using System.Collections.Generic;
using ArtNews.ViewModels;
using Xamarin.Forms;

namespace ArtNews.Views
{
    public partial class DetailAuthorPage : ContentPage
    {
        DetailAuthorViewModel viewModel;

        public DetailAuthorPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new DetailAuthorViewModel();
        }
    }
}
