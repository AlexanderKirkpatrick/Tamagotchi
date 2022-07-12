using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Tamagotchi 
  {
    private int _hunger = 100;
    private int _happiness = 100;
    private int _rest = 100;
    public string Description {get; set;} 
    private static List<Tamagotchi> _instances = new List<Tamagotchi> {};

    // public TamagotchiName (string description)
    // {
    //   Description = description;
    //   _instances.Add(this);
    // }

    // public TamagotchiStats (int hunger, int happiness, int rest)
    // {
    //   _hunger = hunger;
    //   _happiness = happiness;
    //   _rest = rest;
    // }

    public int Food() 
    {
      return _hunger;
    }

    public static void Feed() 
    {
      _hunger += 10;
    }


    public int Attention() 
    {
      return _happiness;
    }

    public static void Play()
    {
      _happiness += 10;
    }

    public int Rest()
    {
      return _rest;
    }

    public static void Sleep()
    {
      _rest += 10;
    }

    public static void Time()
    {
      _hunger -= 10;
      _happiness -= 10;
      _rest -= 10;
    }
  }
}

//form to name and activate tamagotchi
//Hunger meter, happy meter, rest meter
//methods could be: Feed, play, sleep -hamburge/cake etc
