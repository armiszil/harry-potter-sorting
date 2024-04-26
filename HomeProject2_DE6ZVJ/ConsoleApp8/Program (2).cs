using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard[] myWizard = new Wizard().Generate(10);

            Gryffindor gry = new Gryffindor();
            gry.InsertGryffindor(myWizard);
            BinarySearchTree<int, Wizard> gryffindorHouse = gry.GryffindorHouse;

            Slytherin sly = new Slytherin();
            sly.InsertSlytherin(myWizard);
            BinarySearchTree<int, Wizard> slytherinHouse = sly.SlytherinHouse;

            RavenClaw rav = new RavenClaw();
            rav.InsertRavenClaw(myWizard);
            BinarySearchTree<int, Wizard> ravenClawHouse = rav.RavenClawHouse;

            HufflePuff huf = new HufflePuff();
            huf.InsertHufflePuff(myWizard);
            BinarySearchTree<int, Wizard> hufflePuffHouse = rav.RavenClawHouse;
        }

    }
}
