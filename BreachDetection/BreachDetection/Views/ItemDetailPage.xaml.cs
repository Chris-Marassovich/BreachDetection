using BreachDetection.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BreachDetection.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}