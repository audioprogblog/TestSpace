    //Coroutine to play one of two endings based on Y value
    //If player is crouching down ending 1
    //If player is standing ending 2
    IEnumerator ChooseEnding()
    {
        if (hasEntered == true && enterY <= 0.5f)
        {
            AkSoundEngine.PostEvent(firstEnding, gameObject);
            hasEntered = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            AkSoundEngine.PostEvent("Play_Abstract_Amb_02", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Abstract_Amb_05", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_lb_Sub", gameObject);
            AkSoundEngine.PostEvent("Play_CrawlEnding", gameObject);
            AkSoundEngine.PostEvent("Play_CrawlEndingAmbience", gameObject, (uint)AkCallbackType.AK_EndOfEvent, FinishGame, null);
            yield return new WaitForSeconds(30);
            AkSoundEngine.PostEvent("Stop_CrawlEnding", gameObject);
            AkSoundEngine.PostEvent("Play_Closed_Windows", gameObject);
        }

        else if (hasEntered == true && enterY > 0.5f)
        {
            //Play sound design, finish with callback to trigger final method
            gameObject.GetComponent<BoxCollider>().enabled = false;
            hasEntered = false;
            AkSoundEngine.PostEvent("Play_Closed_Windows", gameObject);
            AkSoundEngine.PostEvent("Play_PreLaunch", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_PreLaunch", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_PreLaunch", locations[Random.Range(0, locations.Count)]);
            yield return new WaitForSeconds(1);
            AkSoundEngine.PostEvent("Stop_Rain", gameObject);
            AkSoundEngine.PostEvent("Play_PreLaunch", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_PreLaunch", locations[Random.Range(0, locations.Count)]);
            yield return new WaitForSeconds(1);
            AkSoundEngine.PostEvent("Play_PreLaunch", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Screamers", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Screamers", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Screamers", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_PreLaunch", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Screamers", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_PreLaunch", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Screamers", locations[Random.Range(0, locations.Count)]);
            yield return new WaitForSeconds(3);
            AkSoundEngine.PostEvent("Play_lb_WalkMusic", gameObject);
            AkSoundEngine.PostEvent("Play_Launch", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Launch", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Launch", locations[Random.Range(0, locations.Count)]);
            yield return new WaitForSeconds(1);
            AkSoundEngine.PostEvent("Play_Launch", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Launch", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            yield return new WaitForSeconds(3);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            yield return new WaitForSeconds(2);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            yield return new WaitForSeconds(2);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            AkSoundEngine.PostEvent("Play_Bang", locations[Random.Range(0, locations.Count)]);
            yield return new WaitForSeconds(1);
            AkSoundEngine.PostEvent(secondEnding, gameObject, (uint)AkCallbackType.AK_EndOfEvent, FinishGame, null);
        }
        yield return new WaitForSeconds(1);
    }
