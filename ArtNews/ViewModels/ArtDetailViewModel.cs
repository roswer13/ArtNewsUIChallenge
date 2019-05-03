using System;
using System.Threading.Tasks;
using ArtNews.Models;
using ArtNews.Services;

namespace ArtNews.ViewModels
{
    public class ArtDetailViewModel : ViewModelBase
    {
        private ArtItem _author;

        public ArtItem ArtItem
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged();
            }
        }

        public ArtDetailViewModel(ArtItem parameters)
        {
            ArtItem = parameters;
        }
    }
}
