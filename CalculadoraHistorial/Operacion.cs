namespace EspacioOperacion
{



    public class Operacion
    {
                public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar
    }


        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacion1;
        public double Resultado => nuevoValor;
        public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
        public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
        public TipoOperacion Operacion1 { get => operacion1; set => operacion1 = value; }

        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion1)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion1 = operacion1;
        }



    }


}