using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SkinManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int currentSkin;
    
    void Start(){
        UpdateSkin();
    }

    public void UpdateSkin(){
        currentSkin = PlayerPrefs.GetInt("currentSkin");
        sr.sprite = skins[currentSkin];
    }

    public void EquipWhite(){
        //if unlocked
        Debug.Log("white skin");
        PlayerPrefs.SetInt("currentSkin", 0);
    }

    public void EquipBlue(){
        Debug.Log("blue skin");
        //if unlocked
        PlayerPrefs.SetInt("currentSkin", 1);
    }
}
