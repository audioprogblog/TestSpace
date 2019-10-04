    void Update()
    {
        //Scale the difference between the player's current Y value and
        //starting Y value to 0-1 for RTPCs
        scaledValue = playerY / startY;

        if (ambienceRTPC == true)
        {
            //Manipulate audio based on player's position on the axes
            AkSoundEngine.SetRTPCValue(xRTPC, player.transform.position.x);
            AkSoundEngine.SetRTPCValue(zRTPC, player.transform.position.z);
        }

        if (timeRunning == true)
        {
            //Run a timer, track player's position on Y axis, use
            //scaledvalue in RTPC
            timer += Time.deltaTime;
            playerY = player.transform.position.y;
            AkSoundEngine.SetRTPCValue("YAxisIntro", scaledValue);
            //scaledValue = playerY / startY;
        }

        //Check if player's position on Y axis is less than half
        //what it was at the beginning (determine if player is bending over)
        if (playerY <= (startY / 2) && hasStarted == true)
        {
            //If yes play sound, change bools, trigger Coroutine
            AkSoundEngine.PostEvent("Stop_Intro_FireEscape", gameObject);
            hasStarted = false;
            timeRunning = false;
            StartCoroutine("StartSeq");
        }
    }

    IEnumerator StartSeq()
    {
        //Play first scene, trigger audio w/ callback method for 
        //next scene
        AkSoundEngine.PostEvent("Stop_Beginning", gameObject);
        AkSoundEngine.PostEvent("Play_Beginning", GameObject.FindWithTag("LeftRearSpeaker"));
        AkSoundEngine.PostEvent("Play_Beginning3", GameObject.FindWithTag("CentreSpeaker"));
        ambienceRTPC = true;
        AkSoundEngine.PostEvent(firstEvent, gameObject);
        yield return new WaitForSeconds(3);
        AkSoundEngine.PostEvent(secondDialogue, gameObject, (uint)AkCallbackType.AK_EndOfEvent, ParticleMovement, null);
        particleGuide.SetActive(true);
    }
