using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dragon : Animal
{

    // Defines the gameobject of the player
    public GameObject Player;

    public override void feed()
    {
        if (hunger <= maxHunger)
        {
            hunger++;
        }
    }

    public override void pet()
    {
        happiness--;
    }

    

    void Start()
    {

        // Defines all the properties of the dragon
        this.hunger = 100.0f;
        this.maxHunger = 100.0f;
        this.movementSpeed = 3.0f;
        this.happiness = 100;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Player)
        { 

        }
    }
}


