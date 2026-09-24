using System;

class Damas
{
    const string NoJugable = "⬜";
    const string Vacia = "⬛";
    const string Roja = "🔴";
    const string Negra = "🟤"; //⚫
    const string RojaRey = "♕";
    const string NegraRey = "♛";  
    const int Tamano = 8;
 
    //Tamaño del tablero
    static string[,] tablero = new string[Tamano, Tamano];
 
    //Bloque principal del juego
    static void Main()
    {
        InicializarTablero();
        ImprimirTablero();
 
        Console.WriteLine("Casillas validas ⬛");
        Console.WriteLine("Casillas invalidas ⬜");
        Console.WriteLine("Escriba -salir- para terminar el juego en cualquier momento");
 
        //Bucle del juego
        while (true)
        {
            // La fila de origen es donde también se puede escribir 'salir'
            if (!Coordenada("Ingrese fila actual: ", out int filaOrigen, permitirSalir: true))break;
 
            Coordenada("Ingrese columna actual: ", out int colOrigen);
            Coordenada("Ingrese fila deseada: ", out int filaDestino);
            Coordenada("Ingrese columna deseada: ", out int colDestino);
 
            //Intentaa mover la ficha en caso de que se pueda reimprime el tablero
            if (IntentarMover(filaOrigen, colOrigen, filaDestino, colDestino))
            {
                Console.WriteLine("");
                ImprimirTablero();
            }
        }
        Console.WriteLine("Saliendo...");
    }
 
    // coloca las fichas en el tablero las cuale solo ocupan casillas nergras en donde a suma de la fila y columna sean impar
    // el ++ hace que incremente en 1 la variabe
    static void InicializarTablero()
    {
        for (int fila = 0; fila < Tamano; fila++)
        {
            for (int col = 0; col < Tamano; col++)
            {
                if ((fila + col) % 2 == 1)
                {
                    // Las filas 0-2 reciben fichas negras
                    if (fila < 3)
                        tablero[fila, col] = Negra;
                    // Las filas 5-7 reciben fichas rojas
                    else if (fila > 4)
                        tablero[fila, col] = Roja;
                    // Las filas 3-4 son casillas jugables vacías
                    else
                        tablero[fila, col] = Vacia;
                }
                else
                {
                    // Las casillas blancas no son jugables
                    tablero[fila, col] = NoJugable;
                }
            }
        }
    }
 
    // imprime el tablero en la consola se reducio en 1 espacio pq los emojis abarcan 2
    static void ImprimirTablero()
    {
        Console.WriteLine();

        Console.Write("    ");
        for (int col = 0; col < Tamano; col++)
            Console.Write(" " + col + "  ");
        Console.WriteLine();
 
        // Imprimir el borde superior del tablero
        Console.WriteLine("   ┌" + new string('-', Tamano * 4) + "┐");
 
        for (int fila = 0; fila < Tamano; fila++)
        {
            Console.Write(" " + fila + " |");
 
            for (int col = 0; col < Tamano; col++)
            {
                Console.Write(" " + tablero[fila, col] + " ");
            }
            Console.WriteLine("|");
        }
 
        // Imprimir la parte inferior del tablero
        Console.WriteLine("   └" + new string('-', Tamano * 4) + "┘");
        Console.WriteLine();
    }
 
    //Pide un numero y valida que si lo sea
    static bool Coordenada(string mensaje, out int valor, bool permitirSalir = false)
    {
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();
 
            if (permitirSalir)
            {
                if (entrada == "salir")
                {
                    valor = 0;
                    return false;
                }
            }
 
            if (int.TryParse(entrada, out valor))
            {
                if (valor >= 0)
                {
                    if (valor < Tamano)
                        return true;
                }
            }
 
            Console.WriteLine("Movimiento invalido solo ingresar del 0-7");
        }
    }
 
    // indica los bandos de las fichas o sea roja o negra o "" si la casilla no tiene una ficha
    static string Bando(string ficha)
    {
        if (ficha == Roja || ficha == RojaRey)
            return "Roja";
 
        if (ficha == Negra || ficha == NegraRey)
            return "Negra";
 
        return "";
    }
 
    //marca si na ficha ya esta coronada
    static bool EsRey(string ficha)
    {
        return ficha == RojaRey || ficha == NegraRey;
    }
 
    // Valida y ejecuta un movimiento
    // Intenta mover una ficha de origen a destino
    // Si el movimiento fue realizado exitosamente retorna true sino retorna false
    static bool IntentarMover(int filaOrigen, int colOrigen, int filaDestino, int colDestino)
    {
        string origen = tablero[filaOrigen, colOrigen];
 
        // La casilla de origen debe contener una ficha real
        if (origen == Vacia || origen == NoJugable)
        {
            Console.WriteLine("No hay ficha en la ubicacion deseada");
            return false;
        }
 
        string destino = tablero[filaDestino, colDestino];
 
        // la casilla donde se desea mover debe ser jugable sino es una casilla invalida
        if (destino == NoJugable)
        {
            Console.WriteLine("Casilla invalida");
            return false;
        }
 
        if (destino != Vacia)
        {
            Console.WriteLine("La casilla deseada esta ocupadapada");
            return false;
        }
 
        // el movimiento debe ser en diagonl por lo que la fila y columnas se deben cambiar la misma cantidad de casillas
        int filas = filaDestino - filaOrigen;
        int columnas = colDestino - colOrigen;
 
        if (Math.Abs(filas) != Math.Abs(columnas))
        {
            Console.WriteLine("El movimiento debe ser diagonal");
            return false;
        }
 
        // Las fichas normales solo avanzan en diagonal
        // las negras bajan por lo que su fila aumenta y las negras suben por lo que las rojas se hace mas chica
        if (!EsRey(origen))
        {
            bool avanzaAdelante = false;
 
            if (Bando(origen) == "Negra")
            {
                if (filas > 0)
                    avanzaAdelante = true;
            }
            else if (Bando(origen) == "Roja")
            {
                if (filas < 0)
                    avanzaAdelante = true;
            }
 
            if (!avanzaAdelante)
            {
                Console.WriteLine("Esa ficha no puede moverse hacia atras");
                return false;
            }
        }
 
        if (Math.Abs(filas) == 1)
        {
            // Movimiento simple de una casilla, sin captura
            tablero[filaDestino, colDestino] = origen;
            tablero[filaOrigen, colOrigen] = Vacia;
        }
        else if (Math.Abs(filas) == 2)
        {
            // Posible captura: la ficha de en medio debe ser del rival
            int filaMedio = filaOrigen + filas / 2;
            int colMedio = colOrigen + columnas / 2;
            string enMedio = tablero[filaMedio, colMedio];
 
            bool esRival = false;
 
            if (Bando(enMedio) != "")
            {
                if (Bando(origen) != Bando(enMedio))
                    esRival = true;
            }
 
            if (!esRival)
            {
                Console.WriteLine("No hay una ficha para comer en esa dirección");
                return false;
            }
 
            // Comer la ficha rival y mover la propia al destino
            tablero[filaMedio, colMedio] = Vacia;
            tablero[filaDestino, colDestino] = origen;
            tablero[filaOrigen, colOrigen] = Vacia;
 
            Console.WriteLine("Ficha comida");
        }
        else
        {
            Console.WriteLine("Solo puedes mover 1 casilla, o 2 para comer una ficha solo derecha e izquierda");
            return false;
        }
 
        //si una ficha normal llega a la última fila del rival se vuelve rey
        if (Bando(origen) == "Roja")
        {
            if (!EsRey(origen))
            {
                if (filaDestino == 0)
                {
                    tablero[filaDestino, colDestino] = RojaRey;
                    Console.WriteLine("Ficha roja coronada");
                }
            }
        }
        else if (Bando(origen) == "Negra")
        {
            if (!EsRey(origen))
            {
                if (filaDestino == Tamano - 1)
                {
                    tablero[filaDestino, colDestino] = NegraRey;
                    Console.WriteLine("Ficha negra coronada");
                }
            }
        }
        return true;
    }
}