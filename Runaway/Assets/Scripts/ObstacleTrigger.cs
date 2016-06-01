using UnityEngine;
using System.Collections;

public class ObstacleTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter(Collision c){
		Debug.Log("Collision detected");	
		Application.LoadLevel(1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
