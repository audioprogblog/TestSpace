using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTriggerRandomLocation : MonoBehaviour
{
    //List of GameObjects representing each speaker
    public List<GameObject> locations;
    public GameObject locationEmitter, player;
    public string wwiseEvent;

    void Start()
    {
        //Define player, add GameObjects to list
        player = GameObject.FindWithTag("Player");
        locations.Add(GameObject.FindWithTag("CentreSpeaker"));
        locations.Add(GameObject.FindWithTag("LeftSpeaker"));
        locations.Add(GameObject.FindWithTag("RightSpeaker"));
        locations.Add(GameObject.FindWithTag("LeftSurroundSpeaker"));
        locations.Add(GameObject.FindWithTag("RightSurroundSpeaker"));
        locations.Add(GameObject.FindWithTag("LeftRearSpeaker"));
        locations.Add(GameObject.FindWithTag("RightRearSpeaker"));
    }

    //Play different audio events based on player's Y value when 
    //triggered
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && (player.transform.position.y >= 1f))
        {
            wwiseEvent = "Play_SecondInterlude01";
            AkSoundEngine.PostEvent(wwiseEvent, locations[Random.Range(0, locations.Count)]);
        }

        if (other.gameObject.tag == "Player" && (player.transform.position.y >= 0.8f && player.transform.position.y < 1f))
        {
            wwiseEvent = "Play_SecondInterlude02";
            AkSoundEngine.PostEvent(wwiseEvent, locations[Random.Range(0, locations.Count)]);
        }
        if (other.gameObject.tag == "Player" && (player.transform.position.y < 0.8f))
        {
            wwiseEvent = "Play_SecondInterlude03";
            AkSoundEngine.PostEvent(wwiseEvent, locations[Random.Range(0, locations.Count)]);
        }
    }
}
