using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    CommonSpaceship spaceship;

    IEnumerator Start()
    {
        spaceship = GetComponent<CommonSpaceship>();
        spaceship.Move(transform.up * -1);

        while (true)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Transform shotPosition = transform.GetChild(i);
                spaceship.Shot(shotPosition);
            }
            yield return new WaitForSeconds(spaceship.shotDelay);
        }
    }

    void Update()
    {

    }
}
