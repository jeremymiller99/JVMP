using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestTimeRetriever5 : MonoBehaviour
{
    private TMP_Text text;
        
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update(){
        GetBestTime();
    }

    public void GetBestTime()
    {
        if(PlayerPrefs.GetFloat("6BT") == null){
            text.text = "None";
        } else {
            text.text = PlayerPrefs.GetFloat("6BT").ToString("F2");
        }
    }
}
