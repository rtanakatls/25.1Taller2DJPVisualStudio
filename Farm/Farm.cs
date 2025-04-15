using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DJP251.Farm
{
    internal class Farm
    {

        private List<Plant> plants;
        private int maxPlantAmount;
        private int money;
        private int currentExpansion;

        private List<Plant> harvestedPlants;

        public int Money { get { return money; } }
        public List<Plant> Plants { get { return plants; } }
        public List<Plant> HarvestedPlants { get { return harvestedPlants; } }
        public int MaxPlantAmount { get { return maxPlantAmount; } }




        public Farm(int money)
        {
            plants=new List<Plant>();
            harvestedPlants=new List<Plant>();
            this.money = money;
            currentExpansion = 0;
            maxPlantAmount = 5;
        }

        public void PurchaseExpansion()
        {
            if (money >= 10 + currentExpansion * 10)
            {
                money -= 10 + currentExpansion * 10;
                maxPlantAmount++;
                currentExpansion++;
            }
        }

        public void Plant(Plant p)
        {
            if (plants.Count < maxPlantAmount)
            {
                plants.Add(p);
            }
        }

        public bool CanPurchaseExpansion()
        {
            return money >= 10 + currentExpansion * 10;
        }

        public bool CanPlant()
        {
            return plants.Count < maxPlantAmount;
        }

        public List<Plant> HarvestableNotification()
        {
            List<Plant> plantList = new List<Plant>();
            foreach (Plant plant in plants)
            {
                if (plant.CanHarvest())
                {
                    plantList.Add(plant);
                }
            }
            return plantList;
        }


        public void Harvest()
        {
            foreach(Plant plant in plants)
            {
                if(plant.CanHarvest())
                {
                    harvestedPlants.Add(plant);
                }
            }

            foreach(Plant plant in harvestedPlants)
            {
                plants.Remove(plant);
            }
        }

        public bool CanPurchasePlant(Plant plant)
        {
            return money >= plant.SeedPrice;
        }

        public void PurchasePlant(Plant plant)
        {
            money -= plant.SeedPrice;
        }

        public void SellPlant(Plant plant)
        {
            harvestedPlants.Remove(plant);
            money += plant.GetTotalSellMoney();
        }

        public void SellAllPlants()
        {
            List<Plant> soldPlants= new List<Plant>();
            foreach(Plant p in harvestedPlants)
            {
                soldPlants.Add(p);
                money += p.GetTotalSellMoney();
            }

            foreach(Plant p in  soldPlants)
            {
                harvestedPlants.Remove(p);
            }
        }
    }
}
