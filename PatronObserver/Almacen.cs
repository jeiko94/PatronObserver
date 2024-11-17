namespace PatronObserver
{
    public class Almacen
    {
        private Dictionary<string, int> _productos = new Dictionary<string, int>();
        private List<IObservador> _observadores = new List<IObservador>();

        public void AgregarProducto(string producto, int cantidad)
        {
            if (_productos.ContainsKey(producto))
                _productos[producto] += cantidad;
            else
                _productos[producto] = cantidad;

            Notificar(producto, _productos[producto]);
        }

        public void Suscribir(IObservador observador)
        {
            _observadores.Add(observador);
        }

        public void Desuscribir(IObservador observador)
        {
            _observadores.Remove(observador);
        }

        private void Notificar(string producto, int cantidad)
        {
            foreach (var observador in _observadores)
            {
                observador.Actualizar(producto, cantidad);
            }
        }
    }
}
