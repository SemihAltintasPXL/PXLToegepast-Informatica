using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefPreyPredator.Contracts
{
    public interface IAnimalWorld
    {
        IList<IAnimal> AllAnimals { get; }
        int CurrentRoundNumber { get; }
        void AddAnimal(IAnimal animal);
        void ProcessRound();
    }
}
