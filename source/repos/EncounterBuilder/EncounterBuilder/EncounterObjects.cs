using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterBuilder {


    internal class Character {

        // vars
        string name = "Enter Name Here!";
        int hitPoints = 1;
        int initScore = 1;
        int armorClass = 1;


        // constructors
        public Character() { 

        }// end empty arg constructor

        public Character(string name, int hitPoints, int initScore, int armorClass) {

            SetName(name);
            SetHitPoints(hitPoints);
            SetInitScore(initScore);  
            SetArmorClass(armorClass);
           
        }// end Character constructor


        // methods
        public LinkedListNode<Character> ToList() {

            return null;

        }// end ToList


        // getters and setters
        public string GetName(){
            return name;
        }// end getter name

        public void SetName(string name){
            this.name = name;
        }// end setter name

        public int GetHitPoints() {
            return hitPoints;
        }// end getter hitpoints

        public void SetHitPoints(int hitPoints) { 
            this.hitPoints = hitPoints;
        }// end setter hitpoints

        public int GetInitScore(){
            return initScore;
        }// end getter initScore

        public void SetInitScore(int initScore) {
            this.initScore = initScore;
        }// end setter initscore

        public int GetArmorClass() {
            return armorClass;
        }// end getter armorClass

        public void SetArmorClass(int armorClass) {
            this.armorClass = armorClass;
        }// end setter armorclass




    }// end class Character


    internal class NPC : Character {

    }// end subclass NPC


    internal class PC : Character {

    }// end subclass PC


    internal class Encounter {

        // vars
        LinkedList<Character> EncounterList = new LinkedList<Character>();

        //constructors
        public Encounter() {

        }// empty arg constructor

        // methods
        public void AddChar(LinkedListNode<Character> c) {
            EncounterList.AddLast(c);
        }// end addchar

        // sorts the encounter list in initiative order, called by the sort button
        public void InitSort() {

        }// end initsort

    }// end class Encounter


}// end namespace encounterbuilder
