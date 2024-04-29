using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetection : MonoBehaviour
{
//--Variables--------------------------------------------------------
    public bool grounded;

    [SerializeField] private CameraShake camShake;
    [SerializeField] private ParticleSystem dust;
    [SerializeField] private AudioClip landClip;

//--On-Trigger-------------------------------------------------------
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Ground")){
            grounded = true;
            camShake.TriggerShake();
            dust.Play();
            SoundManager.Instance.PlaySound(landClip);
        }
    }

    void OnTriggerStay2D(Collider2D col){
        if(col.gameObject.CompareTag("Ground")){
            grounded = true;
        }
    }
}
