using EspacioTareas;
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

Tarea Tarea1 = new Tarea(0, "Realizar backend de usuario", 15);
Tarea Tarea2 = new Tarea(1, "Realizar interfaz de inicio de sesion", 21);
Tarea Tarea3 = new Tarea(2, "Realizar interfaz de Registro", 10);

tareasPendientes.Add(Tarea1);
tareasPendientes.Add(Tarea2);
tareasPendientes.Add(Tarea3);
int encontrado;
MenuPrincipal(tareasPendientes, tareasRealizadas);





void MenuPrincipal(List<Tarea> tareasPendientes, List<Tarea> tareasRealizadas)
{
    int opcion1;
    do
    {
        System.Console.WriteLine("Selecciona la opción a realizar: \n 1. Mover Pendientes A Realizadas \n 2. Mostrar Tareas Pendientes \n 3. Mostrar Tareas Realizadas \n 0. Salir");

        if (int.TryParse(Console.ReadLine(), out opcion1))
        {
            switch (opcion1)
            {
                case 1:
                    MoverARealizadas();
                    break;
                case 2:
                    Mostrar(tareasPendientes);
                    break;
                case 3:
                    Mostrar(tareasRealizadas);
                    break;
                case 0:
                    Console.WriteLine("Finalizando programa...");
                    break;
                default:
                    System.Console.WriteLine("Opcion ingresada inválida");
                    break;
            }
        }
    } while (opcion1 != 0);

}
void MoverARealizadas()
{
    int opcion;
    do
    {
        encontrado = 0;
        Console.WriteLine("Escriba el ID de la Tarea Realizada o -1 para salir");
        Mostrar(tareasPendientes);
        System.Console.WriteLine("-1. Salir");
        if (int.TryParse(Console.ReadLine(), out opcion) && opcion != -1)
        {
            for (int i = 0; i < tareasPendientes.Count; i++)
            {

                if (tareasPendientes[i].TareaID == opcion)
                {
                    encontrado = 1;
                    tareasRealizadas.Add(tareasPendientes[i]);
                    tareasPendientes.Remove(tareasPendientes[i]);
                    break;
                }
            }
        }
        if (opcion != -1 && encontrado == 0)
        {
            Console.WriteLine("\n--ERROR ID NO ENCONTRADA--\n");
        }

    } while (opcion != -1);
}

void Mostrar(List<Tarea> Listado)
{
    System.Console.WriteLine("------LISTADO-----\n");
    foreach (Tarea elemeto in Listado)
    {
        System.Console.WriteLine($"{elemeto.TareaID}: {elemeto.Descripcion}");
    }
    System.Console.WriteLine("\n----------------\n");
}