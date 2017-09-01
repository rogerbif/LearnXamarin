using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace rbx1
{
    public class MainViewModel
    {
        private Product _oldProduct;

        public ObservableCollection<Product> Products { get; set; }

        public MainViewModel()
        {
            Products = new ObservableCollection<Product>();

            for(int i=0 ; i <20 ; i++)
            {
                Products.Add(new Product
                {
                    Name = "Produto" + i,
                    IsVisible = false,
                });
            }

           /* {
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
                new Product
                {
                    Name = "Produto 1",
                    IsVisible = false,
                },
            };*/
        }

        public void ShowOrHidePoducts(Product product)
        {
            if (_oldProduct == product)
            {
                // click twice on the same item will hide it
                product.IsVisible = !product.IsVisible;
                UpdateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    // hide previous selected item
                    _oldProduct.IsVisible = false;
                    UpdateProducts(_oldProduct);
                }
                // show selected item
                product.IsVisible = true;
                UpdateProducts(product);
            }

            _oldProduct = product;
        }

        private void UpdateProducts(Product product)
        {
            var index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(index, product);
        }
    }
}