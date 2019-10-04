    void Update()
    {
        scaledValue = playerY / startY;

        if (ambienceRTPC == true)
        {
            AkSoundEngine.SetRTPCValue(xRTPC, player.transform.position.x);
            AkSoundEngine.SetRTPCValue(zRTPC, player.transform.position.z);
        }

        if (timeRunning == true)
        {
            timer += Time.deltaTime;
            playerY = player.transform.position.y;
            AkSoundEngine.SetRTPCValue("YAxisIntro", scaledValue);
            //scaledValue = playerY / startY;
        }

        if (playerY <= (startY / 2) && hasStarted == true)
        {
            AkSoundEngine.PostEvent("Stop_Intro_FireEscape", gameObject);
            hasStarted = false;
            timeRunning = false;
            StartCoroutine("StartSeq");
        }
    }
