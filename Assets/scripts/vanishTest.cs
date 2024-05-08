using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanishTest : MonoBehaviour
{
    public Rigidbody rb;
    //private Vector3 scaleChange;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        //if statment check wether the other game objects name is enemy
        if (collision.gameObject.name == "point")
        {

            Destroy(collision.gameObject);

            
         //Final one
            rb.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

        //    Debug.Log("scale is: " + rb.transform.localScale);


          
        }
    }
}

// rb.gameObject.transform.localScale

//scaleChange = new Vector3(0.01f, 0.01f, 0.01f);


// Vector3 scaleChange = new Vector3(rb.transform.localScale.x + 1f, rb.transform.localScale.y + 1f, rb.transform.localScale.z + 1f);
// rb.transform.localScale += scaleChange;




//rb.transform.localScale(scaleChange);

// Debug.Log("scale is: " + rb.transform.localScale.x );