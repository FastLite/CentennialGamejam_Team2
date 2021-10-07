using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour
{

    public TimeIndicator indi;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (indi.isDimentionA == false)
            {
                indi.isDimentionA = true; 
            } else
            {
                indi.isDimentionA = false;
            }
        }
    }


}
