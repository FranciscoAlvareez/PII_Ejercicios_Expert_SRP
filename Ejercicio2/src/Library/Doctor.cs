using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{    
    public class Doctor
    {
        public string Name{get;set;}
        public string PhoneNumber{get;set;}
        public string Especializacion{get;set;}
        public string Consultorio{get;set;}
        private List<AppointmentService> consultas{get;set;}
        public Doctor(string name, string numero, string especializacion, string consultorio)
        {
            this.Name=name;
            this.PhoneNumber=numero;
            this.Especializacion= especializacion;
            this.Consultorio = consultorio;
            this.consultas = new List<AppointmentService>();
        }
        public void AgendarCita(Person paciente, DateTime fechaHora)
        {
            AppointmentService consulta = new AppointmentService(fechaHora, paciente);
            consultas.Add(consulta);
            Console.WriteLine($"Se agendó una cita para {paciente.Name} con el Dr. {Name} el {fechaHora}");
        }
        public void GetConsultas()
        {
            Console.WriteLine($"Las consultas del Dr. {Name} son:");
            foreach (AppointmentService citas in consultas)
            {
                Console.WriteLine($"cita con {citas.Paciente.Name} a las {citas.FechaHora}");
            }
        }
    }
}