using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public int deaths = 0;
    public Text deathText;

    void Start()
    {
        deathText.text = "Deaths: " + deaths;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position = respawnPoint.transform.position;
        deaths += 1;
        deathText.text = "Deaths: " + deaths;
    }
}
