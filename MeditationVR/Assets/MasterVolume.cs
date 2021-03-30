using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MasterVolume : MonoBehaviour
{
    public void AdjustVolume(float newVolume)
    {
        AudioListener.volume = newVolume;
    }
}
