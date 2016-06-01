using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour {
	
	// Speed for the movement, initial value is 1
	public float Speed = 1.0f;	
	
	public GameObject objective;
	
	private Transform ThisTransform;	
	private Transform ObjectiveTransform;
	
	public double zDistance = 0;
	
	public double tDistance;
	
	private Vector3 Direction; 
	
	// Use this for initialization
	void Start () {
		ThisTransform = transform;
		ObjectiveTransform = objective.transform;		
		zDistance = ObjectiveTransform.position.z - ThisTransform.position.z; 
		Direction = ThisTransform.forward;		
	}
	
	// Update is called once per frame
	void Update () {
		tDistance = ObjectiveTransform.position.z - ThisTransform.position.z;
		if(tDistance>zDistance){
			ThisTransform.Translate(Direction * Speed *	Time.deltaTime);
		}
	}
}
