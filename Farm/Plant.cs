using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DJP251.Farm
{
    internal class Plant
    {
        private string name;
        private int lifeTime;
        private int productionAmount;
        private int seedPrice;
        private int productPrice;

        private int currentLifeTime;

        public string Name {  get { return name; } }
        public int SeedPrice { get { return seedPrice; } }

        public Plant(string name, int lifeTime, int productionAmount, int seedPrice, int productPrice)
        {
            this.name = name;
            this.lifeTime = lifeTime;
            this.productionAmount = productionAmount;
            this.seedPrice = seedPrice;
            this.productPrice = productPrice;
            currentLifeTime = 0;
        }

        public void PassTurn()
        {
            currentLifeTime++;
        }

        public bool CanHarvest()
        {
            return currentLifeTime >= lifeTime;
        }

        public int GetTotalSellMoney()
        {
            return productionAmount * productPrice;
        }
    }
}
