using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMvmt : MonoBehaviour {
    
    private float x = 0;
    private float y = 0;
    public float speed = 5;
    private Vector3 dir;
    private Vector3 target;

	void Start ()
    {
	}
	
	void Update ()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        target = new Vector3(transform.position.x + x, transform.position.y + y, 0);
        dir = (target - transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
    }
}
