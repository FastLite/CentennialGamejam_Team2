using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeIndicator : MonoBehaviour
{

    // text that represents the Indicator text
    public Image indicator;

    public Sprite areaA;
    public Sprite areaB;

    // bool that determines if the time is in the present
    public bool isDimentionA = true;

    private void Update()
    {
        CheckPresent();
    }

    // if it is the present change the Text variable to Present and if it is not change it to past
    void CheckPresent()
    {
        if (isDimentionA == true)
        {
            indicator.sprite = areaA;
        } else
        {
            indicator.sprite = areaB;
        }
    }

}
