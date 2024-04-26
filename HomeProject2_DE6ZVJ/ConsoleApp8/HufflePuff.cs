using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class HufflePuff : Wizard
    {
        BinarySearchTree<int, Wizard> hufflePuffHouse;

        public HufflePuff()
        {
            HufflePuffHouse = new BinarySearchTree<int, Wizard>();
        }

        public BinarySearchTree<int, Wizard> HufflePuffHouse { get; }

        public void InsertHufflePuff(Wizard[] myWizard)
        {

            for (int i = 0; i < myWizard.Length; i++)
            {
                if (myWizard[i].Perserverence > myWizard[i].Cunning && myWizard[i].Perserverence > myWizard[i].Courage && myWizard[i].Perserverence > myWizard[i].Intelligence)
                {
                    HufflePuffHouse.InsertWizard(myWizard[i].Perserverence, myWizard[i]);

                }

            }
        }

        public void TravelHufflePuff(int searchQuality)
        {
            HufflePuffHouse.Traversal(searchQuality);

        }

    }
    }
