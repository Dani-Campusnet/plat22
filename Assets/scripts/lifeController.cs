using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeController : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform respawn;
    public GameObject platmuerte;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    public void Death()
    {
        rb.velocity = new Vector2(0, 0);
        Instantiate(platmuerte,transform.position,transform.rotation);
        transform.position = respawn.position;
    }
}
