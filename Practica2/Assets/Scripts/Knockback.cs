using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{

    public float knockbackForce;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Adds a impulse negative in funcion of own velocity
    /// </summary>
    public void PlayKnockback()
    {
        Vector2 dirKnockback = new Vector2(-rb.velocity.x, 1f);
        rb.velocity = Vector2.zero;
        rb.AddForce(dirKnockback.normalized * knockbackForce, ForceMode2D.Impulse);
    }
}
