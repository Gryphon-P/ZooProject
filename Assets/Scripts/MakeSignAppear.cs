using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSignAppear : MonoBehaviour
{
    public GameObject Player;
    public GameObject Sign;
    void Update()
    {
        float Distance = Mathf.Sqrt(Mathf.Pow((Player.transform.position.x - transform.position.x), 2.0f) + Mathf.Pow((Player.transform.position.y - transform.position.y), 2.0f));
        if (Distance <= 5.0f) {
            Sign.SetActive(true);
        }

        else {
            if (Sign.activeSelf) {
                Sign.SetActive(false);
            }
            
        }
    }
}
