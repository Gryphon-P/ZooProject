using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Griffon : Animal
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
        happiness++;
    }
}