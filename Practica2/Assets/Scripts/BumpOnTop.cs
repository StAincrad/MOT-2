using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpOnTop : MonoBehaviour
{
    public int points;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.DrawLine(collision.GetContact(0).point, transform.localPosition, Color.red,1f);

        if (collision.GetContact(0).normal == Vector2.down)
        {
            GameManager.instance.AddPoints(points);
            collision.collider.GetComponent<Knockback>().PlayKnockback();
            Destroy(gameObject);
        }

    }


}
