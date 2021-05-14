using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2DNormal : MonoBehaviour
{
    public float MovementSpeed = 5f;
    public float JumpForce = 3f;

    private Rigidbody2D rb;

    public bool JumpingON = true;
    public KeyCode jumpButton;

    private void Start()
    {
        //get rigidbody
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        //move
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        //Jumping
        if(JumpingON == true)
        {
            if (Input.GetKeyDown(jumpButton) && Mathf.Abs(rb.velocity.y) < 0.001f)
            {
                rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
        }
    }
}
