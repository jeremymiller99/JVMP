using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
//--Variables------------------------------------------------------------------------------
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Player player;
    [SerializeField] private AudioClip landClip;

//--Functions------------------------------------------------------------------------------
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Player")){
            player.Respawn(spawnPoint.transform.position);
            SoundManager.Instance.PlaySound(landClip);
            player.AddToTotalAttempts();
        }
    }
}
