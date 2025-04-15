using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DJP251.Farm
{
    internal class FarmMenu
    {
        private Farm farm;
        private List<Plant> plantSeeds;

        public FarmMenu()
        {
            plantSeeds = new List<Plant>();
            plantSeeds.Add(new Plant("Manzana", 5, 10, 5, 3));
            plantSeeds.Add(new Plant("Pera", 3, 2, 7, 5));
            plantSeeds.Add(new Plant("Mandarina", 8, 4, 8, 10));
            plantSeeds.Add(new Plant("Uva", 2, 20, 10, 2));
            plantSeeds.Add(new Plant("Coco", 10, 1, 20, 100));
        }

        public void Execute()
        {
            CreateFarm();
            GameplayLoop();
        }

        private void GameplayLoop()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                ShowFarmData();

                Console.WriteLine("Elige la opción a realizar");
                Console.WriteLine("1. Comprar una semilla y plantarla");
                Console.WriteLine("2. Cosechar");
                Console.WriteLine("3. Ver las plantas");
                Console.WriteLine("4. Ver las plantas cosechadas");
                Console.WriteLine("5. Pasar el turno");
                Console.WriteLine("6. Vender cosecha");
                Console.WriteLine("7. Comprar expansión");
                string option=Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ShowSeeds();
                        PurchaseSeed();
                        break;
                    case "2":
                        farm.Harvest();
                        break;
                    case "3":
                        foreach(Plant p in farm.Plants)
                        {
                            Console.WriteLine($"{p.Name}" );
                        }
                        break;
                    case "4":
                        foreach (Plant p in farm.HarvestedPlants)
                        {
                            Console.WriteLine($"{p.Name}");
                        }
                        break;
                    case "5":
                        foreach(Plant plant in farm.Plants)
                        {
                            plant.PassTurn();
                        }
                        break;
                    case "6":
                        farm.SellAllPlants();
                        break;
                    case "7":
                        PurchaseExpansion();
                        break;
                }
            }
        }

        private void PurchaseExpansion()
        {
            if (farm.CanPurchaseExpansion())
            {
                farm.PurchaseExpansion();
            }
            else
            {
                Console.WriteLine("No tienes suficiente dinero");
            }
        }



        private void CreateFarm()
        {
            int money;
            Console.WriteLine("Introduce tu cantidad de dinero");
            money=int.Parse(Console.ReadLine());
            farm = new Farm(money);
        }

        private void ShowFarmData()
        {
            Console.WriteLine($"La granja tiene {farm.Money} de dinero");
            Console.WriteLine($"Hay {farm.MaxPlantAmount} espacios totales, de los cuales {farm.MaxPlantAmount-farm.Plants.Count} están disponibles");
            foreach(Plant plant in farm.HarvestableNotification())
            {
                Console.WriteLine($"Puedes cosechar {plant.Name}");
            }
        }

        private void ShowSeeds()
        {
            Console.WriteLine("Hay las siguientes semillas para comprar:");
            for (int i = 0; i < plantSeeds.Count; i++)
            {
                Console.WriteLine($"{i}. {plantSeeds[i].Name} - {plantSeeds[i].SeedPrice}");
            }
        }

        private void PurchaseSeed()
        {
            if (farm.CanPlant())
            {
                int option = int.Parse(Console.ReadLine());
                if (option >= 0 && option < plantSeeds.Count)
                {
                    Plant plant = plantSeeds[option];
                    if (farm.CanPurchasePlant(plant)) 
                    {
                        farm.Plant(plant);
                        farm.PurchasePlant(plant);
                        Console.WriteLine($"Se plantó con éxito un {plant.Name}");
                    }
                    else
                    {
                        Console.WriteLine("No tienes suficiente dinero");
                    }
                }
                else
                {
                    Console.WriteLine("No es un valor válido");
                }
            }
            else
            {
                Console.WriteLine("No se puede plantar porque está lleno");
            }
        }
    }
}
