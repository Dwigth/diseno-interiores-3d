using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulableObject : MonoBehaviour
{
    public Tipos.Types m_type;
    public Vector3 m_currentPos;
    public Vector3 m_lastPost;
    public List<ManipulableObject> m_availablePos;
    public bool m_onEditing = false;
    public bool m_show;
    void Start()
    {
        transform.gameObject.SetActive(m_show);
    }

    public void Show(bool show)
    {
        m_show = show;
        transform.gameObject.SetActive(show);
    }

    public void ShowAvailablePos()
    {
        m_availablePos.ForEach(avPos =>
        {
            avPos.Show(true);
        });
    }
    void OnMouseDown()
    {
        Debug.Log(transform.name);
        ShowAvailablePos();
    }
}