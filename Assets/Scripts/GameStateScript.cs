using UnityEngine;
using System.Collections;

public class GameStateScript : MonoBehaviour
{
	public static bool initialTap = false;
	public static bool gameStarted = false;
	public static bool gameOver = false;	
	public static int  hops = 0; 			

	// Use this for initialization
	void Start(){
	
	}
	
	// Update is called once per frame
	void Update(){
		if(initialTap){
			InvokeRepeating("addHop", 4.1f, 2.0f);
			initialTap = false;
		}

		if(gameOver){
			CancelInvoke();
		}

		if(gameOver && Input.GetKeyDown(KeyCode.R)){
			reset();
		}
	}

	void reset(){
		initialTap = false;
		gameStarted = false;
		gameOver = false;	
		hops = 0; 			
		Application.LoadLevel("game");
	}
	void addHop(){
		hops++;
	}


}
