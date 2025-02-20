using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Defines how we want all animals to work
public abstract class Animal : MonoBehaviour
{
    public float hunger;
    public float maxHunger;
    public float happiness;
    public float movementSpeed;
    public Collider2D pen;

    // Defines the gameobject of the player
    public GameObject Player;

    public abstract void pet();

    public abstract void feed();

}

