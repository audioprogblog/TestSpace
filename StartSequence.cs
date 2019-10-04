using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSequence : MonoBehaviour
{
    public float playerY, playerYStart;
    public GameObject player;
    public bool hasStarted;
    public string firstEvent;

    void Start()
    {
        hasStarted = false;
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        //Track Y value of headset
        if (hasStarted == false)
        {
            playerY = player.transform.position.y;
        }

        //If Y value < half of it's initial value game will progress
        if (playerY <= (playerYStart / 2) && hasStarted == false)
        {
            AkSoundEngine.PostEvent(firstEvent, gameObject);
            hasStarted = true;
        }
    }
}
