using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform m_container;
    public List<Transform> m_places;
    public bool m_placing = false;
    public Transform m_currentTarget;
    public Transform m_lastTarget;
    void Start()
    {
        m_container = GameObject.Find("container").GetComponent<Transform>();
        m_places.AddRange(m_container.GetComponentsInChildren<Transform>());
        m_places.Remove(m_places[0]);
        showPlacer(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Take();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            showPlacer(false);
            m_currentTarget = null;
        }
    }

    void Take()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.transform.tag == "Target" || hit.transform.tag == "Placer")
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                Debug.Log(hit.transform.name);
                m_lastTarget = m_currentTarget;
                m_currentTarget = hit.transform;
                m_placing = true;
                showPlacer(true);
                if (hit.transform.tag == "Placer")
                {
                    m_lastTarget.position = m_currentTarget.position;
                    m_currentTarget = m_lastTarget;
                    // m_lastTarget = null;
                    hit.transform.gameObject.SetActive(false);

                }
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.red);
            Debug.Log("Did not Hit");
        }
    }

    void showPlacer(bool cond)
    {
        foreach (var place in m_places)
        {
            place.gameObject.SetActive(cond);
        }
    }

}
