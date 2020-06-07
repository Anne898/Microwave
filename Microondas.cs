using System;

namespace microwave
{
    class Microondas
    {
        private bool puertaAbierta = false;
        Contenedor comida = null; //algo as


        //microondas.puertaAbierta = true X
        //microondas.AbrirPuerta()


        public void AbrirPuerta()
        {
            System.Console.WriteLine("Puerta abierta");
            this.puertaAbierta = true;

        }
   
        public void AlimentoIn(Contenedor contenedor)
        {
            //Revisar si hay un contenedor (si no está vacío) ya dentro del microondas
            //null => no hay nada adentro

            if (this.comida != null)
            {
                //Estado actual incorrecto - InvalidOperationException
                //Argumento inválido - ArgumentException
                throw new InvalidOperationException("existe comida adentro");
            }
            Console.WriteLine("Alimento introducido");
    
            //this => variable del objeto
            this.comida = contenedor;

        }

        public void CerrarPuerta()
        {
            System.Console.WriteLine("Cerrar puerta");
            this.puertaAbierta = false;
        }




    }
}