using UnityEngine;
using System.Collections;

public class JumpingScript : MonoBehaviour
{
	public KeyCode flap;
	public KeyCode flop;
	public float speed;
//	private float curving = 90f;

	public bool wasFlap = false;

// Update is called once per frame
	void Update(){
		if(!GameStateScript.gameStarted){
			if(Input.GetKeyDown(flap)){
				rigidbody2D.gravityScale = 2.0f;
				GameStateScript.gameStarted = true;
				GameStateScript.initialTap = true;
				wasFlap = true;	
			}
		} else{
			if(!GameStateScript.gameOver){
				if(Input.GetKeyDown(flap)){
					if(!wasFlap){
						float velY = (speed / 3);
						rigidbody2D.velocity = new Vector2(0, velY);
						//				rigidbody2D.AddTorque(-curving);
						//				rigidbody2D.angularVelocity = curving;
					}
					wasFlap = true;
				}
				if(Input.GetKeyDown(flop) && wasFlap){
					float velY = speed;
					if(velY > 10f){
						velY = 10f;
					}
					rigidbody2D.velocity = new Vector2(0, velY);
					//			rigidbody2D.AddTorque(curving * 4f);
					//			rigidbody2D.angularVelocity = -curving;
					wasFlap = false;
				}
				//		if(rigidbody2D.angularVelocity > 10f)
				//			rigidbody2D.angularVelocity = 10f;
			}
		}
	}
}