using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] float Speed;
    Vector3 PlayerPositon;

    private void Awake() 
    {
        gameObject.SetActive(false);    
    }

    void Start()
    {
         PlayerPositon = Player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position,PlayerPositon,Speed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if(transform.position == PlayerPositon)
        {
            Destroy(gameObject);
        }
        
    }
}
