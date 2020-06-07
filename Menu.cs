using System;
using System.Collections.Generic;

namespace microwave
{
    class Menu
    {
       private const int MAIN_MENU_EXIT_OPTION = 9;
        private const int GO_BACK_OPTION = 9;
        List<int> mainMenuOptions = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 9 }); //opciones del micro
        bool microAbierto = false;
        Microondas micro = new Microondas();

        List<int> selectFoodOptions = new List<int>(new int[] {1, 2, 3, 9});
        private Contenedor tipoComida = null;

        //public List<Camiones> listaCamiones = new List<Camiones>(); //lista de camiones 
        //public List<string> listaRutas = new List<string>();

        private void DisplayWelcomeMessage() //mensaje de bienvenida
        {
            System.Console.WriteLine("Microondas");
            System.Console.WriteLine();

        }

        private void DisplayMainMenuOptions() //opciones del menu
        {
            System.Console.WriteLine("1) Abrir Micro");
            System.Console.WriteLine("2) Seleccionar Contenedor");
            System.Console.WriteLine("3) Seleccionar comida");
            System.Console.WriteLine("4) Colocar comida");
            System.Console.WriteLine("5) Cerrar Micro");
            System.Console.WriteLine("6) Calentar comida");
            System.Console.WriteLine("7) Sacar Comida");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        private void DisplaySelectFoodOptions() {
            System.Console.WriteLine("1) Pizza de hace una semana"); 
            System.Console.WriteLine("2) Burrito");
            System.Console.WriteLine("3) Un atun en lata");
            System.Console.WriteLine("9) Volver"); 
                    
        }

        private void SelectFoodType() {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION) {
                System.Console.WriteLine("¿Que comida quieres?");
                DisplaySelectFoodOptions();
                System.Console.WriteLine($"Tipo de Comida seleccionada: {tipoComida}");

                selectedOption = RequestOption(selectFoodOptions);

                /*
                System.Console.WriteLine("1) Pizza de hace una semana"); 
                System.Console.WriteLine("3) Un atun en lata");
            */
                switch (selectedOption)
                {
                    case 1: //Pizza de hace una semana
                        tipoComida = "Regular";
                        break;
                    case 2: //Burrito
                        tipoComida = "Waffle";
                        break;
                    case 3: //Un atun en lata
                        tipoComida = "Waffle";
                        break;
                } //el break se sale de este switch
            }
        }

        private void DisplayByeMessage() //mensaje de adios
        { //mensaje de despedida
            System.Console.WriteLine("¡Hasta luego!");
        }

        private int RequestOption(List<int> validOptions) //opciones validas
        {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida...
            while (!isUserInputValid)
            {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                }
                catch (System.Exception)
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

        // acciones
        private void AbrirMicro() //ingreso de los camiones
        {
            DisplayWelcomeMessage();
            micro.AbrirPuerta();


        }

        private void ColocarComida() //quitar el primer camion
        {


        }

        private void CerrarMicro() //Imprimir todos los camiones
        {

            micro.CerrarPuerta(); 

        }

        private void CalentarComida()
        {




        }

        private void SacarComida()
        {




        }

        public void Display()  //Menu 
        {
            int selectedOption = 0;

            DisplayWelcomeMessage();

            while (selectedOption != MAIN_MENU_EXIT_OPTION)
            {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1: // Ingreso de camión
                        AbrirMicro();
                        break;

                    case 2: //Salida de camión
                        ColocarComida();
                        break;

                    case 3:
                        CerrarMicro();
                        break;

                    case 4:
                        CalentarComida();
                        break;

                    case 5:
                        SacarComida();
                        break;

                    case 9:
                        selectedOption = MAIN_MENU_EXIT_OPTION;
                        break;
                        // default:
                }
            }

            DisplayByeMessage();

        }


    }
}