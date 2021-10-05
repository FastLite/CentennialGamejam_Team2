using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeIndicator : MonoBehaviour
{

    public Text timeIndicatorText;
    public bool isPresent = true;

    private void Update()
    {
        CheckPresent();
    }

    void CheckPresent()
    {
        if (isPresent == true)
        {
            timeIndicatorText.text = "Present";
        } else
        {
            timeIndicatorText.text = "Past";
        }
    }

}
