using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
//--Variables-----------------------------------------------------------
    private Camera cam;
    [SerializeField] private Player player;
	[SerializeField] private Tracer tracer;
	[SerializeField] private GroundDetection gd;
	[SerializeField] private CameraShake camShake;
	[SerializeField] private ParticleSystem dust;
	[SerializeField] private Transform spawnPoint;
	[SerializeField] private AudioClip jumpClip;
	
	[SerializeField] private float pushForce = 5f;
	[SerializeField] private float maxDistance = 2f;

	bool isDragging = false;

	private Vector2 startPoint;
	private Vector2 endPoint;
	private Vector2 direction;
	private Vector2 force;
	private float distance;
    
//--Setup-Functions--------------------------------------------------------
	void Start()
    {
		Time.timeScale = 1;
		pushForce = 5.25f;
		maxDistance = 2.25f;
        cam = Camera.main;
		player.trans.position = spawnPoint.transform.position;
    }

	void Update()
    {
        if (Input.GetMouseButtonDown (0)) {
			isDragging = true;
			OnDragStart ();
		}
		if (Input.GetMouseButtonUp (0)) {
			isDragging = false;
			OnDragEnd ();
		}

		if (isDragging) {
			OnDrag ();
		}

    }

//--Drag-Functions------------------------------------------------------------------
    void OnDragStart ()
	{
		startPoint = cam.ScreenToWorldPoint (Input.mousePosition);
		tracer.lr.enabled = true;
	}

	void OnDrag ()
	{
		endPoint = cam.ScreenToWorldPoint (Input.mousePosition);
		distance = Vector2.Distance (startPoint, endPoint);
        if(distance <= maxDistance){
            direction = (startPoint - endPoint).normalized;
		   	force = direction * distance * pushForce;
            
            Debug.DrawLine (startPoint, endPoint);
			tracer.lr.SetPosition(0, startPoint);
			tracer.lr.SetPosition(1, endPoint);
		}
	}

	void OnDragEnd ()
	{
		if(gd.grounded){
			player.Push (force);
			tracer.lr.enabled = false;
			gd.grounded = false;
			dust.Play();
			SoundManager.Instance.PlaySound(jumpClip);
		}
	}
}
