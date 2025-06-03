namespace EspacioTareas
{
    public class Tarea
    {
        public int TareaID { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }

        public Tarea(int TareaID, string Descripcion, int Duracion)
        {
            this.TareaID = TareaID;
            this.Descripcion = Descripcion;
            if (Duracion >= 10 && Duracion <= 100)
            {
                this.Duracion = Duracion;
            }
            else
            {
                this.Duracion = 10;
            }
        }
    }
}