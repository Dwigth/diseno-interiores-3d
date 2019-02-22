using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class ProceduralMesh : MonoBehaviour {
	
	
	Mesh mesh;
	Vector3[] vertices;
	int[] triangles;
	void Awake() {
		mesh = GetComponent<MeshFilter>().mesh;
	}
	
	// Use this for initialization
	void Start () {
		MakeMeshData();
		CreateMesh();
	}
	
	// Update is called once per frame
	void MakeMeshData () {
		
		//crear un arreglo de vertices
		vertices = new Vector3[]{ new Vector3(0,0,0), new Vector3(0,0,1), new Vector3(1,0,0),new Vector3(1,0,1) };
		//crear un arreglo de enteros
		triangles = new int[] { 0,1,2,2,1,3 };
	}
	
	void CreateMesh(){
		mesh.Clear();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
		mesh.RecalculateNormals();
	}
}
