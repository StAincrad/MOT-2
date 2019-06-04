using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject BulletInstance;
    public float BulletsPerSecond;
    private Transform bulletPool;

	void Start ()
    {
        bulletPool = GameObject.Find("BulletPool").transform;
        InvokeRepeating("ShootBullet", 0.5f, BulletsPerSecond);
	}

    /// <summary>
    /// Create a bullet in canon position
    /// </summary>
    private void ShootBullet()
    {
        Instantiate(BulletInstance,transform.position, Quaternion.Euler(transform.eulerAngles), bulletPool);
    }
}
