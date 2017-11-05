using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float SmoothSpeed = 0.5f;
    public Vector3 offset;

   void FixedUpdate()
    {
        Vector3 ChosenPosition = player.position + offset;
        Vector3 SmoothedPosition = Vector3.Lerp (transform.position, ChosenPosition, SmoothSpeed);
        transform.position = SmoothedPosition;

        transform.LookAt(player);
    }
}