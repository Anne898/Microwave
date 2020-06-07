using System;

namespace Microwave
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
Simular un microondas utilizando principios de programación orientada a objetos.
Se deben utilizar las siguientes clases / objetos:
Microondas (Microwave)
Contenedor (Container)
Comida (Food)
El microondas deberá contar con métodos para representar las acciones que son posibles al interactuar con el; ej. AbrirPuerta().
Incluir un menú para realizar las acciones del microondas, y para seleccionar la comida a utilizar.
Las comidas pueden ser opciones fijas (ej. 3 opciones pre-configuradas), siempre y cuando permitan probar casos de error y casos de éxito.
Si se intenta realizar una acción incorrecta, como por ejemplo introducir comida sin abrir la puerta, debe arrojar excepciones apropiadas con un mensaje significativo.
El contenedor puede o no ser apto para microondas, y por tanto se debe arrojar una excepción según sea necesario.
Funcionalidad adicional (completamente opcional)
Que un contenedor pueda tener o no un cubierto

            */

            Menu menu = new Menu();
            menu.Display();      

        }
    }
}
