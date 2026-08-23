using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeToWait;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigitBody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;

        myRigitBody = GetComponent<Rigidbody>();
        myRigitBody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigitBody.useGravity = true;
        }
    }
}
