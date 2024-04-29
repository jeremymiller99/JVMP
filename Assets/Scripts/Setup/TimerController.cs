using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
//--Variables---------------------------------------------------------------------
    public static TimerController instance;

    [SerializeField] private TMP_Text timerText;

    public float timerTime;
    private TimeSpan timePlaying;
    private bool timerGoing;
    private float startTime;
    public string timePlayingStr;

    private float elapsedTime;

//--Setup-Functions-----------------------------------------------------------------
    private void Awake(){
        instance = this;
    }

    private void Start(){
        timerText.text = "0.00";
        timerGoing = true;
    }

    private void Update(){
        if (timerGoing){
            TimerUpdate();
        }
    }

//--Timer-Functions-------------------------------------------------------------------
    public void EndTimer(){
        timerGoing = false;
    }

    private void TimerUpdate(){
        timerTime += Time.deltaTime;
        timerText.text = timerTime.ToString("F2");
    }

    public float GetCurrentTime(){
        return timerTime;
    }
}
