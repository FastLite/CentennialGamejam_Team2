using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossEnergy : MonoBehaviour
{
    public EnergyBar energyBarScript;
    public bool useEnergy = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (useEnergy)
            {
                AddUsedEnergy();
            } else 
            {
                MinusUsedEnergy();
            }
        }
    }

    void AddUsedEnergy()
    {
        if (energyBarScript.usedEnergy < energyBarScript.maxEnergy)
        {
            energyBarScript.usedEnergy = energyBarScript.usedEnergy + 1;
        }
    }

    void MinusUsedEnergy()
    {
        if (energyBarScript.usedEnergy  > 0)
        {
            energyBarScript.usedEnergy = energyBarScript.usedEnergy - 1;
        }
    }

}
