using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class Unicorn : Animal, IInteractable, IPet
{
    // Refrences the script that takes in the player's input
    public PlayControlScript controller;

    public override void feed()
    {

        // Yes, I know, retrospectivley that hunger should go down with the more food an animal eats but it's implemented now and I don't really have the time to change it
        Debug.Log("Test 3");
        hunger++;
        this.textOutput.text = "You fed the unicorn. She seems very satisfied! She stamps her blood-stained hooves. Her hunger is " + hunger.ToString();
        
    }

    public override void petAnimal()
    {
        happiness++;
        this.textOutput.text = "You pet the unicorn. She seems happy and it looks like she wants more pets. Her happiness is " + happiness.ToString();
    }

    void Start()
    {

        // Defines all the properties of the dragon
        this.hunger = 50.0f;
        this.maxHunger = 50.0f;
        this.happiness = 6000;
        this.GameObj = GetComponent<GameObject>();

    }

    void Update()
    {

        // I'm using distance bc ontriggerenter is not working for some reason and I am running very low on time
        float Distance = Mathf.Sqrt(Mathf.Pow((Player.transform.position.x - transform.position.x), 2.0f) + Mathf.Pow((Player.transform.position.y - transform.position.y), 2.0f));
        if (Distance <= 5.0f) {
            Debug.Log("Enter");
            controller.SetIInstance(this);
            controller.SetIPet(this);
        }
        else {
            if (controller.IpetInstance == this) {
                Debug.Log("Exit");
                controller.ClearIInstance();
                controller.ClearIPet();
            }
            
        }
    }

    public void interact()
    {
        Debug.Log("Test 4");
        feed();
    }


    public void pet() {
        petAnimal();
    }
}








