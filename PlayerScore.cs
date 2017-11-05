using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int Coins = 0;

    void OnTriggerEnter (Collider Cinfo)
    {
        if (Cinfo.tag == "MG")
        {
            Coins = Coins + 1;
        }
    }

}