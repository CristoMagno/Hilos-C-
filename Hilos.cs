static void  miMensaje(Object o)
{
    int numHilo = Convert.ToInt32(o);
    Console.ForegroundColor= ConsoleColor.Cyan;
    Thread.Sleep(1000);
    Console.WriteLine("Enviado saludos desde el hilo{0},--> {1}", numHilo, numHilo * 2);
}
static void otroMensaje()
{
    Console.ForegroundColor= ConsoleColor.Yellow;
    Thread.Sleep(500);
    Console.WriteLine("Enviado saludos desde el hilo{0}",Thread.CurrentThread.ManagedThreadId);
}
Thread hilo1, hilo2, hilo3, hilo4, hilo5;
hilo1 = new Thread(miMensaje);// hilos sin parametros
hilo3 = new Thread(miMensaje);
hilo5 = new Thread(miMensaje);
hilo2 = new Thread(new ThreadStart(otroMensaje));//hilos
hilo4 = new Thread(new ThreadStart(otroMensaje));
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Mensaje desde el Main...");
hilo1.Start(1);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Mensaje desde el Main...");
hilo2.Start();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Mensaje desde el Main...");
hilo3.Start(2);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Mensaje desde el Main..");
hilo4.Start();

hilo5.Start(3);
