using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 2.0f;
    

    void Start()
    {
        Debug.Log("Use 'W' 'A' 'S' 'D' To Move Player");
        Debug.Log("Task :- Try Not To Hit Obstical");
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed ;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;

        transform.Translate(xValue,yValue,zValue);
    }

}