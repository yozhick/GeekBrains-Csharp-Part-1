/*
  *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
  
    Михайлов Дмитрий Викторович
 */



namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleConsole sc = new SimpleConsole();
            sc.Print("Привет, мир!");
            sc.Pause(false);
            sc.Pause(true);
        }
    }
}
