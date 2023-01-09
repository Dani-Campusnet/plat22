using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GroundDetector_Trigger : MonoBehaviour
{
    public bool suelo;
    public float lenght = 1;
    public LayerMask mask;

    public List<Vector3> originPoints;
    // Update is called once per frame
    void Update()
    {
        suelo= false;
        for (int i = 0; i < originPoints.Count; i++)
        {
            Debug.DrawRay(transform.position + originPoints[i], Vector3.down * lenght, Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position + originPoints[i], Vector3.down, lenght, mask);
            if (hit.collider!=null)
            {
                if (hit.collider.tag=="plataforma movil")
                {
                    transform.parent = hit.transform;
                }
                Debug.DrawRay(transform.position + originPoints[i], Vector3.down * lenght, Color.green);
                suelo = true;
            }
            else
            {
                transform.parent = null;         
            }
        }
    }
}
