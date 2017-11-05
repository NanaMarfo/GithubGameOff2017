using UnityEngine;

public class PlayerMoveandJump : MonoBehaviour {


    public Rigidbody rb;
    public float speed = 100f;
    public float speedplus = 200f;
    public float jump = 10f;
    public bool IsJumping = false;
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("right")){

            rb.AddForce(speed, 0, 0 * Time.deltaTime);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-speed, 0, 0 * Time.deltaTime);
        }
        if (Input.GetKeyDown("space") && (IsJumping == false))
        {
            rb.AddForce(0, jump, 0 * Time.deltaTime);
            Debug.Log("Jump!");
            IsJumping = true;
        }
	}
    private void OnCollisionStay()
    {
        IsJumping = false; 
    }
}
