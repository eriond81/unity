using UnityEngine;
using System.Collections;
using System;

public class DistanceCounter : MonoBehaviour {
	
	public GameObject reference;
	
	private String referenceText;
	
	public float initZ;
	public float currentZ;
	
	// Use this for initialization
	void Start () {
		referenceText = GetComponent<GUIText>().text;
		initZ = reference.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		currentZ = reference.transform.position.z;
		GetComponent<GUIText>().text = referenceText + String.Format("{0:0.00}",(currentZ-initZ)) + "m";
	}
}
