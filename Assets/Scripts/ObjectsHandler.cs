using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectsHandler
{

    public Transform m_container;
    public List<ManipulableObject> m_objects;
    public static List<ManipulableObject> m_static_objects;
    private ManipulableObject m_currentMO;
    public void Init()
    {
        m_objects.AddRange(m_container.GetComponentsInChildren<ManipulableObject>());
        m_objects.ForEach(manipulableObject =>
        {
            m_currentMO = manipulableObject;
            manipulableObject.m_currentPos = manipulableObject.transform.position;
            manipulableObject.m_availablePos.AddRange(m_objects.FindAll(FindeManipulableObj));
        });
        // m_currentMO = null;

        m_static_objects = m_objects;
    }

    private bool FindeManipulableObj(ManipulableObject m_obj)
    {
        if (m_obj.name != m_currentMO.name)
        {
            if (m_obj.m_type == m_currentMO.m_type)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}