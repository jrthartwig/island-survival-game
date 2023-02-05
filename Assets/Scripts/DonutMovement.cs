using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutMovement : MonoBehaviour
{
    Rigidbody donut;
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        donut = GetComponent<Rigidbody>();
        moveSpeed = 30f;
        jumpSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        var xSpeed = xInput * moveSpeed;
        var zSpeed = zInput * moveSpeed;

        donut.velocity = new Vector3(xSpeed == 0 ? donut.velocity.x : xSpeed, donut.velocity.y, zSpeed == 0 ? donut.velocity.z : zSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            donut.velocity = new Vector3(donut.velocity.x, jumpSpeed, donut.velocity.z);
        }
    }
}
