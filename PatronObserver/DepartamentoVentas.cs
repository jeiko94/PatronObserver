namespace PatronObserver
{
    public class DepartamentoVentas : IObservador
    {
        public void Actualizar(string producto, int cantidad)
        {
            Console.WriteLine($"[Ventas] El producto '{producto}' tiene ahora {cantidad} unidades en stock.");
        }
    }

}
