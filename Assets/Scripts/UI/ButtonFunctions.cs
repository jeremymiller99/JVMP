using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
//--Button-Functions----------------------------------------------
    public void GoToLevelSelect(){
        SceneManager.LoadScene("01_LevelSelect");
    }

    public void GoToSettings(){
        SceneManager.LoadScene("02_Settings");
    }
    
    public void GoToLevel1(){
        SceneManager.LoadScene("1_White");
    }

    public void GoToMenu(){
        SceneManager.LoadScene("0_Menu");
    }

    public void GoToLevel2(){
        SceneManager.LoadScene("2_Blue");
    }

    public void GoToLevel3(){
        SceneManager.LoadScene("3_Green");
    }

    public void GoToLevel4(){
        SceneManager.LoadScene("4_Red");
    }

    public void GoToLevel5(){
        SceneManager.LoadScene("5_Orange");
    }

    public void GoToLevel6(){
        SceneManager.LoadScene("6_Pink");
    }

    public void GoToLevel7(){
        SceneManager.LoadScene("7_Purple");
    }

    public void GoToLevel8(){
        SceneManager.LoadScene("8_Cyan");
    }
}
