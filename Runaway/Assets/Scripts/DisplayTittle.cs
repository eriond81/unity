using UnityEngine;
using System.Collections;

public class DisplayTittle : MonoBehaviour {
	
	public Texture TittleTexture;
	
	public Vector2 Position;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI() {
		
		// compatibility with another screen resolutions
		GUIUtility.ScaleAroundPivot(new Vector2(1,1)*Screen.height/768f,Vector2.zero);
		
		// draw backbround
		GUI.DrawTexture(new Rect(Position.x,Position.y,TittleTexture.width,TittleTexture.height),TittleTexture);
	
	}
}
