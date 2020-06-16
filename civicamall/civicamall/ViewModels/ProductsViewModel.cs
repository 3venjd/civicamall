using civicamall.Models;
using System.Collections.ObjectModel;

namespace civicamall.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        public ObservableCollection<Category> Categories { get; set; }

        public ProductsViewModel()
        {
            Categories = new ObservableCollection<Category>
            {
                new Category
                {
                    Name = "Calzado",
                    Image = "Calzado.jpg"
                },
                new Category
                {
                    Name = "Camisetas",
                    Image = "Camisetas.jpg"
                },
                new Category
                {
                    Name = "Vestidos",
                    Image = "Vestidos.jpg"
                },
                new Category
                {
                    Name = "Pantalones",
                    Image = "Pantalones.jpg"
                },
                new Category
                {
                    Name = "Gorras",
                    Image = "Gorras.jpg"
                },
            };
        }
    }
}
