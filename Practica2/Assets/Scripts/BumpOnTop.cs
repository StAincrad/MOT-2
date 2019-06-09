using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpOnTop : MonoBehaviour
{
    public int points;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Vector2.Angle(transform.right, collision.GetContact(0).normal).Equals(90f) && collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Knockback>().PlayKnockback(new Vector2(-rb.velocity.x, collision.GetContact(0).normalImpulse));
            GameManager.instance.AddPoints(points);
            Destroy(gameObject);
        }
    }
}
