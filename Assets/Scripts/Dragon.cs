using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Dragon : Animal, IInteractable
{
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
        this.GameObj = GetComponent<GameObject>();

    }

    void OnCollisionEnter(Collision collision)
    {

        // Checks if is colliding with charichter
        if (collision.gameObject == this.Player)
        { 
           // Makes the sign appear
           this.ActionSign.SetActive(true);
           this.isNearPlayer = true;
        }
    }

    // Checks if it is no longer near to the player
    void OnCollisionExit(Collision collision) 
    {
        if (collision.gameObject == this.Player) 
        { 
            this.ActionSign.SetActive(false);
            this.isNearPlayer = false;
        }
    }

    void Update()
    {
        
    }

    public void interact()
    {
        feed();
    }
}


