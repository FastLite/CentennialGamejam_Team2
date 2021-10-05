using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossEnergy : MonoBehaviour
{
    public EnergyBar EnergyBarScript;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (EnergyBarScript.usedEnergy < EnergyBarScript.maxEnergy)
            {
                EnergyBarScript.usedEnergy = EnergyBarScript.usedEnergy + 1;
            }
        }
    }


}
