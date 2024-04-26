using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class RavenClaw : Wizard
    {
        BinarySearchTree<int, Wizard> ravenClawHouse;

        public RavenClaw()
        {
            RavenClawHouse = new BinarySearchTree<int, Wizard>();
        }

        public BinarySearchTree<int, Wizard> RavenClawHouse { get; }

        public void InsertRavenClaw(Wizard[] myWizard)
        {

            for (int i = 0; i < myWizard.Length; i++)
            {
                if (myWizard[i].Intelligence > myWizard[i].Cunning && myWizard[i].Intelligence > myWizard[i].Courage && myWizard[i].Intelligence > myWizard[i].Perserverence)
                {
                    RavenClawHouse.InsertWizard(myWizard[i].Intelligence, myWizard[i]);

                }

            }

        }
    }
    }
