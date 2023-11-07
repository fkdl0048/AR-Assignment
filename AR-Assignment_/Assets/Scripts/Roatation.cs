using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roatation : MonoBehaviour
{
    public GameObject obj;
    public Vector3 rotation;
    
    void Update()
    {
        obj.transform.Rotate(rotation * Time.deltaTime);
    }
}
