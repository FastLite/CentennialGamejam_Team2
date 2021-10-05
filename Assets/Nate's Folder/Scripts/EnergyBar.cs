using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    // variable with UI image to change the sprite of
    public Image energyBarImage;

    // Array with sprites used for energy away
    // NOTE: MAKE SURE SPRITES IN ARRAY ARE PUT SO THAT 0 IS FULL (ENERGY) TO BIGGEST NUMBER IN ARRAY IS EMPTY (NO ENERGY), so for example 0 is 3 bars, 1 is 2 bars, 2 is 1 bar and 3 is 0 bars of enegy
    public Sprite[] energyBarSprites;

    // variable that is the max energy until all energy used
    public int maxEnergy = 3;

    // variable that is how much out of the max energy have been used (LEAVE AT ZERO)
    public int usedEnergy = 0;

    private void Update()
    {
        CheckEnergy();
    }

    // function that when called if used energy is less than max energy change the images sprite to the sprite in the array with the same value as usedEnergy otherwise change to same value as maxEnergy
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
