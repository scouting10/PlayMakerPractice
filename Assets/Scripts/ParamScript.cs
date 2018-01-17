using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamScript : MonoBehaviour {

	public GUIStyle GUIStyle;
	public Rect _position1;
	public Rect _position2;
	public Rect _position3;
	public Rect _position4;


	void OnGUI()
	{
		GUI.Label(_position1,"Score：" + GameManager._instance._currentScore,GUIStyle);
	}
}
