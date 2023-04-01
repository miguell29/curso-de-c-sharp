namespace EjercicioInterfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Superman superman = new Superman();
            Boing747 boing747 = new Boing747();
            TorreDeControl torreDeControl = new TorreDeControl();

            torreDeControl.AgregarVolador(pato);
            torreDeControl.AgregarVolador(superman);
            torreDeControl.AgregarVolador(boing747);

            torreDeControl.VuelenTodos();
            Console.ReadKey();
        }
    }
}