using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;



namespace Requisitos.Pages {
        public partial class Eventos : ComponentBase
        {
            // Lista de productos disponibles
            public List<Event> Even { get; set; } = new List<Event>
        {
            new Event { Id = 1, Name = "Evento 1", Description = "Descripción del Evento 1", Fecha = "22/04/2025", ImageUrl = "https://via.placeholder.com/100" },
            new Event { Id = 2, Name = "Evento 2", Description = "Descripción del Evento 2", Fecha = "22/04/2025", ImageUrl = "https://via.placeholder.com/100" },
            new Event { Id = 3, Name = "Evento 3", Description = "Descripción del Evento 3", Fecha = "22/04/2025", ImageUrl = "https://via.placeholder.com/100" }
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

        public class Event
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Fecha { get; set; }
            public string ImageUrl { get; set; }
        }
    }

