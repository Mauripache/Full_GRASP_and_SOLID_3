namespace Full_GRASP_And_SOLID.Library
{

       /*
        Se decidió definir la interfaz IPrinter, pues de la manera en que estaba hecho AllInOnePrinter,
        hacía precisamente lo que el patrón Polimorfismo decía que no hay hacer; tener dos bloques de código
        para preguntarse por el tipo (en este caso, si el texto de la receta se imprimiría por consola o a través
        de un File).

        A raíz de esto, se decidió crear dos nuevas clases llamadas ConsolePrinter y FilePrinter, y que ambas 
        implementaran esta interfaz, implementando así el método polimórfico Print.

        De esta manera, cualquier clase que implemente esta interfaz podrá ser intercambiada con ConsolePrinter o 
        FilePrinter y será posible imprimir el texto sin afectar el codigo (LSP).

        Tambien esta interfaz permite agregar nuevas maneras de imprimir sin modificar el 
        codigo ya existente, asi cumpliendo con el principio OCP.
    */
    public interface IPrinter
    {
        void Print(Recipe recipe);
    }
}
