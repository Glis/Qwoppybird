using UnityEngine;
using System.Collections;

public class FloorMove : MonoBehaviour {

	public float speed ;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (true) {
			rigidbody2D.velocity = new Vector2(speed,0);
		} else {
			rigidbody2D.velocity = Vector2.zero;
		}
	}
}
