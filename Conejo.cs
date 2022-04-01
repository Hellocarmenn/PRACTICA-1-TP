using System;
//using ProgramAnimales;


namespace Practica_1
{
   class Conejo : Animales
    {
      //  string Tortuga;
        
       // public void ImprimirPantallaAnimales()
        //{
          //  InicializarComponente();
                //{
            //    Tortuga = new string();
              //  Tortuga.Add(New Animales("Verde", "viviparo", "4", "tortuga", "omnivoro"));


                //}
        //}


        public void Animales(string Color, string Nacimiento, int Patitas, string Animal, string Alimentacion)
        {
            base.color = Color;
            base.nacimiento = Nacimiento;
            base.patitas = Patitas;
            base.animal = Animal;
            base.alimentacion = Alimentacion;


           
        }
        public Conejo()
        {
            string ojos;
            color = "Blanco";
            nacimiento = "viviparo";
            patitas = 4;
            animal = "Conejo";
            alimentacion = "Omnivaro";
            ojos = "azules";
            Console.WriteLine("animal: {0}", animal);
            Console.WriteLine("color: {0}", color);
            Console.WriteLine("nacimiento: {0}", nacimiento);
            Console.WriteLine("patitas: {0}", patitas);
            Console.WriteLine("animal: {0}", animal);
            Console.WriteLine("alimentacion: {0}", alimentacion);
            Console.WriteLine("ojos: {0}", ojos);

        }
    }
}
