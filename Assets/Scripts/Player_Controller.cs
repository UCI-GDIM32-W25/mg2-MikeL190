using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private UI_Manager myUIManagerScript;

    public int jumpForce = 5;
    private Rigidbody2D myRigidbody;
    private bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            myRigidbody.velocity = Vector2.up * jumpForce;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //string otherObjectName = collision.gameObject.name;
        //Debug.Log("Collided ENTER with " + otherObjectName);
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //string otherObjectName = collision.gameObject.name;
        //Debug.Log("Collided EXIT with " + otherObjectName);
        isGrounded = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        myUIManagerScript.UpdateText();
        Destroy(other.gameObject);

    }


}
