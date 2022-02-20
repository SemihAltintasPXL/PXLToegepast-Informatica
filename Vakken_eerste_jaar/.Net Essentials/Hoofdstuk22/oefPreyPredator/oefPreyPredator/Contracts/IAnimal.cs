using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefPreyPredator.Contracts
{
    public interface IAnimal:IDisplayable
    {
        Position position { get; }
        bool IsDead { get; set; }
        void Move();
        IAnimal TryBreed();
            
    }
}
