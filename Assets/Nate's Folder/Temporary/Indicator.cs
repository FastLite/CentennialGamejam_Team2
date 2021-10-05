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
            if (indi.isPresent == false)
            {
                indi.isPresent = true; 
            } else
            {
                indi.isPresent = false;
            }
        }
    }


}
