using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed = 10.0f;
    private float xRange = 10;
    private Rigidbody playerRB;
    public float jumpForce = 80000;
    public bool isOnGround = true;
    public float enemySpeed = 50;
    public GameObject plane;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
        //playerRB.AddForce(Vector3.up * verticalInput * jumpForce, ForceMode.Impulse);
        if(isOnGround && verticalInput > 0){
            playerRB.AddForce(Vector3.up * verticalInput * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision){    
        if(collision.gameObject){
            isOnGround = true;
        }
    }
}
