using UnityEngine;
using System.Collections;

public class GameOverGUI : MonoBehaviour {
	
	public Texture GameOverTexture;	
	public Vector2 GameOverPosition;
	
	public int ButtonWeight = 200;
	public int ButtonHeight = 70;
	public Vector2 Button1Position;
	public Vector2 Button2Position;
	public Font ButtonFont;
	public Texture2D ButtonBackground;
	
	private GUIStyle guiStyle;
	
	// Use this for initialization
	void Start () {
		guiStyle = new GUIStyle();
		guiStyle.font = ButtonFont;
		guiStyle.fontSize = 50;
		guiStyle.normal.textColor = Color.white;
		guiStyle.alignment = TextAnchor.MiddleCenter;
		guiStyle.normal.background = ButtonBackground;
	}
	
	// Update is called once per frame
	void OnGUI () {
	
		// compatibility with another screen resolutions
		GUIUtility.ScaleAroundPivot(new Vector2(1,1)*Screen.height/768f,Vector2.zero);
		
		// draw backbround
		GUI.DrawTexture(new Rect(GameOverPosition.x,GameOverPosition.y,GameOverTexture.width,GameOverTexture.height),GameOverTexture);
			
		if (GUI.Button (new Rect (Button1Position.x, Button1Position.y, ButtonWeight, ButtonHeight), "Replay",guiStyle)) {
			Application.LoadLevel (0);
		}
		
		if (GUI.Button (new Rect (Button2Position.x, Button2Position.y, ButtonWeight, ButtonHeight), "Main Menu", guiStyle)) {
			Application.LoadLevel (2);
		}
	}
}
