using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public int ButtonWeight = 200;
	public int ButtonHeight = 70;
	
	public Vector2 Position1;
	public Vector2 Position2;
	
	public Font font;
	
	public Texture2D background;
	
	private GUIStyle guiStyle;
	
	// Use this for initialization
	void Start () {
		guiStyle = new GUIStyle();
		guiStyle.font = font;
		guiStyle.fontSize = 50;
		guiStyle.normal.textColor = Color.white;
		guiStyle.alignment = TextAnchor.MiddleCenter;
		guiStyle.normal.background = background;
	}
	
	
	void OnGUI () {		
		// compatibility with another screen resolutions
		GUIUtility.ScaleAroundPivot(new Vector2(1,1)*Screen.height/768f,Vector2.zero);
		
		if (GUI.Button (new Rect (Position1.x, Position1.y, ButtonWeight, ButtonHeight), "Start",guiStyle)) {
			Application.LoadLevel (0);
		}
		
		if (GUI.Button (new Rect (Position2.x, Position2.y, ButtonWeight, ButtonHeight), "Quit", guiStyle)) {
			Application.Quit();
		}
	
	}
}
