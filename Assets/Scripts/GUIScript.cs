using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour
{
	public GUISkin gameSkin;

	void OnGUI(){
		GUI.skin = gameSkin;

		int topSeparation = Screen.height * 10 / 100;
		int pointLabelWidth = 30;
		int pointLabelHeight = 30;
		int halfScreenWidth = Screen.width / 2;
		int halfScreenHeight = Screen.height / 2;
		
		GUI.Label(new Rect(halfScreenWidth - (pointLabelWidth / 2), topSeparation - (pointLabelWidth / 2), pointLabelWidth, pointLabelHeight), GameStateScript.hops.ToString());
	}
}
