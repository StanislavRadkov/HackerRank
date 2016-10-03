using System.Collections.Generic;

namespace Stacks
{
    // https://www.hackerrank.com/challenges/poisonous-plants
    public static class PoisonousPlants
    {
        public static int Solve(LinkedList<int> plants)
        {
            bool plantsDied = false;
            var days = 0;
            var firstPlantToVisit = plants.Last;

            do
            {
                plantsDied = false;
                var current = firstPlantToVisit;
                firstPlantToVisit = null;

                do
                {
                    if (current.Previous != null && current.Previous.Value < current.Value)
                    {
                        // Start iterating where the first plant died the previous day.
                        if (firstPlantToVisit == null || current == firstPlantToVisit)
                        {
                            if (current.Next != null)
                            {
                                firstPlantToVisit = current.Next;
                            }
                            else if (current.Previous != null)
                            {
                                firstPlantToVisit = current.Previous;
                            }
                        }

                        var toRemove = current;
                        current = current.Previous;
                        plants.Remove(toRemove);
                        plantsDied = true;
                    }
                    else
                    {
                        current = current.Previous;
                    }

                }
                while (current != null);

                if (plantsDied)
                {
                    days++;
                }
            }
            while (plantsDied);

            return days;
        }
    }
}
