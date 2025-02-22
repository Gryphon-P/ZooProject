using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class Dragon : Animal, IInteractable, IPet
{
    // Refrences the script that takes in the player's input
    public PlayControlScript controller;

    public override void feed()
    {

        Debug.Log("Test 3");
        hunger++;
        this.textOutput.text = "You fed the dragon. He seems very satisfied! His hunger is " + hunger.ToString();
        
    }

    public override void petAnimal()
    {
        happiness--;
        this.textOutput.text = "You pet the dragon. He seems upset! His happiness is " + happiness.ToString();
    }

    void Start()
    {

        // Defines all the properties of the dragon
        this.hunger = 100.0f;
        this.maxHunger = 100.0f;
        this.happiness = 100;
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








