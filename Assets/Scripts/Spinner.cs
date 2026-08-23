using System;
using System.Xml.Schema;
using Unity.VisualScripting;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle;
    [SerializeField] float yAngle;
    [SerializeField] float zAngle;

    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
