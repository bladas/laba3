using System;
using System.Collections;
using System.Collections.Generic;
namespace _11
{
    public class Trainer
    {
        public string name;
        public int number_of_badges;
        public List<Pokemon>pokemon = new List<Pokemon>();
        public Trainer()
        {
            number_of_badges = 0;
        }
    }
    public class Pokemon
    {
        public string name;
        public string element;
        public int health;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainer = new List<Trainer>();
            Console.WriteLine("Input information about the trainer and Pokemon it in the format “<TrainerName><PokemonName> <PokemonElement> <PokemonHealth>”");
            while (true)
            {
            e1:
                string s1 = Console.ReadLine();
                if (s1 == "Tournament")
                    break;
                string[] s11 = s1.Split(" ");
                if(s11.Length<4)
                {
                    Console.WriteLine("Error. All fields are mandatory.");
                    goto e1;
                }
                if (s11.Length > 4)
                {
                    Console.WriteLine("Error. There should be only 4 fields.");
                    goto e1;
                }
                bool good = true;
                for(int i=0;i<trainer.Count;i++)
                    if(trainer[i].name==s11[0])
                        good = false;
                    if(good)
                { 
                    Trainer a = new Trainer();
                    a.name = s11[0];
                    Pokemon b = new Pokemon();
                    b.name = s11[1];
                    b.element = s11[2];
                    b.health = Convert.ToInt32(s11[3]);
                    a.pokemon.Add(b);
                trainer.Add(a);
                }
                    else
                {
                    Pokemon b = new Pokemon();
                    b.name = s11[1];
                    b.element = s11[2];
                    b.health = Convert.ToInt32(s11[3]);
                    for (int i = 0; i < trainer.Count; i++)
                        if (trainer[i].name == s11[0])
                            trainer[i].pokemon.Add(b);
                }
            }
            bool q = false;
            while (!q)
            {                
                string s2 = Console.ReadLine();
                switch (s2)
                {
                    case "Fire":
                    case "Water":
                    case "Electricity":                        
                        for(int i=0;i<trainer.Count;i++)
                        {
                            int k = 0;
                            for (int j=0;j<trainer[i].pokemon.Count;j++)
                                if (trainer[i].pokemon[j].element == s2)
                                    k++;
                            if (k > 0)
                                trainer[i].number_of_badges++;
                            else
                            {
                                for(int j=0;j<trainer[i].pokemon.Count;j++)                                
                                    trainer[i].pokemon[j].health -= 10;                                    
                                for(int j=0;j<trainer[i].pokemon.Count;j++)
                                {
                                    if (trainer[i].pokemon[j].health <= 0)
                                    { 
                                        trainer[i].pokemon.RemoveAt(j);
                                        j--;
                                    }
                                }
                            }
                        }





                        break;
                    case "End":
                        q = true;
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
            for(int i=0;i<trainer.Count;i++)
            {
                for(int j=0;j<trainer.Count;j++)
                {
                    if(trainer[j].number_of_badges<trainer[i].number_of_badges)
                    {
                        Trainer t = trainer[i];
                        trainer[i] = trainer[j];
                        trainer[j] = t;
                    }
                }
            }
            for(int i=0;i<trainer.Count;i++)
            {
                Console.WriteLine($"{trainer[i].name} {trainer[i].number_of_badges} {trainer[i].pokemon.Count}");
            }
            Console.ReadKey();
        }
    }
}
