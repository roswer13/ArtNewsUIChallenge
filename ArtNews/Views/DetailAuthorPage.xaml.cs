using System;
using System.Collections.Generic;
using ArtNews.Models;
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

        public async void OnHighlightTapped(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            var itemSelect = ((CollectionView)sender).SelectedItem as ArtItem;
            await Navigation.PushAsync(new ArtDetailPage(itemSelect));
        }
    }
}
