using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {
	
	// Speed for the movement, initial value is 1
	public float Speed = 1.0f;	
	
	private Vector3 Direction; 
	
	private Transform ThisTransform;
	
	// Use this for initialization
	void Start () {
		ThisTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {		
		// always is moving fordward
		ThisTransform.Translate(ThisTransform.forward * Speed *	Time.deltaTime);	
		
		// evade movement
		if(Input.GetKey(UnityEngine.KeyCode.D)){
			if(transform.position.x<0.6){
				CalculateRightDirection();			
				ThisTransform.Translate(Direction * Speed *	Time.deltaTime);			
			}
		}else if(Input.GetKey(UnityEngine.KeyCode.A)){			
			if(transform.position.x>-0.6){
				CalculateLeftDirection();			
				ThisTransform.Translate(Direction * Speed *	Time.deltaTime);			
			}				
		}
	
	}	
	
	private void CalculateRightDirection()
	{		
		Direction = -1 * Vector3.Cross(ThisTransform.forward,ThisTransform.up);		
	}
	
	private void CalculateLeftDirection()		
	{
		Direction = Vector3.Cross(ThisTransform.forward,ThisTransform.up);	
	}
	
}
