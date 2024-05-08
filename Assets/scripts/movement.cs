using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    float rotationSpeed = 3f;
    float jumpAmount = 3f;
    bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(horizontal, jump, vertical);

        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
           //rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
           // Vector3 jummpp = new Vector3(horizontal, jump, vertical);
            // rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            isGrounded = false;
            // Set isGrounded to false as the player is now in the air
        }
        isGrounded = true;




        //Vector3 direction = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        // rb.MoveRotation(Quaternion.LookRotation(direction));

        //  transform.Rotate(Vector3.up * horizontal * speed * Time.deltaTime);

        //transform.Rotate(Vector3.up * rotationSpeed*Time.deltaTime);

        //rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);


    }
}
