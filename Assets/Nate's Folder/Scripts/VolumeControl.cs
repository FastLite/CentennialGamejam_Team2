using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    float volumeValue;

    public Slider volumeSlider;
    public Text showVolume;
    public AudioSource[] audioToAffect;

    private void Update()
    {
        volumeValue = volumeSlider.value;
        ChangeVolText();
        ChangeVolume();
    }

    void ChangeVolText()
    {
        float percent = volumeValue * 100;
        percent = Mathf.Round(percent);
        showVolume.text = percent.ToString() + "%";
    }

    void ChangeVolume()
    {
        foreach (AudioSource audio in audioToAffect)
        {
            audio.volume = volumeValue;
        }
    }


}
