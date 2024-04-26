using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Gryffindor:Wizard
    {
     BinarySearchTree<int,Wizard> gryffindorHouse;

        public Gryffindor()
        {
            GryffindorHouse = new BinarySearchTree<int, Wizard>();
        }

        public BinarySearchTree<int, Wizard> GryffindorHouse { get; }

        public void InsertGryffindor(Wizard[] myWizard)
        {
           
            for (int i = 0; i < myWizard.Length; i++)
            {
                if (myWizard[i].Courage>myWizard[i].Cunning&&myWizard[i].Courage>myWizard[i].Intelligence&&myWizard[i].Courage>myWizard[i].Perserverence)
                {
                    GryffindorHouse.InsertWizard(myWizard[i].Courage, myWizard[i]);
                    
               }
                
            }

        }





    }
}
