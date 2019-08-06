using Francisco.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francisco
{
    public static class Controlador
    {
        public static List<Ingrediente> Ingredientes { get; set; }
        public static List<Receta> Recetas { get; set; }

        public static void AgregarIngrediente(string nombre, int precio, int puntoDePedido, int cantidadActual)
        {
            Ingrediente ingrediente = new Ingrediente
            {
                Nombre = nombre,
                Precio = precio,
                PuntoPedidoMinimo = puntoDePedido,
                Cantidad = cantidadActual
            };
            Ingredientes.Add(ingrediente);
        }
        public static void Modificar(Ingrediente ingrediente, string nombre, int precio, int puntoDePedido, int cantidadActual)
        {
            ingrediente.Nombre = nombre;
            ingrediente.Precio = precio;
            ingrediente.PuntoPedidoMinimo = puntoDePedido;
            ingrediente.Cantidad = cantidadActual;
        }
    }
}
