using UnityEngine;
using System.Collections;

public class FloorMove : MonoBehaviour
{

	public float speed ;
		
	// Update is called once per frame
	void Update(){
		if(!GameStateScript.gameOver){
			rigidbody2D.velocity = new Vector2(speed, 0);
		} else{
			rigidbody2D.velocity = Vector2.zero;
		}

		if(this.transform.position.x < -18){
			GameObject.Destroy(this.gameObject);
		}
	}
}
