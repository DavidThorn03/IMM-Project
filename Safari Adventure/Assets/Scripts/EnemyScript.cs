using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    
    private Rigidbody enemyRb;
    public GameObject player;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either buffalo, destroy it
        if (other.gameObject.name == "Player")
        {

        } 
    }

}
