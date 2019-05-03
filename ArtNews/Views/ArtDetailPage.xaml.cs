using System;
using System.Collections.Generic;
using ArtNews.Models;
using ArtNews.ViewModels;
using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace ArtNews.Views
{
    public partial class ArtDetailPage : ContentPage
    {
        ArtDetailViewModel viewModel;

        public ArtDetailPage(ArtItem parameter)
        {
            InitializeComponent();
            BindingContext = viewModel = new ArtDetailViewModel(parameter);

            SharedTransitionNavigationPage.SetSharedTransitionDuration(this, 500);
        }
    }
}
