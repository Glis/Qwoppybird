using UnityEngine;
using System.Collections;

public class CollidingScript : MonoBehaviour
{
	public GameStateScript gamestate;
	public AudioSource hit;
	public AudioSource floor;
	bool counterTouched = false;

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "Floor" || coll.gameObject.tag == "Obstacle"){
			if(coll.gameObject.tag == "Floor" && !GameStateScript.gameOver)
				floor.Play();
			else if(coll.gameObject.tag == "Obstacle" && !GameStateScript.gameOver)
				hit.Play();	
			GameStateScript.gameOver = true;
			rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Counter")
			gamestate.addHop();
	}
}
