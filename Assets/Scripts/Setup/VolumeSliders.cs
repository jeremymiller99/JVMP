using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliders : MonoBehaviour
{
//--Variables--------------------------------------------------------------------------------------------
    [SerializeField] private Slider masterVolumeSlider;
    
//--Setup-Functions---------------------------------------------------------------------------------------
    void Start()
    {
        masterVolumeSlider.value = PlayerPrefs.GetFloat("MasterVolume");
        SoundManager.Instance.ChangeMasterVolume(masterVolumeSlider.value);
        masterVolumeSlider.onValueChanged.AddListener(value => SoundManager.Instance.ChangeMasterVolume(value));
    }

}
