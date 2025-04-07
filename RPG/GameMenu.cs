using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Taller2DJP251.RPG
{
    internal class GameMenu
    {
        private List<Enemy> enemies;
        private Player player;

        private int currentEnemyIndex;

        public GameMenu()
        {
            enemies = new List<Enemy>();
        }

        public void Execute()
        {
            CreatePlayer();
            CreateEnemies();
            TurnManagement();
        }

        private void CreateEnemies()
        {
            enemies.Add(new Enemy("Goblin", 10, 5));
            enemies.Add(new Enemy("Orco", 20, 10));
            enemies.Add(new Enemy("Golem", 30, 15));
        }

        private void CreatePlayer()
        {
            bool continueFlag = true;
            string name;
            int life=0;
            int damage=0;
            Console.WriteLine("Introduce tu nombre: ");
            name = Console.ReadLine();
            while (continueFlag)
            {
                Console.WriteLine("Introduce tu cantidad de vida: ");
                life=int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce tu cantidad de daño: ");
                damage=int.Parse(Console.ReadLine());
                if (damage > 0 && life > 0 && damage + life <= 100)
                {
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("Los datos de vida y daño son incorrectos.");
                }
            }
            player = new Player(name, life, damage);
        }

        private void TurnManagement()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                PlayerTurn();
                if (IsEnemyAlive())
                {
                    EnemyTurn();
                    if (!player.IsAlive())
                    {
                        continueFlag = false;
                    }
                }
                else
                {
                    continueFlag = false;
                }
            }

            if (IsEnemyAlive())
            {
                Console.WriteLine("El jugador perdió");
            }
            else
            {
                Console.WriteLine("El jugador ganó");
            }
        }

        private void PlayerTurn()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine($"Turno de: {player.GetData()}");
                ShowEnemies();
                int option = int.Parse(Console.ReadLine());
                if (option >= 0 && option < enemies.Count)
                {
                    Enemy enemy = enemies[option];
                    if (enemy.IsAlive())
                    {
                        Console.WriteLine($"{enemy.Name} recibe {player.GetDamage()} de daño");
                        enemy.TakeDamage(player.GetDamage());
                        if (!enemy.IsAlive())
                        {
                            Console.WriteLine("El enemigo murió");
                        }
                        continueFlag = false;
                    }
                    else
                    {
                        Console.WriteLine("El enemigo está muerto, no lo puedes atacar");
                    }
                }
                else
                {
                    Console.WriteLine("La opción no es válida");
                }
            }
        }

        private void ShowEnemies()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Console.WriteLine($"{i}. {enemies[i].GetData()}");
            }
        }

        private void EnemyTurn()
        {
            Enemy enemy = enemies[currentEnemyIndex];
            Console.WriteLine($"Turno del {enemy.GetData()}");
            if (enemy.IsAlive())
            {
                Console.WriteLine($"El jugador recibe {enemy.GetDamage()} de daño");
                player.TakeDamage(enemy.GetDamage());
                if (!player.IsAlive())
                {
                    Console.WriteLine("El jugador murió");
                }
            }
            else
            {
                Console.WriteLine("El enemigo está muerto y no puede atacar");
            }
            currentEnemyIndex++;
            if (currentEnemyIndex >= enemies.Count)
            {
                currentEnemyIndex = 0;
            }
        }

        private bool IsEnemyAlive()
        {
            foreach (Enemy enemy in enemies)
            {
                if(enemy.IsAlive())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
