using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerMovement : MonoBehaviour
{
    private int speed;
    private int explosion;
    public Rigidbody playerRb;

    private void Start()
    {
        speed = GameManager.Instance.moveSpeed;
        explosion = GameManager.Instance.explosionPower;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal Red");
        float inputZ = Input.GetAxis("Vertical Red");

        transform.Translate(new Vector3 (speed * inputX * Time.deltaTime, 0, speed * inputZ * Time.deltaTime));

        if(Input.GetKey(KeyCode.Space) && playerRb.transform.position.y <= 2 && playerRb.transform.position.y > 0 ) 
        {
            playerRb.AddForce(explosion * inputX, explosion, explosion * inputZ, ForceMode.Impulse);
        }
    }
}
