using System;
using System.Collections.Generic;
using System.IO;

namespace Jesus
{
    public class Investigalacasa
    {
        static void Main()
        {
            List<string> cositas = new List<string>();
            bool Salirgame = false;
            
            while (!Salirgame)
            {
                Console.WriteLine("-=Investiga la casa=-");
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Salir");
                Console.Write("Elegiste: ");

                int opcionmenup = 0;
                try
                {
                    opcionmenup = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Este juego usará solo números");
                    Console.ReadKey();
                    continue;
                }

                if (opcionmenup == 1)
                {
                    Console.WriteLine("---Bienvenido---");
                    Console.WriteLine("--- Aqui....---");
                    Console.WriteLine("===Mejor te cuento de cero.");
                    Console.WriteLine("Eres un investigador que se unio ayer, Eres nuevo asi que no hay mejor forma de aprender con completar un trabajo tu solo");
                    Console.WriteLine("Bueno, Que dices?");
                    Console.Write("Vamos...");
                    Console.ReadKey();
                    Console.Clear();

                    bool Jugar = true;
                    
                    while (Jugar)
                    {
                        Console.WriteLine("1. Quieres entrar a la casa por la puerta principal?");
                        Console.WriteLine("2. O por el patio?");
                        Console.Write("Elige bien: ");
                        
                        int opcionmenus = 0;
                        try
                        {
                            opcionmenus = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Solo Numeros");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }

                        if (opcionmenus == 1)
                        {
                            Console.WriteLine("===Entras por la puerta principal===");
                            Console.WriteLine("==Estas listo?==");
                            for (int i = 0; i <= 100; i++)
                            {
                                Console.WriteLine($"Me gusta la carga..:{i}");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Estas en el porche de la casa");
                            Console.WriteLine("Lo siento no esta disponible todavia...");
                            Console.ReadKey();
                            Salirgame = true;
                            Jugar = false;
                        }
                        else
                        {
                            Console.WriteLine("===Entras por el patio===");
                            Console.WriteLine("==Preparate==");
                            for (int i = 0; i <= 100; i++)
                            {
                                Console.WriteLine($"Cargado juego...: {i}");
                            }
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("Estas en el patio de la casa");
                            Console.WriteLine("Parece que hay cositas aqui no?");
                            Console.WriteLine("1. Agarrar bate");
                            Console.WriteLine("2. Abrir Puerta de la cocina");
                            Console.WriteLine("3. Ver caja");
                            Console.Write("Elige con cautela...: ");
                            
                            int inte = 0;
                            try
                            {
                                inte = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Recuerda que es solo numeros");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }

                            if (inte == 1)
                            {
                                Console.WriteLine("Encontraste un bate");
                                if (cositas.Contains("bate"))
                                {
                                    Console.WriteLine("Ya tienes un bate");
                                }
                                else
                                {
                                    cositas.Add("bate");
                                    Console.Clear();
                                    Console.WriteLine("Excelente ahora puedes defenderte");
                                }
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (inte == 3)
                            {
                                Console.WriteLine("Abres la caja...");
                                Console.WriteLine("No se ve bien asi que te acercas mas");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("...");
                                Console.WriteLine("Por curioso te asustas por ver una nota que tiene un dibujo de un payaso con nombre: Neomar...");

                                if (cositas.Contains("NotaNeomar"))
                                {
                                    Console.WriteLine("Ya tienes la nota");
                                }
                                else
                                {
                                    cositas.Add("NotaNeomar");
                                    Console.Clear();
                                    Console.WriteLine("Agarraste la nota misteriosa");
                                }
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Entras a la cocina");
                                Console.WriteLine("...............hay algo...");
                                Console.WriteLine("1. Usar el bate contra el payaso");
                                Console.WriteLine("2. Preguntarle como esta");
                                Console.WriteLine("3. Esperar y verlo a la cara");
                                Console.Write("Elige: ");
                                
                                int inter = 0;
                                try
                                {
                                    inter = Convert.ToInt32(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Solo numeros");
                                    Console.ReadKey();
                                    Console.Clear();
                                    continue;
                                }

                                switch (inter)
                                {
                                    case 1:
                                        Console.Clear();
                                        if (cositas.Contains("bate"))
                                        {
                                            Console.WriteLine("Agarras el bate");
                                            Console.WriteLine("Y se lo avientas tanto que lo lanzas a Neomar al suelo");
                                            Console.WriteLine("Ves que tiene un arma y una foto que te parece conocida pero no le das importancia y agarras el arma");
                                            Console.WriteLine("1. Le disparas?");
                                            Console.WriteLine("2. O Lo dejas vivir?");
                                            Console.Write("Es tu decision y la adrenalina corre por tus venas. Elige 1 o 2: ");
                                            
                                            int interactuar = 0;
                                            try
                                            {
                                                interactuar = Convert.ToInt32(Console.ReadLine());
                                                if (interactuar == 1)
                                                {
                                                    Console.WriteLine("Le das un tiro y le dices que tu no confias. Pateas a Neomar una y otra vez...");
                                                    Console.WriteLine("Lo dejas tirado y sin querer agarras la foto para burlarte y te das cuenta que era tu amigo...");
                                                    Console.WriteLine("===Te pones tan mal...===");
                                                    Console.WriteLine("Que decides volarte la cabeza");
                                                    Console.ReadKey();
                                                    Salirgame = true;
                                                    Jugar = false;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Lo dejas vivo, te descuidas y Neomar te mete un tiro en la cabeza");
                                                    Console.WriteLine("POR CONFIADO. ¿Quien dijo que hay que confiar en el enemigo?");
                                                    Console.ReadKey();
                                                    Salirgame = true;
                                                    Jugar = false;
                                                }
                                            }
                                            catch
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Error de entrada");
                                                Console.ReadKey();
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No tienes bate, Neomar te ataca por sorpresa y mueres");
                                            Console.WriteLine("GAME OVER");
                                            Console.ReadKey();
                                            Salirgame = true;
                                            Jugar = false;
                                        }
                                        break;

                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("Le preguntas como esta");
                                        Console.Write("Neomar: Yo... ahh si yo pues super bien ");
                                        Console.ReadKey();
                                        Console.WriteLine("Neomar: Espera Comidaaaa!!!");
                                        Console.WriteLine("¡Neomar se acerca!!");
                                        Console.WriteLine("1. Correr");
                                        Console.WriteLine("2. Abrir la puerta que esta atras de Neomar");
                                        Console.WriteLine("3. Rezar");
                                        Console.Write("Elige: ");
                                        
                                        int intera = 0;
                                        try
                                        {
                                            intera = Convert.ToInt32(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Estas asustado o que? Solo numeros");
                                            Console.ReadKey();
                                            continue;
                                        }

                                        bool codigo = false;

                                        switch (intera)
                                        {
                                            case 1:
                                                Console.WriteLine("Te vas corriendo");
                                                Console.WriteLine(":(");
                                                for (int i = 0; i < 20; i++)
                                                {
                                                    Console.WriteLine("    :(     ");
                                                }
                                                Console.WriteLine("No Completaste el trabajo");
                                                Console.ReadKey();
                                                Salirgame = true;
                                                Jugar = false;
                                                break;

                                            case 2:
                                                Console.WriteLine("Vas a la puerta corriendo...");
                                                Console.WriteLine("Llegas a la puerta pero..");
                                                Console.WriteLine("Necesitas un codigo!!!");
                                                Console.Write("Escribe el codigo: ");
                                                
                                                int interac = 0;
                                                try
                                                {
                                                    interac = Convert.ToInt32(Console.ReadLine());

                                                    if (interac == 2010)
                                                    {
                                                        Console.WriteLine("Abriste la puerta desesperado");
                                                        Console.WriteLine("Descubres que..");
                                                        Console.WriteLine("En la sala hay unos documentos");
                                                        Console.WriteLine("La verdad! Y lo que buscabas para terminar el trabajo");
                                                        Console.ReadKey();
                                                        Console.WriteLine("Llega tu amigo por la puerta principal y te dice: ¿Que haces con esos documentos?");
                                                        Console.WriteLine("Tu: Son lo que me pidieron");
                                                        Console.WriteLine("Tu amigo: umm... ¿Seguro?");
                                                        Console.WriteLine("Tu: Ok, vamonos");
                                                        
                                                        for (int o = 0; o < 5; o++)
                                                        {
                                                            Console.WriteLine("Ganaste!!: ");
                                                            Console.ReadKey();
                                                        }
                                                        Salirgame = true;
                                                        Jugar = false;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("TE FALTA EL CODIGO DE LA PUERTA");
                                                        Console.ReadKey();
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Solo numeros");
                                                    Console.ReadKey();
                                                    continue;
                                                }
                                                break;

                                            case 3:
                                                Console.WriteLine("Rezas el padre nuestro..");
                                                Console.ReadKey();
                                                Console.WriteLine("===Neomar: JAJAJAJA ¿ENSERIO? ===");
                                                Console.WriteLine("Neomar: Hay bueno jaja Vete o sufres, ya te orinaste tan solo verme");
                                                Console.WriteLine("Neomar: El codigo es =2010= mi fecha de nacimiento");
                                                codigo = true;
                                                Console.ReadKey();
                                                break;
                                        }
                                        break;

                                    case 3:
                                        Console.WriteLine("Te quedas quieto y Neomar te dispara...");
                                        Console.Clear();
                                        Console.WriteLine("EN QUE ESTABAS PENSANDO DIOS MIO");
                                        Console.ReadKey();
                                        Salirgame = true;
                                        Jugar = false;
                                        break;

                                    default:
                                        Console.WriteLine("Opcion no valida");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Salirgame = true;
                }
            }
            Console.WriteLine("Gracias por jugar!");
        }
    }
}