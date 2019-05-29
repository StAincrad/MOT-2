using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public KeyCode left, right, jump;
    public float jumpForce, speed, speedLimit;
    private Rigidbody2D rb;
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update ()
    {
        if (Input.GetKeyDown(jump) && rb.velocity.y == 0.0f)
        {
            MakeJump();
        }
        if (Input.GetKey(left) && Mathf.Abs(rb.velocity.x) <= speedLimit)
        {
            GoLeft();
        }
        if (Input.GetKey(right) && Mathf.Abs(rb.velocity.x) <= speedLimit)
        {
            GoRight();
        }
        if (Input.GetKeyUp(left) || Input.GetKeyUp(right) && rb.velocity.y <= 0.0f)
        {
            StopVelocity();
        }
            
	}

    /// <summary>
    /// Make player jump
    /// </summary>
    private void MakeJump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    /// <summary>
    /// Make player go to the left
    /// </summary>
    private void GoLeft()
    {
        rb.AddForce(Vector2.left * speed, ForceMode2D.Force);
    }

    /// <summary>
    /// Make player go to the right
    /// </summary>
    private void GoRight()
    {
        rb.AddForce(Vector2.right * speed, ForceMode2D.Force);
    }

    /// <summary>
    /// Stop movement of the player
    /// </summary>
    private void StopVelocity()
    {
        rb.velocity = new Vector2(0.0f, rb.velocity.y);
    }
}
