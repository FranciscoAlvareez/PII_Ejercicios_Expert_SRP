using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        private int IdConsulta=0;
        public DateTime FechaHora { get; set; }
        public Person Paciente { get; set; }

        public AppointmentService(DateTime fechaHora, Person paciente)
        {
            this.IdConsulta=+1;
            this.FechaHora = fechaHora;
            this.Paciente = paciente;
        }
    }
}
