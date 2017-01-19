using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject, 5.0f);
    }
}
