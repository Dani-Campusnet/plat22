using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    public string target = "Player";
    public GameObject pared;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == target)
        {
            Destroy(gameObject);
            pared.SetActive(false);
        }
    }
}
