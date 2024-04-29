using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
//--Variables------------------------------------------------------------
    [HideInInspector] public Rigidbody2D rb;
	[HideInInspector] public BoxCollider2D col;
	[HideInInspector] public Transform trans;

	[HideInInspector] public int deathCount;
	public int totalAttempts;

//--Setup-Functions--------------------------------------------------------
    void Awake ()
	{
		rb = GetComponent<Rigidbody2D> ();
		col = GetComponent<BoxCollider2D> ();
		trans = this.transform;
		deathCount = 1;
	}

//--Push-Function---------------------------------------------------------
    public void Push (Vector2 force)
	{
		rb.AddForce (force, ForceMode2D.Impulse);        
	}

//--Respawn----------------------------------------------------------------
	public void Respawn(Vector2 sp){
		deathCount += 1;
		rb.velocity = Vector2.zero;
		transform.position = sp;
	}

	public void AddToTotalAttempts(){
		totalAttempts += 1;
		PlayerPrefs.SetInt("TotalAttempts", PlayerPrefs.GetInt("TotalAttempts") + 1);
		Debug.Log(PlayerPrefs.GetInt("TotalAttempts").ToString());
	}
}
