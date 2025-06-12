using EspacioOperacion;
namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato = 0;
        private List<Operacion> historial = new List<Operacion>();

        public double Resultado { get => dato; }

        public void Sumar(double Dato)
        {
            double anterior = dato;
            dato += Dato;
            historial.Add(new Operacion(anterior, Dato, Operacion.TipoOperacion.Suma));
        }
        public void Restar(double Dato)
        {
            double anterior = dato;
            dato -= Dato;
            historial.Add(new Operacion(anterior, Dato, Operacion.TipoOperacion.Resta));
        }
        public void Multiplicar(double Dato)
        {
            double anterior = dato;
            dato *= Dato;
            historial.Add(new Operacion(anterior, Dato, Operacion.TipoOperacion.Multiplicacion));
        }
        public void Dividir(double Dato)
        {
            double anterior = dato;
            if (Dato != 0)
            {
                dato /= Dato;
                historial.Add(new Operacion(anterior, Dato, Operacion.TipoOperacion.Division));
            }
            else
            {
                Console.WriteLine("ERROR no se puede dividir en 0");
            }
        }

        public void Limpiar()
        {
            double anterior = dato;
            dato = 0;
            historial.Add(new Operacion(anterior, dato, Operacion.TipoOperacion.Limpiar));
        }
        public void MostrarHistorial()
        {
            System.Console.WriteLine("Historial de operaciones:");
            foreach (var operacion in historial)
            {
                Console.WriteLine($"{operacion.Operacion1} | Antes: {operacion.ResultadoAnterior}, Después: {operacion.NuevoValor}");
            }
        }
    }
}
            