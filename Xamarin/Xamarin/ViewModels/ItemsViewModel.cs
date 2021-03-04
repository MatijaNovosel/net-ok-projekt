using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Xamarin.Models;
using Xamarin.Views;

namespace Xamarin.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Product> Products { get; }
        public Command LoadProductsCommand { get; }

        public ItemsViewModel()
        {
            Title = "Products";
            Products = new ObservableCollection<Product>();
            LoadProductsCommand = new Command(async () => await ExecuteLoadProductsCommand());
        }

        async Task ExecuteLoadProductsCommand()
        {
            Products.Clear();

            var service = new RestService();
            List<Product> products = await service.GetProducts();

            IsBusy = true;

            foreach (var item in products)
            {
                Products.Add(item);
            }

            IsBusy = false;
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}