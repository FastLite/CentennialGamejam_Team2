using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{

    public Image energyBarImage;
    public Sprite[] energyBarSprites;
    public int maxEnergy = 3;
    public int usedEnergy = 0;

    private void Update()
    {
        CheckEnergy();
    }

    void CheckEnergy()
    {
        if (usedEnergy < maxEnergy)
        {
            energyBarImage.sprite = energyBarSprites[usedEnergy];
        }
        else if (usedEnergy == maxEnergy) 
        {
            energyBarImage.sprite = energyBarSprites[maxEnergy];
        }
    }

}
