using System;

class Ventas
{
    static void Main(string[] args)
    {
        double totalCompra = 0;
        bool continuarCompra = true;

        Console.WriteLine("Bienvenido a la tienda Musical Nahomy's");

        while (continuarCompra)
        {
            Console.Write("Por favor, ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Por favor, ingrese su edad: ");
            string edad = Console.ReadLine();

            Console.WriteLine("Elija una de los siguientes instrumentos musicales:");
            Console.WriteLine("1. Liras");
            Console.WriteLine("2. Trombones");
            Console.WriteLine("3. Saxofones");
            Console.WriteLine("4. Trompetas");
            Console.WriteLine("5. Flautas");
            Console.WriteLine("6. Tarolas/Caja de 3");
            Console.WriteLine("7. Pianos");
            Console.WriteLine("8. Güiros");
            string categoria = Console.ReadLine();

            string producto;
            double precio = 0;
            double impuesto = 0;
            double descuento = 0;
            int cantidad = 0;

            if (categoria == "1")

            {
                Console.WriteLine("Tenemos los siguientes opciones de liras");
                Console.WriteLine("1. lira griega 2,000 Lps");
                Console.WriteLine("2. lira vikinga 4,500 Lps");
                Console.WriteLine("3. lira bajo 5,000 Lps");
                Console.WriteLine("4. lira tenor 5,520 Lps");
                Console.WriteLine("5. lira de concierto 6,000 Lps");
                Console.WriteLine("6. lira de metal 6,625 Lps");
                Console.WriteLine("porfavor elija el tipo de lira");
                producto = Console.ReadLine();
                impuesto = 2;

                if (producto == "1")
                {
                    precio = 2000;
                }
                else if (producto == "2")
                {
                    precio = 4500;
                }
                else if (producto == "3")
                {
                    precio = 5000;
                }
                else if (producto == "4")
                {
                    precio = 5520;
                }
                else if (producto == "5")
                {
                    precio = 6000;
                }
                else if (producto == "6")
                {
                    precio = 6625;
                }
                else
                {
                    Console.WriteLine("Lo sentimos el producto no esta disponible");
                }

            }

            else if (categoria == "2")
            {
                Console.WriteLine("Tenemos las siguentes opciones de trombones");
                Console.WriteLine("1.Trombón Piccolo o Sopranino 1,000 Lps");
                Console.WriteLine("2. Trombón Soprano 1,500 Lps");
                Console.WriteLine("3. Trombón Alto 1,525 Lps");
                Console.WriteLine("4. Trombón Tenor 2,000 Lps");
                Console.WriteLine("5. Trombón Bajo 2,500 Lps");
                Console.WriteLine("6. Trombón Contrabajo 2,525 Lps");
                Console.WriteLine("porfavor elija el tipo de trombones");
                producto = Console.ReadLine();
                impuesto = 0.10;

                if (producto == "1")
                {
                    precio = 1000;
                }
                else if (producto == "2")
                {
                    precio = 1500;
                }
                else if (producto == "3")
                {
                    precio = 1525;
                }
                else if (producto == "4")
                {
                    precio = 2000;
                }
                else if (producto == "5")
                {
                    precio = 2500;
                }
                else if (producto == "6")
                {
                    precio = 2525;
                }
                else
                {
                    Console.WriteLine("Lo sentimos el producto no esta disponible");
                }

            }
            else if (categoria == "3")
            {
                Console.WriteLine("Tenemos las siguientes opciones de saxofones");
                Console.WriteLine("1. sopranino en mi bemol 2.000 Lps");
                Console.WriteLine("2. sopranino en fa 2,300 Lps");
                Console.WriteLine("3. soprano en si bemol 2,600 Lps");
                Console.WriteLine("4. soprano en do 4,500 Lps");
                Console.WriteLine("5. alto en mi bemol 5,000 Lps");
                Console.WriteLine("6. tenor en si bemol 6,000 Lps");
                Console.WriteLine("porfavor elija el tipo de saxofones");
                producto = Console.ReadLine();
                impuesto = 0.0;
                if (producto == "1")
                {
                    precio = 2000;
                }
                else if (producto == "2")
                {
                    precio = 2300;
                }
                else if (producto == "3")
                {
                    precio = 2600;
                }
                else if (producto == "4")
                {
                    precio = 4500;
                }
                else if (producto == "5")
                {
                    precio = 5000;
                }
                else if (producto == "6")
                {
                    precio = 6000;
                }
                else
                {
                    Console.WriteLine("Lo sentimos el producto no esta disponible");
                }

            }
            else if (categoria == "4")
            {
                Console.WriteLine("Tenemos las siguientes opciones de trompetas");
                Console.WriteLine("1. Trompeta en do o en si ♭ 3,000 Lps");
                Console.WriteLine("2. Trompeta de varas. 3,500 Lps");
                Console.WriteLine("3. Trompeta piccolo. 4,000 Lps");
                Console.WriteLine("1. Trompeta baja. 4,500 Lps");
                Console.WriteLine("2. Trompeta pocket. 5,000 Lps");
                Console.WriteLine("3. Trompeta de llaves. 5,500 Lps");
                Console.WriteLine("porfavor elija el tipo de trompetas");
                producto = Console.ReadLine();
                impuesto = 15;

                if (producto == "1")
                {
                    precio = 3000;
                }
                else if (producto == "2")
                {
                    precio = 3500;
                }
                else if (producto == "3")
                {
                    precio = 4000;
                }
                else if (producto == "4")
                {
                    precio = 4500;
                }
                else if (producto == "5")
                {
                    precio = 5000;
                }
                else if (producto == "6")
                {
                    precio = 5500;
                }
                else
                {
                    Console.WriteLine("Lo sentimos el producto no esta disponible");
                }

            }
            else if (categoria == "5")
            {
                Console.WriteLine("Tenemos las siguientes opciones de flautas");
                Console.WriteLine("1. Flautín o flauta piccolo 100 Lps");
                Console.WriteLine("2. Flauta Sopranino. 200 Lps");
                Console.WriteLine("3. Flauta soprano. 300 Lps");
                Console.WriteLine("1. Flauta tenor. 400 Lps");
                Console.WriteLine("2. Flauta alto. 445 Lps");
                Console.WriteLine("3. Flauta bajo. 500 Lps");
                Console.WriteLine("porfavor elija el tipo de flautas");
                Console.ReadLine();
                producto = Console.ReadLine();
                impuesto = 22;
                if (producto == "1")
                {
                    precio = 100;
                }
                else if (producto == "2")
                {
                    precio = 200;
                }
                else if (producto == "3")
                {
                    precio = 300;
                }
                else if (producto == "4")
                {
                    precio = 400;
                }
                else if (producto == "5")
                {
                    precio = 445;
                }
                else if (producto == "6")
                {
                    precio = 500;
                }
                else
                {
                    Console.WriteLine("Lo sentimos el producto no esta disponible");
                }

            }
            else if (categoria == "6")
            {
                Console.WriteLine("Tenemos las siguientes opciones de tarolas/caja de 3");
                Console.WriteLine("1. Tambour militaire 1000 Lps");
                Console.WriteLine("2. Caisse claire. 2000 Lps");
                Console.WriteLine("3. Tambor militar. 3000 Lps");
                Console.WriteLine("1. Redoblante. 4000 Lps");
                Console.WriteLine("2. Caisse sourde. 4045 Lps");
                Console.WriteLine("3. Long drum. 5000 Lps");
                Console.WriteLine("porfavor elija el tipo de flautas");
                producto = Console.ReadLine();
                impuesto = 33;

                if (producto == "1")
                {
                    precio = 1000;
                }
                else if (producto == "2")
                {
                    precio = 2000;
                }
                else if (producto == "3")
                {
                    precio = 3000;
                }
                else if (producto == "4")
                {
                    precio = 4000;
                }
                else if (producto == "5")
                {
                    precio = 4045;
                }
                else if (producto == "6")
                {
                    precio = 5000;
                }
                else
                {
                    Console.WriteLine("Lo sentimos el producto no esta disponible");
                }

            }
            else if (categoria == "7")
            {
                Console.WriteLine("Tenemos las siguientes opciones de pianos");
                Console.WriteLine("1. Pianos acústicos 10,000 Lps");
                Console.WriteLine("2. Pianos electrónicos. 20,500 Lps");
                Console.WriteLine("3. Teclados. 30,550 Lps");
                Console.WriteLine("1. Media Cola. 40,000 Lps");
                Console.WriteLine("2. Pianos de escenario. 44,500 Lps");
                Console.WriteLine("3. Teclados Musicales. 50,000 Lps");
                Console.WriteLine("porfavor elija el tipo de flautas");
                producto = Console.ReadLine();
                impuesto = 7;

                if (producto == "1")
                {
                    precio = 10000;
                }
                else if (producto == "2")
                {
                    precio = 20500;
                }
                else if (producto == "3")
                {
                    precio = 30550;
                }
                else if (producto == "4")
                {
                    precio = 40000;
                }
                else if (producto == "5")
                {
                    precio = 44500;
                }
                else if (producto == "6")
                {
                    precio = 50000;
                }
                else
                {
                    Console.WriteLine("Lo sentimos el producto no esta disponible");
                }

            }
            else if (categoria == "8")
            {
                Console.WriteLine("Tenemos las siguientes opciones de flautas");
                Console.WriteLine("1. Carrasca colombiana 100 Lps");
                Console.WriteLine("2. Güícharo puertorriqueño. 200 Lps");
                Console.WriteLine("3. Güiro cubano. 300 Lps");
                Console.WriteLine("1. Churuca panameña. 400 Lps");
                Console.WriteLine("2. Güiros metálicos. 445 Lps");
                Console.WriteLine("3. Güiros de fibra de vidrio y madera. 500 Lps");
                producto = Console.ReadLine();
                impuesto = 0.0;

                if (producto == "1")
                {
                    precio = 100;
                }
                else if (producto == "2")
                {
                    precio = 200;
                }
                else if (producto == "3")
                {
                    precio = 300;
                }
                else if (producto == "1")
                {
                    precio = 400;
                }
                else if (producto == "2")
                {
                    precio = 445;
                }
                else if (producto == "3")
                {
                    precio = 500;
                }
                else
                {
                    Console.WriteLine("Lo sentimos el producto no esta disponible");
                }


                Console.WriteLine("Categoría no válida.");
                continue;
            }

            if (precio == 0)
            {
                Console.WriteLine("El producto seleccionado no está disponible.");
                continue;
            }

            Console.WriteLine($"El precio del instrumento seleccionado es: {precio} Lps");

            Console.Write("Ingrese la cantidad (máximo 100): ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            if (cantidad <= 0 || cantidad > 100)
            {
                Console.WriteLine("Cantidad no válida, por favor intente de nuevo.");
                continue;
            }

            if (cantidad >= 10 && cantidad <= 50)
                descuento = 0.05;
            else if (cantidad > 50)
                descuento = 0.10;

            double subtotal = precio * cantidad;
            double totalDescuento = subtotal * descuento;
            double totalImpuesto = subtotal * impuesto;
            double total = subtotal - totalDescuento + totalImpuesto;

            Console.WriteLine($"El subtotal es: {subtotal} Lps");
            Console.WriteLine($"Descuento aplicado: {totalDescuento} Lps");
            Console.WriteLine($"Impuesto aplicado: {totalImpuesto} Lps");
            Console.WriteLine($"El valor a pagar es de: {total} Lps");

            totalCompra += total;

            Console.WriteLine($"Total de la compra: {totalCompra} Lps");
            Console.WriteLine("Su compra ha sido exitosa.");

            Console.Write("¿Desea agregar más productos al carrito? (si/no): ");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta != "s")
            {
                continuarCompra = false;
            }
        }

        Console.WriteLine($"El total final de su compra es: {totalCompra} Lps");
        Console.WriteLine("Gracias por su compra. ¡Hasta la próxima!");
    }
}