using System;
using System.Threading.Tasks;
using System.Windows.Input;
using ArtNews.Models;
using ArtNews.Services;
using Xamarin.Forms;

namespace ArtNews.ViewModels
{
    public class DetailAuthorViewModel : ViewModelBase
    {
        private Author _author;

        public Author Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged();
            }
        }

        public DetailAuthorViewModel()
        {
            Author = ArtService.Instance.GetAuthorInfo();
        }
    }
}
