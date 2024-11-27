using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace Requisitos.Pages
{
    public partial class Producto : ComponentBase
    {
        // Lista de productos disponibles
        public List<Product> Products { get; set; } = new List<Product>
        {
            new Product { Id = 1, Name = "Producto 1", Description = "Descripción del Producto 1", Price = 10.00m, ImageUrl = "https://via.placeholder.com/100" },
            new Product { Id = 2, Name = "Producto 2", Description = "Descripción del Producto 2", Price = 20.00m, ImageUrl = "https://via.placeholder.com/100" },
            new Product { Id = 3, Name = "Producto 3", Description = "Descripción del Producto 3", Price = 15.00m, ImageUrl = "https://via.placeholder.com/100" }
        };

        // Lista para almacenar los productos agregados al carrito
        private List<Product> CartItems { get; set; } = new List<Product>();

        // Método para agregar un producto al carrito
        private void AddToCart(Product product)
        {
            CartItems.Add(product);
            Console.WriteLine($"{product.Name} agregado al carrito");
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
