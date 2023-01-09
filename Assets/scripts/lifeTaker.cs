using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeTaker : MonoBehaviour
{
    public string target = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag==target)
        {
            collision.GetComponent<lifeController>().Death();
        }
    }
}
