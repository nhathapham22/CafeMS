using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMS
{
    class Cafe
    {

        //drinks
        private double newLatte;
        private double newBlackCoffee;
        private double newExpresso;
        private double newOrangeJuice;
        private double newGreenTea;
        private double newMilkTea;
        private double newCappuchino;
        private double newHotChocolate;
        private double newWater;
        private double newMacchiato;
        //foods
        private double newFries;
        private double newEggBites;
        private double newFishnChips;
        private double newOmmelette;
        private double newInstantNoodles;
        private double newCrssant;
        private double newCheeseCake;
        private double newRainbowCake;
        private double newChocolateCake;
        private double newRedVelvetCake;

        //Default constructor
        public Cafe()
        {
            newLatte = 0.0;
            newBlackCoffee = 0.0;
            newExpresso = 0.0;
            newOrangeJuice = 0.0;
            newGreenTea = 0.0;
            newMilkTea = 0.0;
            newCappuchino = 0.0;
            newHotChocolate = 0.0;
            newWater = 0.0;
            newMacchiato = 0.0;

            newFries = 0.0;
            newEggBites = 0.0;
            newFishnChips = 0.0;
            newOmmelette = 0.0;
            newInstantNoodles = 0.0;
            newCrssant = 0.0;
            newCheeseCake = 0.0;
            newRainbowCake = 0.0;
            newChocolateCake = 0.0;
            newRedVelvetCake = 0.0;
        }
        //Set method
        public Cafe(double Latte, double BlackCoffee, double Expresso, double OrangeJuice, double GreenTea,
            double MilkTea, double Cappuchino, double HotChocolate, double Water, double Macchiato,
            double Fries, double EggBites, double FishnChips, double Ommelette, double InstantNoodles,
            double Crssant, double CheeseCake, double RainbowCake, double ChocolateCake, double RedVelvetCake)
        {

            // Initialize fields with the provided quantities
            newLatte = Latte;
            newBlackCoffee = BlackCoffee;
            newExpresso = Expresso;
            newOrangeJuice = OrangeJuice;
            newGreenTea = GreenTea;
            newMilkTea = MilkTea;
            newCappuchino = Cappuchino;
            newHotChocolate = HotChocolate;
            newWater = Water;
            newMacchiato = Macchiato;

            newFries = Fries;
            newEggBites = EggBites;
            newFishnChips = FishnChips;
            newOmmelette = Ommelette;
            newInstantNoodles = InstantNoodles;
            newCrssant = Crssant;
            newCheeseCake = CheeseCake;
            newRainbowCake = RainbowCake;
            newChocolateCake = ChocolateCake;
            newRedVelvetCake = RedVelvetCake;

        }

        //get method
        public double getLatte() { return newLatte; }
        public double getBlackCoffee() { return newBlackCoffee; }
        public double getExpresso() { return newExpresso; }
        public double getOrangeJuice() { return newOrangeJuice; }
        public double getGreenTea() { return newGreenTea; }
        public double getMilkTea() { return newMilkTea; }

        public double getCappuchino() { return newCappuchino; }
        public double getHotChocolate() { return newHotChocolate; }
        public double getWater() { return newWater; }
        public double getMacchiato() { return newMacchiato; }

        public double getFries() { return newFries; }
        public double getEggBites() { return newEggBites; }

        public double getFishnChips() { return newFishnChips; }
        public double getOmmelette() { return newOmmelette; }

        public double getInstantNoodles() { return newInstantNoodles; }
        public double getCrssant() { return newCrssant; }
        public double getCheeseCake() { return newCheeseCake; }
        public double getRainbowCake() { return newRainbowCake; }
        public double getChocolateCake() { return newChocolateCake; }
        public double getRedVelvetCake() { return newRedVelvetCake; }
    }
}
