   //Using a callback to call another method after a Wwise event finishes
   IEnumerator SecondSpace()
    {
        AkSoundEngine.PostEvent(stopAll, gameObject);
        AkSoundEngine.PostEvent(transitionSound, GameObject.FindWithTag("RightSurroundSpeaker"));
        yield return new WaitForSeconds(0.5f);
        AkSoundEngine.SetRTPCValue("CrowdRTPC", 0);
        AkSoundEngine.PostEvent(firstAmbience, thirdAmbisonicEmitter);
        yield return new WaitForSeconds(3);
        AkSoundEngine.PostEvent(firstDialogue, gameObject, (uint)AkCallbackType.AK_EndOfEvent, SecondDialogue, null);
        yield return new WaitForSeconds(35);
        AkSoundEngine.SetRTPCValue("CrowdRTPC", 30);
        yield return new WaitForSeconds(5);
        AkSoundEngine.SetRTPCValue("CrowdRTPC", 40);
        yield return new WaitForSeconds(5);
        AkSoundEngine.SetRTPCValue("CrowdRTPC", 50);
        yield return new WaitForSeconds(5);
        AkSoundEngine.SetRTPCValue("CrowdRTPC", 60);
        //yield return new WaitForSeconds(5);
    }

    public void SecondDialogue(object in_cookie, AkCallbackType in_type, object in_info)
    {
        GameObject.FindWithTag("ParticleGuide").GetComponent<ParticleGuide>().particleMain.gravityModifier = -0.1f;
        GameObject.FindWithTag("ParticleGuide").GetComponent<ParticleGuide>().particles.Stop();
        AkSoundEngine.PostEvent(secondDialogue, gameObject, (uint)AkCallbackType.AK_EndOfEvent, StartDog, null);
    }
