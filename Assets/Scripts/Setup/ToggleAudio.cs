using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{
//--Variables-------------------------------------------------------------------------------
    [SerializeField] private bool toggleMusic, toggleEffects;

//--Functions------------------------------------------------------------------------------
    public void Toggle(){
        if(toggleEffects) SoundManager.Instance.ToggleEffects();
        if(toggleMusic) SoundManager.Instance.ToggleMusic();
    }
}
