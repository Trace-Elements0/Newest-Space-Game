using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using AutoMapper.Internal;
using Unipluss.Sign.ExternalContract.Entities;

namespace SpaceGameTest
{
    public class Characters
    {
        //getsets auotmap the properties
        
        public string Name { get; set; }
        public int Health { get; set; }
        public int Loot { get; set; }
        public ProductTypes Product { get; set; }
        public WeaponTypes Weapon { get; set; }
        public CharacterTypes CharacterType { get; set; }

        public Characters()
        {

        }

        public Characters(string name, int health, int loot, ProductTypes products, WeaponTypes weapons, CharacterTypes charactertype)
        {
            Name = name;
            Health = health;
            Loot = loot;
            Product = products;
            Weapon = weapons;
            CharacterType = charactertype;
        }

        public string StatusUpdate()
        {
            string result = Name + "Health: " + Health + "Loot:\n" + Loot;
            return result;
        }

        public override string ToString()
        {
            string result = "Name: " + Name +
                            "\nHealth: " + Health +
                            "\nLoot: " + Loot +
                            "\nProducts:" + Product.ToString() +
                            "\nWeapons: " + Weapon.ToString();
            return result;
        }

        public enum ProductTypes : short
        {
            Ore,
            Kit,
            Petroleum,
            Fuel,
            Hydrogen,
            Food,
            Aluminum
        }

        public enum WeaponTypes
        {
            Musket = 1,
            Sword,
            Blunderbuss,
            Dukes
        }

        public enum CharacterTypes
        {
            Hero, Alien
        }

       
    }
}