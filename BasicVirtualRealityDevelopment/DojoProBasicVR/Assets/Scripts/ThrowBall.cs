using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour {

    public Rigidbody ball;
    public Transform throwPosition;
    public float throwForce = 1000f;
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetMouseButtonDown(0))
        {
            Rigidbody thrownBall = Instantiate(ball, throwPosition.position, throwPosition.rotation);
            thrownBall.AddForce(throwPosition.forward * throwForce);
        }
	}
}
