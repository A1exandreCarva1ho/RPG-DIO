using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Project.src.Entities
{
    public abstract class Character
    {
        public string name { get; set; }
        public int level { get; set; }
        public string characterClass = "";
        public int maxHealthPoints { get; set; }

        public int healthPoints;
        public int magicPoints { get; set; }

        public int baseDamage;

        public void SetHP(){
            this.healthPoints = this.level * 2 + 10;
        }

        public void SetMP(){
            this.magicPoints = this.level * 5;
        }


        public Character(string name,int level){
            this.name = name;
            this.level = level;

            SetHP();
            SetMP();
        }


        public virtual string Atacar(){
            return $"O Personagem {this.name} atacou com as mãos";
        }
    }
}