namespace PatronObserver
{
    public class DepartamentoCompras : IObservador
    {
        public void Actualizar(string producto, int cantidad)
        {
            if (cantidad < 10)
            {
                Console.WriteLine($"[Compras] Necesitamos reabastecer el producto '{producto}'. Stock actual: {cantidad} unidades.");
            }
        }
    }

}
