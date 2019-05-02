using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArtNews.ViewModels
{
    public class ViewModelBase : BindableObject
    {
        public virtual Task InitializeAsync(object navigationData) => Task.FromResult(false);
    }
}
