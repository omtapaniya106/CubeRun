using Unity.VisualScripting;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject Projectile1;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Projectile1.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
