
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;
    public int nitrous = 100;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (nitrous > 0)
        {
            if (Input.GetKey("left shift"))
            {
                rb.AddForce(0, 0, (forwardForce + 1000f) * Time.deltaTime);
                nitrous--;
               // Debug.Log(nitrous);
            }
        }

        if(rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
