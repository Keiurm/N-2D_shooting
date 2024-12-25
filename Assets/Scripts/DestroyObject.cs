using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D c)
    {
        if (c.gameObject.tag == "Enemy")
        {
            Destroy(c.gameObject);
            Destroy(gameObject);
        }
        else if (c.gameObject.tag == "PlayerBullet")
        {
            Destroy(c.gameObject);
        }
    }
}
