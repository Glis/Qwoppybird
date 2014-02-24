using UnityEngine;
using System.Collections;

public class GameGenerator : MonoBehaviour
{
	public GameObject floorBlock;
	public GameObject obstacle;
	public GameObject floorParent;
	public GameObject pipeParent;

	// Use this for initialization
	void Start(){
		InvokeRepeating("generateFloor", 0f, 1.75f);
	}
	
	// Update is called once per frame
	void Update(){
		if(GameStateScript.initialTap){
			InvokeRepeating("generatePipe", 0.5f, 2.0f);
		}
		if(GameStateScript.gameOver){
			CancelInvoke();
		}
	}

	void generatePipe(){
		Vector3 newPosition = new Vector3(this.transform.position.x, Random.Range(-3f, 3f));
		GameObject g = (GameObject)Instantiate(obstacle, newPosition, new Quaternion());
		g.transform.parent = pipeParent.transform;
	}

	void generateFloor(){
		GameObject g = (GameObject)Instantiate(floorBlock, new Vector3(this.transform.position.x, floorBlock.transform.position.y), new Quaternion());
		g.transform.parent = floorParent.transform;
	}
}
