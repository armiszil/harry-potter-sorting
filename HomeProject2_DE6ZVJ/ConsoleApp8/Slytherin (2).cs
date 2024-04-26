using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Slytherin : Wizard
    {
        BinarySearchTree<int, Wizard> slytherinHouse;

        public Slytherin()
        {
            SlytherinHouse = new BinarySearchTree<int, Wizard>();
        }

        public BinarySearchTree<int, Wizard> SlytherinHouse { get; }

        public void InsertSlytherin(Wizard[] myWizard)
        {

            for (int i = 0; i < myWizard.Length; i++)
            {
                if (myWizard[i].Cunning > myWizard[i].Courage && myWizard[i].Cunning > myWizard[i].Intelligence && myWizard[i].Cunning > myWizard[i].Perserverence)
                {
                    SlytherinHouse.InsertWizard(myWizard[i].Cunning, myWizard[i]);
                }

            }

        }
    }
}
