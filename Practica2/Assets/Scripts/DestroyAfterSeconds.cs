using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    public float secods;
    private void Start()
    {
        Destroy(gameObject,secods);
    }
}
