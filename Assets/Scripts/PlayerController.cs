using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Name: Matthew Borrelli
/// Last Updated: 10/31/24 
/// Purpose: Controlling the player character
/// </summary>


public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10;

    private Vector3 moveDir;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            moveDir = Vector3.left;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDir = Vector3.right;
            rb.MovePosition(transform.position + moveDir * moveSpeed * Time.deltaTime);
        }
    }
}
