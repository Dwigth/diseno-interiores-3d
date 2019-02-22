using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCreator : MonoBehaviour {
	
	public float largo, ancho;
	GameObject plane;
	// Use this for initialization
	void Start () {
		plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
		plane.transform.position = new Vector3(0,0,0);
		plane.transform.localScale = new Vector3(largo,1f,ancho);
		plane.name = "Piso";
		MeshCut.Cut(plane,plane.transform.position,Vector3.down,plane.GetComponent<MeshRenderer>().material);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
