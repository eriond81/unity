using UnityEngine;
using System.Collections;

public class LevelCreator : MonoBehaviour {
	
	public GameObject CorridorPrefab;	
	public Vector3 initPoint;
	
	private Transform ThisTransform;
	
	private int numberOfElements = 10;
	private ArrayList corridorList = new ArrayList();
	private int incremental;
	private int index = 0;
	private float offset = 2.0f;
	// Use this for initialization
	void Start () {
		ThisTransform = transform;
		// create the first n parts of the level
		for(int i=0;i<numberOfElements;i++){
			GameObject corridor = (GameObject)GameObject.Instantiate(CorridorPrefab);
			Vector3 pos = corridor.transform.position;
			pos.x = initPoint.x;
			pos.y = initPoint.y;
			pos.z = initPoint.z + (2 * i);
			corridor.transform.position = pos; 
			corridorList.Add(corridor);
		}
		
		incremental = numberOfElements;
	}
	
	// Update is called once per frame
	void Update () {
		float zShip = ThisTransform.position.z-offset;
		float zLevel = ((GameObject)corridorList[index]).transform.position.z;
		if(zShip>zLevel){
			// mover el nivel fuera de la vista y ponerlo a continuacion
			GameObject cor = ((GameObject)corridorList[index]);
			Vector3 pos = cor.transform.position;
			pos.z = initPoint.z + (2 * incremental);
			cor.transform.position = pos;
			incremental++;
			
			// crea un obstaculo aleatorio
			RandomObstacle robs = (RandomObstacle)cor.GetComponent("RandomObstacle");
			robs.randomObstacle();
			
			if(index==5){ 
				index = 0;
			}else{
				index++;
			}
		}
	}
}
