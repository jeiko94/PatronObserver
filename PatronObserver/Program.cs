using PatronObserver;

class Program
{
    static void Main(string[] args)
    {
        // Crear el sujeto
        Almacen almacen = new Almacen();

        // Crear observadores
        DepartamentoVentas ventas = new DepartamentoVentas();
        DepartamentoCompras compras = new DepartamentoCompras();

        // Suscribir observadores
        almacen.Suscribir(ventas);
        almacen.Suscribir(compras);

        // Modificar stock
        almacen.AgregarProducto("Laptop", 15);
        almacen.AgregarProducto("Laptop", -10);
        almacen.AgregarProducto("Laptop", -5);
    }
}
