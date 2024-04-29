using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
//--Variables------------------------------------------------------------------------------------
    [SerializeField] private Player player;
    [SerializeField] private AudioClip goalClip;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private WinScreen ws;

//--Functions-------------------------------------------------------------------------------
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Player")){
            TimerController.instance.EndTimer();
            SoundManager.Instance.PlaySound(goalClip);
            
            Scene currentScene = SceneManager.GetActiveScene();
            if(currentScene.name == "1_White"){
                Debug.Log("you beat level 1");
                ws.levelNum = 1;
                if(PlayerPrefs.GetFloat("1BT") == 0){
                    Debug.Log("You don't have a time yet");
                    PlayerPrefs.SetFloat("1BT", TimerController.instance.GetCurrentTime());
                }

                if(PlayerPrefs.GetFloat("1BT") > TimerController.instance.GetCurrentTime()){
                    Debug.Log("you beat your previous best time");
                    PlayerPrefs.SetFloat("1BT", TimerController.instance.GetCurrentTime());
                }
                
                if(player.deathCount == 0){
                    PlayerPrefs.SetInt("1Flawless", 1);
                }

            } else if(currentScene.name == "2_Blue"){
                Debug.Log("you beat level 2");
                ws.levelNum = 2;
                if(PlayerPrefs.GetFloat("2BT") == 0){
                    Debug.Log("You don't have a time yet");
                    PlayerPrefs.SetFloat("2BT", TimerController.instance.GetCurrentTime());
                }

                if(PlayerPrefs.GetFloat("2BT") > TimerController.instance.GetCurrentTime()){
                    Debug.Log("you beat your previous best time");
                    PlayerPrefs.SetFloat("2BT", TimerController.instance.GetCurrentTime());
                }
                
                if(player.deathCount == 0){
                    PlayerPrefs.SetInt("2Flawless", 1);
                }

            } else if(currentScene.name == "3_Green"){
                Debug.Log("you beat level 3");
                ws.levelNum = 3;
                if(PlayerPrefs.GetFloat("3BT") == 0){
                    Debug.Log("You don't have a time yet");
                    PlayerPrefs.SetFloat("3BT", TimerController.instance.GetCurrentTime());
                }

                if(PlayerPrefs.GetFloat("3BT") > TimerController.instance.GetCurrentTime()){
                    Debug.Log("you beat your previous best time");
                    PlayerPrefs.SetFloat("3BT", TimerController.instance.GetCurrentTime());
                }
                
                if(player.deathCount == 0){
                    PlayerPrefs.SetInt("3Flawless", 1);
                }

            } else if(currentScene.name == "4_Red"){
                Debug.Log("you beat level 4");
                ws.levelNum = 4;
                if(PlayerPrefs.GetFloat("4BT") == 0){
                    Debug.Log("You don't have a time yet");
                    PlayerPrefs.SetFloat("4BT", TimerController.instance.GetCurrentTime());
                }

                if(PlayerPrefs.GetFloat("4BT") > TimerController.instance.GetCurrentTime()){
                    Debug.Log("you beat your previous best time");
                    PlayerPrefs.SetFloat("4BT", TimerController.instance.GetCurrentTime());
                }
                
                if(player.deathCount == 0){
                    PlayerPrefs.SetInt("4Flawless", 1);
                }
               
            } else if(currentScene.name == "5_Orange"){
                Debug.Log("you beat level 5");
                ws.levelNum = 5;
                if(PlayerPrefs.GetFloat("5BT") == 0){
                    Debug.Log("You don't have a time yet");
                    PlayerPrefs.SetFloat("5BT", TimerController.instance.GetCurrentTime());
                }

                if(PlayerPrefs.GetFloat("5BT") > TimerController.instance.GetCurrentTime()){
                    Debug.Log("you beat your previous best time");
                    PlayerPrefs.SetFloat("5BT", TimerController.instance.GetCurrentTime());
                }
                
                if(player.deathCount == 0){
                    PlayerPrefs.SetInt("5Flawless", 1);
                }

            } else if(currentScene.name == "6_Pink"){
                Debug.Log("you beat level 6");
                ws.levelNum = 6;
                if(PlayerPrefs.GetFloat("6BT") == 0){
                    Debug.Log("You don't have a time yet");
                    PlayerPrefs.SetFloat("6BT", TimerController.instance.GetCurrentTime());
                }

                if(PlayerPrefs.GetFloat("6BT") > TimerController.instance.GetCurrentTime()){
                    Debug.Log("you beat your previous best time");
                    PlayerPrefs.SetFloat("6BT", TimerController.instance.GetCurrentTime());
                }
                
                if(player.deathCount == 0){
                    PlayerPrefs.SetInt("6Flawless", 1);
                }
                
            } else if(currentScene.name == "7_Purple"){
                Debug.Log("you beat level 7");
                ws.levelNum = 7;
                if(PlayerPrefs.GetFloat("7BT") == 0){
                    Debug.Log("You don't have a time yet");
                    PlayerPrefs.SetFloat("7BT", TimerController.instance.GetCurrentTime());
                }

                if(PlayerPrefs.GetFloat("7BT") > TimerController.instance.GetCurrentTime()){
                    Debug.Log("you beat your previous best time");
                    PlayerPrefs.SetFloat("7BT", TimerController.instance.GetCurrentTime());
                }
                
                if(player.deathCount == 0){
                    PlayerPrefs.SetInt("7Flawless", 1);
                }

            } else if(currentScene.name == "8_Cyan"){
                Debug.Log("you beat level 8");
                ws.levelNum = 8;
                if(PlayerPrefs.GetFloat("8BT") == 0){
                    Debug.Log("You don't have a time yet");
                    PlayerPrefs.SetFloat("8BT", TimerController.instance.GetCurrentTime());
                }

                if(PlayerPrefs.GetFloat("8BT") > TimerController.instance.GetCurrentTime()){
                    Debug.Log("you beat your previous best time");
                    PlayerPrefs.SetFloat("8BT", TimerController.instance.GetCurrentTime());
                }
                
                if(player.deathCount == 0){
                    PlayerPrefs.SetInt("8Flawless", 1);
                }
            }

            ws.ShowWinScreen();
        }
    }
}
