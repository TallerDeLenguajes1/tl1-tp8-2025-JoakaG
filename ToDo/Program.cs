using EspacioTareas;
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

Tarea Tarea1 = new Tarea(0, "Realizar backend de usuario", 15);
Tarea Tarea2 = new Tarea(1, "Realizar interfaz de inicio de sesion", 21);
Tarea Tarea3 = new Tarea(2, "Realizar interfaz de Registro", 10);

tareasPendientes.Add(Tarea1);
tareasPendientes.Add(Tarea2);
tareasPendientes.Add(Tarea3);
int encontrado = 0;
int opcion;
do
{
    Console.WriteLine("Escriba el ID de la Tarea Realizada o -1 para salir");
    foreach (Tarea tareapen in tareasPendientes)
    {
        Console.WriteLine($"{tareapen.TareaID}: {tareapen.Descripcion}");
    }
    if (int.TryParse(Console.ReadLine(), out opcion) && opcion != -1)
    {
        for (int i = 0; i < tareasPendientes.Count; i++)
        {
            if (tareasPendientes[i].TareaID == opcion)
            {
                encontrado = 1;
                tareasPendientes.Remove(tareasPendientes[i]);
            }
        }
        continue;
    }
    if (opcion != -1 && encontrado == 0)
    {
        Console.WriteLine("Porfavor selecciona una opción Válida");
    }

} while (opcion != -1);
Console.WriteLine("Finalizando programa...");