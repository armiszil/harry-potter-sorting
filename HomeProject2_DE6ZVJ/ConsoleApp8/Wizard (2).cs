using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    
    class Wizard
    {
        string name;
        int courage;
        int intelligence;
        int cunning;
        int perseverence;

        public string Name { get { return name; } }

        public int Courage { get { return courage; }}
        public int Intelligence { get { return intelligence; }}
        public int Cunning{ get { return cunning; }}
        public int Perserverence { get { return perseverence; } }

        public string AllData
        {
            get { return $"{name} ({courage}, {intelligence}, {cunning}, {perseverence})"; }
        }



        static Random random = new Random();



        public Wizard(string name, int courage, int intelligence, int cunning, int perseverence)
        {
            this.name = name;
            this.courage = courage;
            this.intelligence = intelligence;
            this.cunning = cunning;
            this.perseverence = perseverence;
        }
        public Wizard() { }

        public  Wizard[] Generate(int number)
        {
            string[] FirstNames = { "Harry", "Ron", "Hermione", "Rubius", "Albus", "Genie" };
            string[] LastNames = { "Potter", "Weasley", "Granger", "Dumbledore", "Hagrid" };
            Wizard[] AllWizards = new Wizard[number];

            for (int i = 0; i < AllWizards.Length; i++)
            {
                name = FirstNames[random.Next(0, FirstNames.Length)] + " " + LastNames[random.Next(0, LastNames.Length)];
                courage = random.Next(0, 101);
                intelligence = random.Next(0, 101);
                cunning = random.Next(0, 101);
                perseverence = random.Next(0, 101);
                Wizard newWizard = new Wizard(name, courage, intelligence, cunning, perseverence);
                AllWizards[i] = newWizard;
                //Array.Sort(AllWizards);
                Console.WriteLine(AllWizards[i].AllData);

                

                
            }
            return AllWizards;
        }
    

    }
}
