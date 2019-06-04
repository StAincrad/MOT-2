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
    /// Adds a negative impulse in function of the lineal velocity
    /// </summary>
    /// <param name="dir"> 
    /// Direction of the knockback
    /// </param>
    public void PlayKnockback(Vector2 dir)
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(dir.normalized * knockbackForce, ForceMode2D.Impulse);
    }
}
