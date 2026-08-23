using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    int Hits = -1;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {
            Hits++;
            Debug.Log("Hit :- " + Hits);   
        }
            
    }
}
