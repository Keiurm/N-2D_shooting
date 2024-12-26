using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public int speed = 10;

    public float lifeTime = 5;

    public int power = 1;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;

        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
