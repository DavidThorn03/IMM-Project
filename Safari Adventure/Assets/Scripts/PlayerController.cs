using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 10.0f;
    private float xRange = 10;
    private Rigidbody playerRB;
    private float jumpForce = 600;
    public bool isOnGround = true;
    public float enemySpeed = 50;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }


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
        
        if(isOnGround && Input.GetKeyDown(KeyCode.UpArrow)){
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision){    
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;
        }
        else if(collision.gameObject.CompareTag("Enemy")){
            Debug.Log("GameOver");
        }
    }
}
