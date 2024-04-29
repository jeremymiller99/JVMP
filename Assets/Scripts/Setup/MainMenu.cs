using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class FlawlessChecker : MonoBehaviour
{
    [SerializeField] private Image check1;
    [SerializeField] private Image check2;
    [SerializeField] private Image check3;
    [SerializeField] private Image check4;
    [SerializeField] private Image check5;
    [SerializeField] private Image check6;
    [SerializeField] private Image check7;
    [SerializeField] private Image check8;
    
    void Update(){
        UpdateLevelSelect();
    }

    private void UpdateLevelSelect(){
        if(PlayerPrefs.GetInt("1Flawless") == 1){
            check1.enabled = true;
        } else {
            check1.enabled = false;
        }

        if(PlayerPrefs.GetInt("2Flawless") == 1){
            check2.enabled = true;
        } else {
            check2.enabled = false;
        }

        if(PlayerPrefs.GetInt("3Flawless") == 1){
            check3.enabled = true;
        } else {
            check3.enabled = false;
        }

        if(PlayerPrefs.GetInt("4Flawless") == 1){
            check4.enabled = true;
        } else {
            check4.enabled = false;
        }

        if(PlayerPrefs.GetInt("5Flawless") == 1){
            check5.enabled = true;
        } else {
            check5.enabled = false;
        }

        if(PlayerPrefs.GetInt("6Flawless") == 1){
            check6.enabled = true;
        } else {
            check6.enabled = false;
        }

        if(PlayerPrefs.GetInt("7Flawless") == 1){
            check7.enabled = true;
        } else {
            check7.enabled = false;
        }

        if(PlayerPrefs.GetInt("8Flawless") == 1){
            check8.enabled = true;
        } else {
            check8.enabled = false;
        }
    }
}
