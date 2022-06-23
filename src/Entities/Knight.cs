using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Project.src.Entities
{
    public class Knight : Character
    {
        public Knight(string name,int level):base(name,level){
            this.name = name;
            this.level = level;
            this.characterClass = "Knight";
            SetHP();
            SetMP();
        }

        public override string Atacar(){
           return $"O Personagem {this.name} atacou com a espada";
        }

    }
}