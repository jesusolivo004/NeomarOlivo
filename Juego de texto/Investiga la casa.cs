using System;
using System.Collections.Generic;
using System.IO;
namespace Jesus
{
    public class Investigalacasa
    {
        static void Main()
        {
            List<string> cosas = new List<string>();
            bool Salirgame = false;
            while(!Salirgame)
            {
             Console.WriteLine("-=Investiga la casa=-");
             Console.WriteLine("1. Jugar");
             Console.WriteLine("2. Salir");
             Console.Write("Elegistes; ");
             
             int opcionmenup;
             try
             {
               opcionmenup = Convert.ToInt32(Console.ReadLine());
               
             }
             catch
             {
               Console.WriteLine("Este juego usara puro numeros");
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
                 int jugar;
                 while(Jugar)
                 {
                     Console.WriteLine("1. Quieres entrar ala casa por la puerta principal?");
                     Console.WriteLine("2. O por el patio?");
                     Console.Write("Elige bien: ";
                     int opcionmenus;
                     try
                     {
                        opcionmenus= Convert.ToInt32(Console.ReadLine());
                     }
                     catch
                     {
                        Console.WriteLine("Solo Numeros");
                        Console.ReadKey();
                        continue;
                     }
                     case 1:
                        if (opcionmenus==1)
                        {
                           Console.WriteLine("===Entras por la pueeta principal==");
                           Console.WriteLine("==Estas listo?==");
                           for(int i = 0;i <= 100;i++)
                           {
                              Console.WriteLine($"Me gusta la carga..:{i}");
                           }
                           Console.ReadKey();
                           Console.Clear();
                           Console.WriteLine("Estas en el porche de la casa");
                           Console.WriteLine("Lo siento no esta disponible todavia...");
                           Salirgame = true;
                        }
                        break;
                        
                     case 2:
                        else{
                          Console.WriteLine("===Entras por el patio===");
                          Console.WriteLine("==Preparate==");
                          for(int i = 0;i <= 100;i++)
                          {
                              Console.WriteLine($"Cargado juego...: {i}");
                          }
                          Console.ReadKey();
                          Console.Clear();
                          Console.WriteLine("Estas en el patio de la casa");
                          Console.WriteLine("Parece que hay cositas aqui no?");
                          Console.WriteLine("1. Agarrar bate");
                          Console.WriteLine("2. Abrir Puerta de la cocina");
                          Console.WriteLine("3. ver caja");
                          Console.Write("Elige con cautela...:");
                          int inte;
                          try
                          {
                             inte = Convert.ToInt32(Console.ReadLine());
                          }
                          catch
                          {
                             Console.WriteLine("Recuerda que es solo numeros");
                             Console.ReadKey();
                             continue;
                          }
                          if (inte == 1||inte <=1)
                          {
                             Console.WriteLine("Encontrastes un bate");
                             if(cositas.Contains("NotaNeomar"))
                             {
                                 cositas.Remove("NotaNeomar");
                             }
                             else{
                                cositas.Add("bate");
                                Console.Clear();
                                Console.WriteLine("Excelente ahora puedes defenderte");
                             }
                             return
                          }
                          else if(inte ==3)
                          {
                             Console.WriteLine("Abres la caja...");
                             Console.WriteLine("nose ve bien asi que te acercas mas");
                             Console.Clear();
                             Console.WriteLine("...");
                             Console.WriteLine("Por curioso te asustas por ver una nota que tiene un dibujo de un payaso con nombre:Neomar...");
                             
                             if(cositas.Contains("NotaNeomar"))
                             {
                                 cositas.Remove("NotaNeomar");
                             }
                             else
                             {
                                  cositas.Add("NotaNeomar");
                                  Console.Clear();
                             }
                             return
                          }
                          else{
                             Console.WriteLine("Entras ala cocina");
                             Console.WriteLine("...............hay");
                             Console.Write("Elige...");
                             Console.WriteLine("1. Usar el bate contra el payaso");
                             Console.WriteLine("2. Preguntarle como esta");
                             Console.WriteLine("3. Esperar y verlo ala cara");
                             int inter;
                             try
                             {
                                inter=Convert.ToInt32(Console.ReadLine());
                             }
                             switch(inter)
                             {
                                 case 1:
                                     Console.Clear();
                                     Console.WriteLine("Agarras el bate");
                                     Console.WriteLine("Y se lo atiendes tanto que lo lanzas a Neomar a el suelo");
                                     Console.WriteLine("Ves que tiene una arma y una foto que te parece conocida pero no le das importancia y agarras el arma");
                                     Console.WriteLine("1. Le disparas?");
                                     Console.WriteLine("2. O Lo dejas vivir?");
                                     Console.Write("Es tu desicion y la adrenalina corre por tus venas y recuerdas la foto Elige 1 o 2");
                                     int interactuar;
                                     try
                                     {
                                         interactuar= Convert.ToInt32(Console.ReadLine());
                                         if (interactuar = 1){
                                             Console.WriteLine("Le das un tiro y le dices que tu no confiaz Y pateas a Neomar una y otra y otra vez sintiendo y sabiendo que no fuera pasado algo peor");
                                             Console.WriteLine("Lo dejas tirado y sin querer agarras la foto para burlate y te das cuenta que era tu amigo..");
                                             Console.WriteLine("===Te pones tan mal...");
                                             Console.WriteLine("Que decides volarte la cabeza");
                                             Console.ReadKey();
                                             Salirgame= true;
                                         }
                                         
                                         else{
                                             interactuar = 2;
                                             Console.WriteLine("Lo dejas vivo  te descuidas y Neomar te mete un tiro ala cabeza");
                                             Console.WriteLine("POR CONFIADO QUIEN DIJO QUE HAY QUE CONFIARZE DE EL ENEMIGO");
                                             Console.ReadKey();
                                             Salirgame = true;
                                         }
                                     }
                                     catch
                                     {
                                         Console.Clear();
                                         continue;
                                     }
                                     
                                      break
                                 case 2:
                                     Console.Clear();
                                     Console.WriteLine("Le preguntas como esta");
                                     Console.Write("Neomar: Yo... ahh si yoo pues super bien ");
                                     Console.WriteLine("Neomar: Espera Comidaaaa!!!");
                                     Console.WriteLine("¡Neomar se acerca!!");
                                     Console.WriteLine("1. Correr");
                                     Console.WriteLine("2. Abrir la puerta que esta atras de Neomar");
                                     Console.WriteLine("3. Rezar");
                                     int intera;
                                     try
                                     {
                                         intera= Convert.ToInt32(Console.ReadLine());
                                     }
                                     catch
                                     {
                                         Console.Clear();
                                         Console.WriteLine("Estas asustad@ o que por que escribes es solo numero o te rezo el padre nuestro");
                                         continue;
                                     }
                                     switch(intera)
                                     {
                                         int codigo = false;
                                         case 1:
                                              Console.WriteLine("Te vas corriendo");
                                              Console.WriteLine(":(");
                                              for(i = 0;i<=20;i++)
                                              {
                                                  Console.WriteLine("    :(     ");
                                              }
                                              Console.WriteLine("No Completastes el trabajo");
                                              Salirgame = true;
                                            break
                                         case 2:
                                              Console.WriteLine("Vas ala puerta corriendo...");
                                              Console.WriteLine("Lleguas ala puerta pero..");
                                              Console.WriteLine("Necesitas un codigo!!!");
                                              Console.Write("Escribe el codigo: ");
                                              int interac;
                                              try
                                              {
                                                  interac = Convert.ToInt32(Console.ReadLine());
                                              }
                                              catch
                                              {
                                                  Console.Clear();
                                                  Console.WriteLine("Solo numeros");
                                                  Console.ReadKey();
                                                  continue;
                                              }
                                              if(interac= true && interac== 2010)
                                              {
                                                  Console.WriteLine("Abristes la puerta a lo desesperado");
                                                  Console.WriteLine("Descubres que..");
                                                  Console.WriteLine("En la sala hay unos documentos");
                                                  Console.WriteLine("La verdad! y Lo que buscabas para terminar el trabajo");
                                                  Console.WriteLine("...");
                                                  Console.ReadKey();
                                                  Console.WriteLine("llegua tu amigo por la puerta principal te dice que haces con esos documentos =Tu:= Son lo que me pidieron =Tu amigo= umm");
                                                  Console.WriteLine("Seguro?");
                                                  Console.WriteLine("Tu...");
                                                  Console.WriteLine("Ok vamonos");
                                                  for(i=0;i>10;i++)
                                                     {
                                                         Console.WriteLine("Ganastess!!");
                                                         Console.ReadKey();
                                                         Salirgame = true;
                                                     }
                                              }
                                              else{
                                                  interac = false;
                                                  Console.WriteLine("TE FALTA EL CODIGO DE LA PUERTA");
                                              }
                                            break
                                         case 3:
                                              Console.WriteLine("Rezas el padre nuestro..");
                                              Console.WriteLine("===Neomar: JAJAJAJA ENSERIO!!");
                                              Console.WriteLine("Neomar: Hay bueno jaja Vete o sufres ya te orinastes tan solo verme");
                                              Console.WriteLine("Neomar: El codigo es =2010= mi fecha de nacimiento");
                                              codigo = true;
                                            break
                                     }
                                      break
                                 case 3:
                                     Console.WriteLine("Te quedas quieto y Neomar te dispara...");
                                     Console.Clear();
                                     Console.WriteLine("EN QUE ESTABAS PENSADO DIOS MIO");
                                      break
                             }
                           }
                        }
                        break;
                 }
             }
             else
             {
                 Salirgame = true;
             }
            }
        }
    }
}