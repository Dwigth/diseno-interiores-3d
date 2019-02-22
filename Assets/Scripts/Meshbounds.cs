using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meshbounds : MonoBehaviour {

	// Use this for initialization
	public Material[] m_materials;
	 void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.materials = m_materials;
        Vector3[] vertices = mesh.vertices;
        Vector2[] uvs = new Vector2[vertices.Length];
        Bounds bounds = mesh.bounds;
        int i = 0;
        while (i < uvs.Length)
        {
            uvs[i] = new Vector2(vertices[i].x / bounds.size.x, vertices[i].z / bounds.size.x);
            i++;
        }
        mesh.uv = uvs;
        
        Debug.Log(vertices);
        Debug.Log(uvs);
        Debug.Log(mesh.bounds);
    }
	
	// Update is called once per frame
	void Update () { }
}