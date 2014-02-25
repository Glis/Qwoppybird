using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour
{
	public GUISkin gameSkin;

	void OnGUI(){
		GUI.skin = gameSkin;

		//General
		int halfScreenWidth = Screen.width / 2;
		int halfScreenHeight = Screen.height / 2;
		//ScoreLabel
		int scoreTopSeparation = Screen.height * 10 / 100;
		int scoreLabelWidthSingle = 30;
		int scoreLabelWidthDouble = 0;
		int scoreLabelHeight = 30;
		//Instructions
		int instructionLabelTopSep = Screen.height * 88 / 100;
		int flapLabelLeftSep = Screen.height * 10 / 100;
		int flopLabelLeftSep = Screen.height * 90 / 100;
		int instructionLabelWidth = 150;
		int instructionLabelHeight = 35;
		//Retry instructions;
		int retryInstructionLabelWidth = 180;

//-------------Show--------------
		//Score Label
		if(GameStateScript.hops < 10){
			GUI.Label(new Rect(halfScreenWidth - (scoreLabelWidthSingle / 2), scoreTopSeparation - (scoreLabelHeight / 2), scoreLabelWidthSingle, scoreLabelHeight), GameStateScript.hops.ToString(), "box");
		} else{
			GUI.Label(new Rect(halfScreenWidth - (scoreLabelWidthDouble / 2), scoreTopSeparation - (scoreLabelHeight / 2), scoreLabelWidthDouble, scoreLabelHeight), GameStateScript.hops.ToString(), "box");
		}
		if(!GameStateScript.gameOver){
			//Flap&Flop Instructions
			GUI.Label(new Rect(flapLabelLeftSep, instructionLabelTopSep, instructionLabelWidth, instructionLabelHeight), "\"Q\" to Flap", "box");
			GUI.Label(new Rect(flopLabelLeftSep, instructionLabelTopSep, instructionLabelWidth, instructionLabelHeight), "\"W\" to Flop", "box");
		} else{
			//Retry instructions
			GUI.Label(new Rect(halfScreenWidth - (retryInstructionLabelWidth / 2), instructionLabelTopSep, retryInstructionLabelWidth, instructionLabelHeight), "\"R\" to Flap again!", "box");
		}

	}
}
