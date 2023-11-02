using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private PlayerController smScript;
    

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player");
        smScript = GameObject.Find("Spawn Manager").GetComponent<PlayerController>();
        speed = smScript.enemySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either buffalo, destroy it
        if (other.gameObject.name == "Enemy")
        {
            Destroy(gameObject);
        } 


    }

}
