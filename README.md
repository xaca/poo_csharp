# Programación y diseño orientado a objetos PDOO

# 05 curso poo Sobrecarga, sobreescritura, clase abstracta

Pabras clave: override, virtual, abstract, sobrecarga, sobreescritura

- [Compilar en consola](http://zetcode.com/lang/csharp/csharp/)
- [https://www.c-sharpcorner.com/UploadFile/2072a9/virtual-vs-override-vs-new-keywords-in-csharp/]Virtual vs Override vs New Keywords in C#()
- [https://www.dotnettricks.com/learn/csharp/understanding-virtual-override-and-new-keyword-in-csharp](Understanding virtual, override and new keyword in C#)

# 04 curso poo Herencia

Palabras clave: casting, herencia, polimorfismo, polimorphic

# 03 curso poo Valores por defecto - constructores

- ¿Qué es un constructor?
- Constructor por defecto
- Firma de un constructor
- Palabra reservada this
- Relaciones entre clases
- Ejercicios

Palabras clave: class, constructor, constructores, default, defecto, valores, values

# 02 curso poo Clase - Objeto

- ¿Qué es una clase?
- ¿Qué es un objeto?
- Operaciones básicas
- Encapsulamiento
- Alta cohesión
- Bajo acoplamiento
- Ejercicios

Palabras clave: c#, clases, class, csharp, object, objetos

# 01 curso poo Funciones 

- ¿Qué es una función?
- Firma de la función
- Contexto de la función
- Invocación de una función
- Caja negra
- Caja blanca
- Tipos de funciones
- Ejercicios

Palabras clave: c#, csharp, funciones, function

Ejemplos de clase usando el lenguaje de programación C#

Tercera entrega de la serie
05 OOP C# Autoreferencia (this) y Relaciones entre clases
http://bit.ly/pdoo_xaca

Notas, relaciones entre clases:

Fuente: 
+ [Ingeniería de software - Karla Cevallos](https://ingsotfwarekarlacevallos.wordpress.com/2015/07/02/uml-relaciones-entre-clases/)  
+ [Diagrama de clases - Wikipedia](https://es.wikipedia.org/wiki/Diagrama_de_clases)  

El diagrama de clases debe crearse con la mayor independencia posible de la implementación del sistema final.

[¿Qué es multiplicidad?](http://ayudasydemascosas.blogspot.com/2016/05/modelado-de-datos-con-uml.html)

Indica cuántas instancias de una clase pueden asociarse con las otras clases de la relación, se escribe usando la notación M..N, donde M es el límite inferior y N, el superior.

+ Si el limite inferior es 0, la asociación es opcional. Si el límite inferior es 1 o superior implica que la asociación es obligatoria y como mínimo han de ocurrir ese número de instancias.    
+ El limite superior puede estar acotado por un número exacto o ser indefinido. En este último caso se usa el símbolo * (asterisco)  
+ Si ambos limites coinciden, se colapsan en un único número. Por ejemplo 1..1 pasa a ser 1.

Relaciones

Asociaciones: Simple, Inversa, Reflexiva, Agregación, Composición

Herencia: Especificación, Generalización (Más adelante)

Las asociaciones representan las relaciones más generales entre clases, es decir, las relaciones con menor contenido semántico. Para UML una asociación va a describir un conjunto de vínculos entre las instancias de las clases.

La forma de representar las asociaciones binarias en UML es mediante una línea que conecta las dos clases. En general, las asociaciones son bidireccionales, esto es, no tienen un sentido asociado.

Asociación

Familia de enlaces, asociación binaria, se representa con una línea continua. Puede relacionar cualquier número de clases. Se le puede asignar un nombre, y en sus extremos se puede hacer indicaciones, como el rol que desempeña la asociación, los nombres de las clases relacionadas, su multiplicidad, su visibilidad y otras propiedades.

Composición

Implica que los componentes de un objeto sólo pueden pertenecer a un solo objeto agregado, de forma que cuando el objeto agregado es destruido, todas sus partes son destruidas también.

+ Para representar el todo y sus partes  
+ Si se elimina el contenedor, el contenido también es eliminado  

Empresa - Empleado La relación se representa con un rombo relleno - diamante :)

Agregación - Agrupación (tiene un)

La agregación es una asociación con unas connotaciones semánticas más definidas, es más especifica: la agregación es la relación parte-de, que presenta a una entidad como un agregado de partes (en orientación a objeto, un objeto como agregado de otros objetos). Debe ser una asociación binaria.

+ Si se elimina una clase no es necesario eliminar otra que tenga relación  
+ Si se elimina el contenedor, el contenido usualmente no se destruye 
+ Clasifica o cataloga contenido para distinguilo del todo (contenedor)  

Empresa - cliente La relación se representa como un rombo sin relleno


