using UnityEngine;

public  class CollectPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider info)
    {
        if (info.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
