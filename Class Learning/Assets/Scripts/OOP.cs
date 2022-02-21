using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Monobehaviour can be attached to Unity game objects
public class OOP : MonoBehaviour
{
    private void Start()
    {
        Fish fish; //create an empty variable that stores fish data type
        //instantiate fish and store in variable
        fish = new Fish("Tuna", 4);
        fish.PrintAnimal(); //call PrintAnimal method from fish

        Toyota t = new Toyota(50);
        t.Drive();
        BMW bmw = new BMW(70);
        bmw.Drive();
        Holden holden = new Holden(25);
        holden.Drive();
    }
}

//Abstract classes can only be inherited from, not instantiated
public abstract class Animal
{
    //encapsulated data can only be changed from within the class
    private string name;
    private int age;

    //class constructor for instantiating the object
    public Animal(string _name, int _age) //class constructor
    {
        name = _name;
        age = _age;
    }

    //Abstract method must be implemented in all derived (child) classes
    public abstract void Eat();
    public abstract void Eat(string food);

    //Virtual method may have implementation overriden
    public virtual void PrintAnimal()
    {
        Debug.Log("Name: " + name);
        Debug.Log("Age: " + age);
    }
}

public class Fish : Animal //Fish class inherits the animal class
{
    //Fish constructor
    //Passes parameters to base class constructor
    public Fish(string _name, int _age) : base(_name, _age)
    {

    }
    
    //Override version of Animal's Eat method
    public override void Eat()
    {
        Debug.Log("Fish is eating.");
    }

    public override void Eat(string food)
    {
        Debug.Log("Fish has eaten " + food);
    }

    //Extended version of Animal's PrintAnimal method
    public override void PrintAnimal()
    {
        base.PrintAnimal();
        Debug.Log("This is a Fish");
    }
}

public abstract class Vehicle
{
    private int speed;

    public Vehicle(int _speed)
    {
        speed = _speed;
    }
    public virtual void Drive()
    {
        Debug.Log("Driving at " + speed + " KMH.");
    }
}

public class Toyota : Vehicle
{
    public Toyota(int _speed) : base(_speed)
    {

    }

    public override void Drive()
    {
        base.Drive();
        Debug.Log("Car is moving.");
    }
}

public class Holden : Vehicle
{
    public Holden(int _speed) : base(_speed)
    {

    }

    public override void Drive()
    {
        base.Drive();
        Debug.Log("Car is stopped.");
    }
}

public class BMW : Vehicle
{
    public BMW(int _speed) : base(_speed)
    {

    }

    public override void Drive()
    {
        base.Drive();
        Debug.Log("The car is speeding.");
    }
}
