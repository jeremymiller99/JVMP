using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{   
//--Variables------------------------------------------------------------------------------------------
    public static SoundManager Instance;
    [SerializeField] private AudioSource _musicSource, _effectsSource;

//--Setup-Functions------------------------------------------------------------------------------------
    void Awake(){
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }

        ChangeMasterVolume(PlayerPrefs.GetFloat("MasterVolume"));
    }

//--Sound-Functions---------------------------------------------------------------------------------------
    public void PlaySound(AudioClip clip){
        _effectsSource.PlayOneShot(clip);
    }

    public void ChangeMasterVolume(float value){
        AudioListener.volume = value;
        PlayerPrefs.SetFloat("MasterVolume", value);
    }

    public void ToggleEffects(){
        _effectsSource.mute = !_effectsSource.mute;
    }

    public void ToggleMusic(){
        _musicSource.mute = !_musicSource.mute;
    }
}
