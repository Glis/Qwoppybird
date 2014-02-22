using UnityEngine;
using System.Collections;

public class GameGenerator : MonoBehaviour
{
	public GameObject floorBlock;
	public GameObject obstacle;

	// Use this for initialization
	void Start(){
		InvokeRepeating("generateFloor", 0f, 0.24f);
		InvokeRepeating("generatePipe", 1.8f, 1.8f);
	}
	
	// Update is called once per frame
	void Update(){

	}

	void generatePipe(){
		Vector3 newPosition = new Vector3(this.transform.position.x, Random.Range(-3f, 4f));
		Instantiate(obstacle, newPosition, new Quaternion());
	}

	void generateFloor(){
		Instantiate(floorBlock, new Vector3(this.transform.position.x, floorBlock.transform.position.y), new Quaternion());
	}
}
