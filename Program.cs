using System;
using System.Collections.Generic;

namespace HelloWold
{
    public static class Program 
    {         
        public static void Main()
        {
            Console.WriteLine("=== CREACIÓN DE PERSONAJE ===\n");
            Console.Write("Escribe el nombre de tu héroe: ");
            string nombreJugador = Console.ReadLine();
            
            // Validar que no esté vacío
            if (string.IsNullOrWhiteSpace(nombreJugador))
            {
                nombreJugador = "Neomar"; // Nombre por defecto
                Console.WriteLine($"Usando nombre por defecto: {nombreJugador}");
            }
            
            Console.WriteLine($"\n¡Bienvenido, {nombreJugador}!\n");
            
            // Crear personajes (USA el nombre que ingresaste)
            Jugador heroe = new Jugador(nombreJugador, 100, 15);
            Enemigo goblin = new Enemigo("Goblin", 50, 8, 20);
            
            Console.WriteLine("=== BATALLA RPG ===\n");
            
            // Mostrar estado inicial
            heroe.MostrarEstado();
            goblin.MostrarEstado();
            
            Console.WriteLine("\n¡Comienza la batalla!\n");
            
            // Batalla por turnos
            while (heroe.EstaVivo() && goblin.EstaVivo())
            {
                // Turno del jugador
                Console.WriteLine($"\n{heroe.Nombre} ataca a {goblin.Nombre}!");
                heroe.Atacar(goblin);
                
                if (!goblin.EstaVivo()) 
                {
                    Console.WriteLine($"\n💀 {goblin.Nombre} ha sido derrotado!");
                    heroe.GanarExperiencia(goblin.RecompensaExp);
                    break;
                }
                
                // Turno del enemigo
                Console.WriteLine($"\n{goblin.Nombre} contraataca!");
                goblin.Atacar(heroe);
                
                if (!heroe.EstaVivo())
                {
                    Console.WriteLine($"\n💀 {heroe.Nombre} ha sido derrotado...");
                    break;
                }
            }
            
            Console.WriteLine("\n=== ESTADO FINAL ===");
            heroe.MostrarEstado();
            goblin.MostrarEstado();
            
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
    
    // Clase base Personaje
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        
        public Personaje(string nombre, int vida, int ataque)
        {
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;
        }
        
        public bool EstaVivo()
        {
            return Vida > 0;
        }
        
        public void Atacar(Personaje objetivo)
        {
            int dano = Ataque;
            objetivo.RecibirDano(dano);
            Console.WriteLine($"  ⚔️ {Nombre} causa {dano} de daño a {objetivo.Nombre}!");
        }
        
        public void RecibirDano(int dano)
        {
            Vida -= dano;
            if (Vida < 0) Vida = 0;
        }
        
        public virtual void MostrarEstado()
        {
            Console.WriteLine($"{Nombre}: ❤️ {Vida} vida | ⚔️ {Ataque} ataque");
        }
    }
    
    // Clase Jugador (hereda de Personaje)
    public class Jugador : Personaje
    {
        public int Experiencia { get; set; }
        
        public Jugador(string nombre, int vida, int ataque) 
            : base(nombre, vida, ataque)
        {
            Experiencia = 0;
        }
        
        public void GanarExperiencia(int exp)
        {
            Experiencia += exp;
            Console.WriteLine($"  ✨ {Nombre} ganó {exp} de experiencia!");
        }
        
        public override void MostrarEstado()
        {
            Console.WriteLine($"👤 {Nombre}: ❤️ {Vida} vida | ⚔️ {Ataque} ataque | ✨ {Experiencia} exp");
        }
    }
    
    // Clase Enemigo (hereda de Personaje)
    public class Enemigo : Personaje
    {
        public int RecompensaExp { get; set; }
        
        public Enemigo(string nombre, int vida, int ataque, int recompensa) 
            : base(nombre, vida, ataque)
        {
            RecompensaExp = recompensa;
        }
        
        public override void MostrarEstado()
        {
            Console.WriteLine($"👾 {Nombre}: ❤️ {Vida} vida | ⚔️ {Ataque} ataque");
        }
    }
}