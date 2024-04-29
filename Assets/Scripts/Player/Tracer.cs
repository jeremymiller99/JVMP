using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracer : MonoBehaviour
{
//--Variables------------------------------------------------------------
    public LineRenderer lr;
    public Transform[] points;
    
//--Setup-Functions--------------------------------------------------------
    void Awake()
    {
        lr = GetComponent<LineRenderer>();
        lr.enabled = false;
    }
}
