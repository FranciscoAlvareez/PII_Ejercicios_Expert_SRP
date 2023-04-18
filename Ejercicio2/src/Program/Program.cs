using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor Pedro= new Doctor("pedro", "094429458", "Ginecologo", "Britanico");
            Person Juano = new Person("Juano", "093946783", "Av 8 de octubre 2766");
            DateTime fecha= new DateTime(2023, 5, 12);
            Pedro.AgendarCita(Juano, fecha);
            Pedro.GetConsultas();
        }
    }
}
