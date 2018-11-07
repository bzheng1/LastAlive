using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {
    Rigidbody myrigidbody;
    Vector3 velocity;

	// Use this for initialization
	void Start () {
        myrigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    public void FixedUpdate()
    {
        myrigidbody.MovePosition(myrigidbody.position + velocity * Time.fixedDeltaTime);
    }
}
