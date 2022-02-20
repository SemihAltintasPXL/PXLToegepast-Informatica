using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace oefPreyPredator.Contracts
{
    class AnimalWorld : IAnimalWorld
    {
        private Canvas canvas;
        private IList<IAnimal> alleDieren = new List<IAnimal>();
        private IList<IAnimal> gestorvenDieren = new List<IAnimal>();
        private IList<IAnimal> geborenDieren = new List<IAnimal>();
        private int huidigeRonde;

        public Canvas Canvas { get => canvas; set => canvas = value; }
        public AnimalWorld(Canvas canvas)
        {
            Canvas = canvas;
        }
        public IList<IAnimal> AllAnimals => alleDieren;

        public int CurrentRoundNumber => huidigeRonde;

        public void AddAnimal(IAnimal animal)
        {
            animal.DisplayOn(Canvas, Colors.Red);
        }

        public void ProcessRound()
        {
            foreach (IAnimal dier in alleDieren)
            {
                dier.Move();
                if (dier is LadyBug)
                {
                    IAnimal nieuwDier = dier.TryBreed();
                    if (nieuwDier != null)
                    {
                        geborenDieren.Add(nieuwDier);
                        AddAnimal(nieuwDier);
                    }
                }
                if (dier.IsDead)
                {
                    dier.StopDisplaying();
                    gestorvenDieren.Add(dier);
                }

            }

            foreach (IAnimal doodDier in gestorvenDieren)
            {
                if (alleDieren.Contains(doodDier))
                {
                    alleDieren.Remove(doodDier);
                }
            }

            foreach (IAnimal geborenDier in geborenDieren)
            {
                alleDieren.Add(geborenDier);
            }


            //overgeblevenDieren = (IList<IAnimal>)alleDieren.Except(gestorvenDieren);
            //overgeblevenDieren.Add((IAnimal)(geborenDieren));

        }
    }
}
