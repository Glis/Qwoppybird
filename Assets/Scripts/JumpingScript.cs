using UnityEngine;
using System.Collections;

public class JumpingScript : MonoBehaviour {

	public KeyCode Jump;
	public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(Jump)){
			float velY = speed;
			if(velY> 10f){
				velY=10f;
			}
			rigidbody2D.velocity = new Vector2(0, velY);
		}
	}
}
