using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        BlockBulletConstrains();
        rb.velocity = transform.right * speed;
    }

    /// <summary>
    /// Blocks forces in Y of the bullet
    /// </summary>
    private void BlockBulletConstrains()
    {
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
    }
}
