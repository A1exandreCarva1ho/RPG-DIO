using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Project.src.Entities
{
    public class WhiteWizzard: Character
    {

        int pontosDeCura;

        public WhiteWizzard(string name,int level):base(name,level){
            this.name = name;
            this.level = level;
            this.characterClass = "WhiteWizzard";
            SetHP();
            SetMP();
            this.pontosDeCura = 5;
        }

        public override string Atacar(){
           return $"O Personagem {this.name} atacou com bola de fogo";
        }


        public string Curar(List<Character> party){

            foreach (Character character in party){
                character.healthPoints = character.healthPoints+ this.pontosDeCura;
                if (character.healthPoints>character.maxHealthPoints){
                    character.healthPoints=character.maxHealthPoints;
                }
            }

            return $"O Personagem {this.name} curou todos os aliados em {this.pontosDeCura} de hp";
        }   

    }
}