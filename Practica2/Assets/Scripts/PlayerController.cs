using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float jumpForce, speed;
    private Rigidbody2D rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update ()
    {
        if (Input.GetKey(KeyCode.Space) && Mathf.Abs(rb.velocity.y) <= 0.0f)
        {
            MakeJump();
        }
        if (Input.GetKey(KeyCode.A))
        {
            GoLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            GoRight();
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) && Mathf.Abs(rb.velocity.y) <= 0.0f)
        {
            StopVelocity();
        }
            
	}

    /// <summary>
    /// It do player jump
    /// </summary>
    private void MakeJump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    /// <summary>
    /// It do player going to the left
    /// </summary>
    private void GoLeft()
    {
        rb.AddForce(Vector2.left * speed, ForceMode2D.Force);
    }

    /// <summary>
    /// It do player going to the right
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
        rb.velocity = new Vector2(0f, rb.velocity.y);
    }
}
