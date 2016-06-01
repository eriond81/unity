using UnityEngine;
using System.Collections;

public class RandomObstacle : MonoBehaviour {

	
	private int currentObstacle = 0;
	
	private GameObject cube1;
	private GameObject cube2;
	private GameObject cube3;
	private GameObject cube4;
	private GameObject cube5;
	private GameObject cube6;
	private GameObject cube7;
	private GameObject cube8;
	private GameObject cube9;
	
	private MeshRenderer mesh;
	private BoxCollider collider;	
	
	private bool isTriggerValue = false;
	
	// Use this for initialization
	void Start () {
		for(int i=0;i<transform.GetChildCount();i++){
			GameObject child = (GameObject) transform.GetChild(i).gameObject;
			if(child.name.Equals("Cube1")) cube1 = child;
			if(child.name.Equals("Cube2")) cube2 = child;
			if(child.name.Equals("Cube3")) cube3 = child;
			if(child.name.Equals("Cube4")) cube4 = child;
			if(child.name.Equals("Cube5")) cube5 = child;
			if(child.name.Equals("Cube6")) cube6 = child;
			if(child.name.Equals("Cube7")) cube7 = child;
			if(child.name.Equals("Cube8")) cube8 = child;
			if(child.name.Equals("Cube9")) cube9 = child;			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void randomObstacle(){
		hideObstacle(currentObstacle);
		currentObstacle = Random.Range(0,10);
		showObstacle(currentObstacle);
	}
	
	private void hideObstacle(int obsNumber){
		if(obsNumber==0) return;
		switch(obsNumber)
			{
				case 1:					
					mesh = (MeshRenderer)cube1.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube1.GetComponent("BoxCollider");
					mesh.enabled = false;
					collider.enabled = false;			
				break;
				case 2:					
					mesh = (MeshRenderer)cube2.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube2.GetComponent("BoxCollider");
					mesh.enabled = false;
					collider.enabled = false;							
				break;
				case 3:					
					mesh = (MeshRenderer)cube3.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube3.GetComponent("BoxCollider");
					mesh.enabled = false;
					collider.enabled = false;			
				break;
				case 4:
					mesh = (MeshRenderer)cube4.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube4.GetComponent("BoxCollider");
					mesh.enabled = false;
					collider.enabled = false;			
				break;
				case 5:
					mesh = (MeshRenderer)cube5.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube6.GetComponent("BoxCollider");
					mesh.enabled = false;
					collider.enabled = false;			
				break;
				case 6:					
					mesh = (MeshRenderer)cube6.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube6.GetComponent("BoxCollider");
					mesh.enabled = false;
					collider.enabled = false;			
				break;
				case 7:					
					mesh = (MeshRenderer)cube7.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube7.GetComponent("BoxCollider");
					mesh.enabled = false;
					collider.enabled = false;							
				break;
				case 8:					
					mesh = (MeshRenderer)cube8.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube8.GetComponent("BoxCollider");
					mesh.enabled = false;
					collider.enabled = false;			
				break;
				case 9:
					mesh = (MeshRenderer)cube9.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube9.GetComponent("BoxCollider");
					mesh.enabled = false;
					collider.enabled = false;			
				break;
				default:
					break;
			}		
	}
	
	private void showObstacle(int obsNumber){
		if(obsNumber==0) return;
		switch(obsNumber)
			{
				case 1:					
					mesh = (MeshRenderer)cube1.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube1.GetComponent("BoxCollider");
					mesh.enabled = true;
					collider.enabled = true;
					collider.isTrigger = isTriggerValue;
				break;
				case 2:					
					mesh = (MeshRenderer)cube2.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube2.GetComponent("BoxCollider");
					mesh.enabled = true;
					collider.enabled = true;							
					collider.isTrigger = isTriggerValue;
				break;
				case 3:					
					mesh = (MeshRenderer)cube3.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube3.GetComponent("BoxCollider");
					mesh.enabled = true;
					collider.enabled = true;
					collider.isTrigger = isTriggerValue;
				break;
				case 4:
					mesh = (MeshRenderer)cube4.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube4.GetComponent("BoxCollider");
					mesh.enabled = true;
					collider.enabled = true;			
					collider.isTrigger = isTriggerValue;
				break;
				case 5:
					mesh = (MeshRenderer)cube5.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube6.GetComponent("BoxCollider");
					mesh.enabled = true;
					collider.enabled = true;
					collider.isTrigger = isTriggerValue;
				break;
				case 6:					
					mesh = (MeshRenderer)cube6.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube6.GetComponent("BoxCollider");
					mesh.enabled = true;
					collider.enabled = true;			
					collider.isTrigger = isTriggerValue;
				break;
				case 7:					
					mesh = (MeshRenderer)cube7.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube7.GetComponent("BoxCollider");
					mesh.enabled = true;
					collider.enabled = true;
					collider.isTrigger = isTriggerValue;
				break;
				case 8:					
					mesh = (MeshRenderer)cube8.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube8.GetComponent("BoxCollider");
					mesh.enabled = true;
					collider.enabled = true;
					collider.isTrigger = isTriggerValue;
				break;
				case 9:
					mesh = (MeshRenderer)cube9.GetComponent("MeshRenderer");
					collider = (BoxCollider)cube9.GetComponent("BoxCollider");
					mesh.enabled = true;
					collider.enabled = true;
					collider.isTrigger = isTriggerValue;
				break;
				default:
					break;
			}
	}
	
	
}
