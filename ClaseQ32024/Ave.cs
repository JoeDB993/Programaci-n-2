
namespace ClaseQ32024
{
    public class Ave
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public FamiliaAve FamiliaAve { get; set; }
        public string SexoBiologico { get; set; }
        public bool EsVoladora { get; set; }


        //Constructor 
        public Ave()
        {
            EsVoladora = true;
            FamiliaAve = new FamiliaAve();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Size}");
            Console.WriteLine($"Nombre de Familia: {FamiliaAve.Nombre}");
            Console.WriteLine($"Nombre de Grupo: {FamiliaAve.Grupo}");
            Console.WriteLine($"Sexo Biológico: {SexoBiologico}");
            Console.WriteLine($"Es Voladora: {(EsVoladora ? "Si" : "No")}");
            Console.WriteLine();


        }
    }
}
