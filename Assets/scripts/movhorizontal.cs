using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movhorizontal : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed=20;
    GroundDetector_Trigger suelo;
    Animator anim;
    public int force = 380;
    // Start is called before the first frame update
    void Start()
    {
        suelo= GetComponent<GroundDetector_Trigger>();
        anim= GetComponent<Animator>();
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal= Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(horizontal * Time.deltaTime*speed, 0);
        anim.SetBool("suelo",suelo.suelo);
        anim.SetBool("movimiento", horizontal != 0);
        if (horizontal>0)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        if (horizontal<0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetButtonDown("Jump") && suelo.suelo)
        {
            rb.AddForce(new Vector2(0, force));

        }

    }
}
