using System;

namespace DPRN2_U2_EA_JHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atributos estudiante
            Estudiante es = new Estudiante();
            es.NombreCompleto = "Margarita Sanchez";
            es.Edad = 15;
            es.Domicilio = "Calle 33 x 24";
            es.Telefono = "1345889";
            es.Promedio = 7;
            es.Grado = "3ro";
            es.Grupo = "C";
            es.mostrar();

            //Atributos profesores
            Profesores pr = new Profesores();
            pr.Grupo = "C";
            pr.NombreCompleto = "Pedro Páramo";
            pr.NumNomina = 88987;
            pr.SueldoHora = 180;
            pr.Antiguedad = "5 años";
            pr.HorasTrabajadas = 60;
            pr.mostrar();

            //Atributos padres de familia
            PadresFamilia fam = new PadresFamilia();
            fam.NumHijos = 2;
            fam.Telefono = "2584489";
            fam.Celular = "0459854122";
            fam.Email = "family@gmail.com";
            fam.Promedio = es.Promedio;
            fam.mostrar();
            fam.avisar();

        }
    }

    abstract class Escuela
    {
        protected String nombreCompleto;
        public String NombreCompleto
        {
            set { this.nombreCompleto = value; }
            get { return this.nombreCompleto; }
        }

        protected int edad;
        public int Edad
        {
            set { this.edad = value; }
            get { return this.edad; }
        }

        protected String domicilio;
        public String Domicilio
        {
            set { this.domicilio = value; }
            get { return this.domicilio; }
        }

        protected String telefono;
        public String Telefono
        {
            set { this.telefono = value; }
            get { return this.telefono; }
        }

        protected Double promedio;
        public Double Promedio
        {
            set { this.promedio = value; }
            get { return this.promedio; }
        }


        abstract public void mostrar();

    }

    class Estudiante : Escuela
    {


        protected String grado;
        public String Grado
        {
            set { this.grado = value; }
            get { return this.grado; }
        }

        protected String grupo;
        public String Grupo
        {
            set { this.grupo = value; }
            get { return this.grupo; }
        }


        override public void mostrar()
        {
            System.Console.WriteLine("******Datos Estudiante*******");
            System.Console.WriteLine("Nombre completo: " + nombreCompleto);
            System.Console.WriteLine("Edad: " + edad);
            System.Console.WriteLine("Domicilio: " + domicilio);
            System.Console.WriteLine("Telefono: " + telefono);
            System.Console.WriteLine("Promedio: " + promedio);
            System.Console.WriteLine("Grado: " + grado);
            System.Console.WriteLine("Grupo: " + grupo);
        }
    }

    class Profesores : Escuela
    {


        protected String grupo;
        public String Grupo
        {
            set { this.grupo = value; }
            get { return this.grupo; }
        }

        protected int numNomina;
        public int NumNomina
        {
            set { this.numNomina = value; }
            get { return this.numNomina; }
        }

        protected int sueldoHora;
        public int SueldoHora
        {
            set { this.sueldoHora = value; }
            get { return this.sueldoHora; }
        }

        protected String antiguedad;
        public String Antiguedad
        {
            set { this.antiguedad = value; }
            get { return this.antiguedad; }
        }

        protected int horasTrabajadas;
        public int HorasTrabajadas
        {
            set { this.horasTrabajadas = value; }
            get { return this.horasTrabajadas; }
        }



        override public void mostrar()
        {
            System.Console.WriteLine("\n*****Datos profesor*****");
            System.Console.WriteLine("El nombre del profesor es: " + nombreCompleto);
            System.Console.WriteLine("Grupo: " + grupo);
            System.Console.WriteLine("Número de nómina: " + numNomina);
            System.Console.WriteLine("Sueldo por hora: " + sueldoHora);
            System.Console.WriteLine("Antigüedad: " + antiguedad);
            System.Console.WriteLine("Horas trabajadas: " + horasTrabajadas);
        }

    }

    class PadresFamilia : Escuela
    {

        protected int numHijos;
        public int NumHijos
        {
            set { this.numHijos = value; }
            get { return this.numHijos; }
        }

        protected String celular;
        public String Celular
        {
            set { this.celular = value; }
            get { return this.celular; }
        }

        protected String email;
        public String Email
        {
            set { this.email = value; }
            get { return this.email; }
        }

        override public void mostrar()
        {
            System.Console.WriteLine("\n****Datos Padres de familia****");
            System.Console.WriteLine("Número de hijos: " + numHijos);
            System.Console.WriteLine("Teléfono: " + telefono);
            System.Console.WriteLine("Celular: " + celular);
            System.Console.WriteLine("Email: " + email);
            System.Console.WriteLine("Promedio: " + promedio);
        }

        public void avisar()
        {
            System.Console.WriteLine("\n****Mensaje a padres de familia****");
            if (promedio <= 6)
            {
                System.Console.WriteLine("Su hijo está reprobado");
            }
           else if (promedio > 9.5)
            {
                System.Console.WriteLine("Su hijo ha obtenido una beca");
            }
           else
            {
                System.Console.WriteLine("Sin comentarios");
            }
        }


    }

}
