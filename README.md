# Nombre del proyecto: <em> # AeroDrago Airlines </em>

# Nombre del Repositorio: Brito.Eduard.2D_PrimerParcial_Laboratorio.II

*[Desarrolladores del Proyecto](#desarrolladores)
# Eduard Brito - Developer
Soy un desarrollador de aplicaciones de escritorio, siendo especialista en el desarrollo bajo los lenguajes de C, C# y JavaScript, en mis ratos libres aprendo sobre tecnologías de inteligencia artificial y programación de videojuegos. Este proyecto me fue muy desafiante por el contexto de negocio que involucra a una Aerolínea.

*[Descripción del proyecto](#descripción-del-proyecto):

Se desarrollo una aplicación de escritorio en lenguaje de C# para gestionar la carga de vuelos y venta de pasajes de la Aerolínea AeroDrago. Para usarla se debe loguear con algunos de los usuarios precargados, a modo de prueba puede loguearse con el usuario: 1 password: 1.

![image](https://user-images.githubusercontent.com/60559234/193750014-5a176f4d-99b8-4296-be27-135c6669153e.png)

*[Características de la aplicación y demostración](#Características-de-la-aplicación-y-demostración): 

Cuenta con un menú principal donde se encuentran las siguientes funcionalidades:

Cerrar Sesión: Cierra la sesión del usuario logueado y vuelve al menú de logueo.

Salir: Cierra la aplicación.

Mostrar Vuelos: Permite mostrar el listado de vuelos y a su vez poder dar de alta un vuelo.

Vender Pasajes: Permite cargar pasajeros a un vuelo activo y gestionar la venta del pasaje.

![image](https://user-images.githubusercontent.com/60559234/193747854-95fd8a73-b49e-4388-a2c2-5ca9eea73890.png)
![image](https://user-images.githubusercontent.com/60559234/193748076-d7b5cd05-aa68-4ab7-850a-26d534dbcc13.png)
![image](https://user-images.githubusercontent.com/60559234/193748187-6b4a5aea-4027-4629-9831-a8d29de399d4.png)
![image](https://user-images.githubusercontent.com/60559234/193748238-f629ebf3-49dc-4f8a-ae41-01e9c50c8d26.png)
![image](https://user-images.githubusercontent.com/60559234/193748572-68565c24-f6dd-4de2-ad11-c4b88f9bed2e.png)

*[Diagrama de Clases](#diagrama-de-clases):

![image](https://user-images.githubusercontent.com/60559234/193754542-a4686267-39e8-4b3c-9c8e-7a4211838184.png)

*[Justificación Técnica](#Justificación-Técnica):

  * Herencia: se aplica en la clase Vuelo (clase base) con las clases VueloNacional (clase derivada) y VueloInternacional (clase derivaba).
  * Sobrecarga de constructores y métodos: En la clase Aeronave, Vuelo, VueloNacional, VueloInternacional.
  * Propiedades: En las clases Aeronave, Vuelo, Producto, Usuario, VueloNacional, VueloInternacional.
  * Colecciones: En la clase DatosNegocio.
  * Enumerados: En la clase Vuelo y Pasajero.
  * Formularios modal: En los Formularios Login y AltaVuelo con el de MenuPrincipal.
  * Clases estáticas: En la clase DatosNegocio
  * Polimorfismo (clases abstractas, métodos abstractos): En la clase abstracta Vuelo y en las clases VueloNacional y VueloInternacional (derivadas).

