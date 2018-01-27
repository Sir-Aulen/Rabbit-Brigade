using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mvmt : MonoBehaviour {

    public float moveSpeed;
    float x = 0;
    float y = 0;

    float wraithWalk = 0;
    bool checkColl = false;

    Rigidbody2D rb;
    CapsuleCollider2D coll;
    Animator anim;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<CapsuleCollider2D>();
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ground")
        {
            checkColl = true;
        }
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");        //Get user inputs
        y = Input.GetAxis("Vertical");
        wraithWalk = Input.GetAxis("Wraithwalk");

        if (wraithWalk > 0)
        {
            coll.enabled = false;
            anim.SetBool("wraithWalk?", true);

        }
        else
        {
            if (!checkColl)
            {
                coll.enabled = true;
                anim.SetBool("wraithWalk?", false);
            }
        }

        rb.velocity = new Vector2(x, y);        //Move
    }
}