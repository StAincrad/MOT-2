using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BumpOnTop : MonoBehaviour
{
    public int points;

    /// <summary>
    /// Check if the direction of collision is
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.DrawLine(collision.GetContact(0).point, transform.localPosition, Color.red,1f);

        if (collision.GetContact(0).normal == -(Vector2)transform.up)
        {
            GameManager.instance.AddPoints(points);
            collision.gameObject.GetComponent<Knockback>().PlayKnockback();
            Destroy(gameObject);
        }

    }


}
