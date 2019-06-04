using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpOnTop : MonoBehaviour
{
    public int points;
    private Rigidbody2D rb;
    Vector2 dirKnockback;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.DrawLine(collision.GetContact(0).point, transform.localPosition, Color.red,1f);

        if (collision.GetContact(0).normal == -(Vector2)transform.up)
        {
            GameManager.instance.AddPoints(points);

            dirKnockback = new Vector2(-rb.velocity.x, 1f);
            collision.gameObject.GetComponent<Knockback>().PlayKnockback(dirKnockback);

            Destroy(gameObject);
        }

    }


}
