namespace Requisitos.Clases
{
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
    }
    public class PerfilUsuario
    {
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string FotoPerfilUrl { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Lista de pedidos del usuario
        public List<Pedido> HistorialPedidos { get; set; }

        // Constructor
        public PerfilUsuario(string nombre, string correoElectronico, string fotoPerfilUrl, DateTime fechaRegistro, List<Pedido> historialPedidos)
        {
            Nombre = nombre;
            CorreoElectronico = correoElectronico;
            FotoPerfilUrl = fotoPerfilUrl;
            FechaRegistro = fechaRegistro;
            HistorialPedidos = historialPedidos;
        }
    }

    // Clase Pedido
    public class Pedido
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPedido { get; set; }
        public bool Activo { get; set; }

        // Constructor
        public Pedido(int id, string descripcion, DateTime fechaPedido, bool activo)
        {
            Id = id;
            Descripcion = descripcion;
            FechaPedido = fechaPedido;
            Activo = activo;
        }
    }

}
