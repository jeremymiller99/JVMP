using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text wsTimeText;
    [SerializeField] private TMP_Text timerText;

    [SerializeField] private TMP_Text bestTimeText;

    [SerializeField] private TMP_Text attemptsText;

    [SerializeField] private Player player;

    public int levelNum;

    private void Start(){
        this.gameObject.SetActive(false);
    }

    public void ShowWinScreen(){
        this.gameObject.SetActive(true);
        Time.timeScale = 0;
        wsTimeText.text = timerText.text;
        attemptsText.text = player.deathCount.ToString();
        if (levelNum == 1){
            bestTimeText.text = PlayerPrefs.GetFloat("1BT").ToString("F2");
        }
        if (levelNum == 2){
            bestTimeText.text = PlayerPrefs.GetFloat("2BT").ToString("F2");
        }
        if (levelNum == 3){
            bestTimeText.text = PlayerPrefs.GetFloat("3BT").ToString("F2");
        }
        if (levelNum == 4){
            bestTimeText.text = PlayerPrefs.GetFloat("4BT").ToString("F2");
        }
        if (levelNum == 5){
            bestTimeText.text = PlayerPrefs.GetFloat("5BT").ToString("F2");
        }
        if (levelNum == 6){
            bestTimeText.text = PlayerPrefs.GetFloat("6BT").ToString("F2");
        }
        if (levelNum == 7){
            bestTimeText.text = PlayerPrefs.GetFloat("7BT").ToString("F2");
        }
        if (levelNum == 8){
            bestTimeText.text = PlayerPrefs.GetFloat("8BT").ToString("F2");
        }
    }
}
