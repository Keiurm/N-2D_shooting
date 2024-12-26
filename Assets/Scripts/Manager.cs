using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject player;

    public GameObject title;

    void Update()
    {
        if (IsPlaying() == false && Input.GetKeyDown(KeyCode.X))
        {
            GameStart();
        }
    }

    void GameStart()
    {
        title.SetActive(false);
        GameObject playerObject = Instantiate(player,
        player.transform.position,
        player.transform.rotation);
        playerObject.GetComponent<PlayerController>().manager = gameObject.transform.GetComponent<Manager>();

    }

    public void GameOver()
    {
        title.SetActive(true);
    }

    public bool IsPlaying()
    {
        return title.activeSelf == false;
    }
}
