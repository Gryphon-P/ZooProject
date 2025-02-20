using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    [SerializeField]
    Dragon dragon;

    [SerializeField]
    Unicorn unicorn;

    [SerializeField]
    Griffon griffon;

    [SerializeField]
    Jackalope jackalope;

    Animal[] animals = new Animal[4];

    void Start()
    {
        // Do stuff once for all animals
        animals[0] = dragon;
        animals[1] = unicorn;
        animals[2] = griffon;
        animals[3] = jackalope;
    }

    void Update()
    {
        // Do stuff every frame for all animals
        for (int i = 0; i < animals.Length; i++)
        {

        }
    }
}
