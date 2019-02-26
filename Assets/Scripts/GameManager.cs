using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public ObjectsHandler m_ObjectsHandler;

	// Use this for initialization
	void Start () {
		m_ObjectsHandler.Init();
	}

	// Update is called once per frame
	void Update () {

	}
}
