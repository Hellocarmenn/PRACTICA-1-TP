using System;


namespace Practica_1
{


    internal abstract class Animales
    {
        #region atributos
        internal string color;
        internal string nacimiento;
        internal int patitas;
        internal string animal;
        internal string alimentacion;
        #endregion


       #region Contructor
        
        public Animales()
        {
            color = "cafe";
            nacimiento = "viviparo";
            patitas = 4;
            animal = "gato";
            alimentacion = "omnivaro";
            Console.WriteLine("animal: {0}", animal);
            Console.WriteLine("color: {0}", color);
            Console.WriteLine("nacimiento: {0}", nacimiento);
            Console.WriteLine("patitas: {0}", patitas);
            Console.WriteLine("animal: {0}", animal);
            Console.WriteLine("alimentacion: {0}", alimentacion);
            
        }
       
        #endregion
    



        public Animales(string Color,string Nacimiento, int Patitas,string Animal,string Alimentacion)
        {
            this.color = Color;
            this.nacimiento = Nacimiento;
            this.patitas = Patitas;
            this.animal = Animal;
            this.alimentacion = Alimentacion;
        }
        #region Encapsulamiento
        public string Color { get; internal set; }
        public bool Nacimiento { get; internal set; }
        public bool Patitas { get; internal set; }
        public string Animal { get; internal set; }
        public string Alimentacion { get; internal set; }
        #endregion

        #region Metodos

     
        public void ImprimirPantallaAnimales()
        {
            Console.WriteLine("Bienvenido al programa de animalitos");
        
        }
        public void selAnimal()
        {

            Console.WriteLine("El animal es : ", animal);

        }
        public void Habitad()
        {
          

            Console.WriteLine("El habita de este animal es",color);

        }
        public void numPatitas()
        {
            
            Console.WriteLine("El numero de patitas es: ", patitas);

        }

        public void tipo()
        {

            Console.WriteLine("El nacimiento de este animalito es : ", nacimiento);

        }
        public void tipoAlimentacion()
        {

            Console.WriteLine("Tipo de alimentacion : ", alimentacion);

        }
        #endregion

    }



}
