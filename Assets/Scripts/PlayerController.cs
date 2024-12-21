
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CommonSpaceship spaceship;



    IEnumerator Start()
    {
        spaceship = GetComponent<CommonSpaceship>();
        while (true)
        {
            spaceship.Shot(transform);
            yield return new WaitForSeconds(spaceship.shotDelay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(x, y).normalized;

        spaceship.Move(direction);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        Destroy(c.gameObject);

        spaceship.Explosion();

        Destroy(gameObject);
    }
}
