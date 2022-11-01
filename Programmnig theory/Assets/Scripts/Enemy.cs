using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    public float speed;
    private Vector3 lookDirection;
    private Rigidbody enemyRb;
    public PlayerController playerScript;
    void Start()
    {
        player = GameObject.Find("Player");
        enemyRb = GetComponent<Rigidbody>();
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public virtual void Move()
    {

            lookDirection = (player.transform.position - transform.position).normalized;
            if (transform.position.y > player.transform.position.y)
            {
                enemyRb.AddForce(lookDirection * speed, ForceMode.Impulse);
            }

            if (transform.position.y < -10)
            {
                Destroy(gameObject);
            }

            transform.Translate(Vector3.forward * Time.deltaTime * 2);
        
    }
}
