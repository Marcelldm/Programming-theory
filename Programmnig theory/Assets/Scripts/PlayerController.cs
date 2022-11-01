using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private int horizontalbound = 14;
    [SerializeField] private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (transform.position.x < -horizontalbound)
        {
            transform.position = new Vector3(-horizontalbound, transform.position.y, transform.position.z);
        }

        if (transform.position.x > horizontalbound)
        {
            transform.position = new Vector3(horizontalbound, transform.position.y, transform.position.z);
        }
    }
}
