using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jackalope : Animal
{
    // Feed a femboy to the jackalope
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