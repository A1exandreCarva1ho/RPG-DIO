using System;
using RPG_Project.src.Entities;
using System.Collections;

namespace RPG_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {


           List <Character> Party = new List <Character>();     

           Knight Arus = new Knight("Arus",42);   
           Party.Add(Arus);

           Ninja Wedge = new Ninja("Wedge",42);     
           Party.Add(Wedge);

           WhiteWizzard Jenica = new WhiteWizzard("Jenica",42);     
           Party.Add(Jenica);

           BlackWizzard Topapa = new BlackWizzard("Topapa",42);     
           Party.Add(Topapa);


           Console.WriteLine("Todos os seus heróis estão prontos para atacar!");

           Console.WriteLine(Arus.Atacar());
           Console.WriteLine(Wedge.Atacar());
           Console.WriteLine(Jenica.Atacar());
           Console.WriteLine(Topapa.Atacar());

           Console.WriteLine(Jenica.Curar(Party));

        }
    }
}
