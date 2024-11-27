using Requisitos.Clases;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace Requisitos.Pages
{
    public partial class Carrito : ComponentBase
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }
        private List<CartItem> CartItems { get; set; }
        private decimal Total => CartItems.Sum(item => item.Price * item.Quantity);

        protected override void OnInitialized()
        {
            // Inicializa con datos de ejemplo
            CartItems = new List<CartItem>
            {
                new CartItem { Id = 1, Name = "Producto 1", Price = 10.00m, Quantity = 1, ImageUrl = "https://via.placeholder.com/100" },
                new CartItem { Id = 2, Name = "Producto 2", Price = 20.00m, Quantity = 2, ImageUrl = "https://via.placeholder.com/100" }
            };
        }
        private void MoverAPaginaPagos()
        {
            NavigationManager.NavigateTo("/Tarjeta");
        }
        private void IncreaseQuantity(int id)
        {
            var item = CartItems.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.Quantity++;
            }
        }

        private void DecreaseQuantity(int id)
        {
            var item = CartItems.FirstOrDefault(x => x.Id == id);
            if (item != null && item.Quantity > 1)
            {
                item.Quantity--;
            }
        }

        private void RemoveItem(int id)
        {
            var item = CartItems.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                CartItems.Remove(item);
            }
        }
    }
}
