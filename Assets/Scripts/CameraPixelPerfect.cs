using UnityEngine;
using System.Collections;

/// <summary>
/// Script in charge of configuring the view to get the right aspect ratio, resolution
/// and pixels per unit.
/// </summary>
public class CameraPixelPerfect : MonoBehaviour {
	
	public Vector2 screenResolution;
	public float pixelsToUnits;
	
	void Update () 
	{
		if(screenResolution.y <= 0)
		{
			Debug.LogError("The specified screen resolution(" + screenResolution + ") is unsupported.");
			Camera.main.orthographicSize = Screen.height / 2f;
		}
		else Camera.main.orthographicSize = screenResolution.y / 2f * (1/pixelsToUnits);
	}
}