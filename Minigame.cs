    //Start minigame, disable other colliders, instantiate objects at random locations
    IEnumerator ObjectSpawn()
    {
        GameObject.FindGameObjectWithTag("FirstInterludeSpace").GetComponent<BoxCollider>().enabled = false;
        GameObject.FindGameObjectWithTag("SecondInterludeSpace").GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(4);
        AkSoundEngine.PostEvent("Play_Music", gameObject);
        Instantiate(spawnObject, spawnLocations[Random.Range(0, spawnLocations.Count)], Quaternion.identity);
        yield return new WaitForSeconds(3);
        Instantiate(spawnObject, spawnLocations[Random.Range(0, spawnLocations.Count)], Quaternion.identity);
        yield return new WaitForSeconds(3);
        Instantiate(spawnObject, spawnLocations[Random.Range(0, spawnLocations.Count)], Quaternion.identity);
        yield return new WaitForSeconds(3);
        Instantiate(spawnObject, spawnLocations[Random.Range(0, spawnLocations.Count)], Quaternion.identity);
        yield return new WaitForSeconds(3);
        Instantiate(spawnObject, spawnLocations[Random.Range(0, spawnLocations.Count)], Quaternion.identity);
        yield return new WaitForSeconds(3);
        Instantiate(spawnObject, spawnLocations[Random.Range(0, spawnLocations.Count)], Quaternion.identity);
        yield return new WaitForSeconds(2.5f);
        Instantiate(spawnObject, spawnLocations[Random.Range(0, spawnLocations.Count)], Quaternion.identity);
        yield return new WaitForSeconds(2.5f);
        Instantiate(spawnObject, spawnLocations[Random.Range(0, spawnLocations.Count)], Quaternion.identity);
        yield return new WaitForSeconds(2.5f);
        Instantiate(spawnObject, spawnLocations[Random.Range(0, spawnLocations.Count)], Quaternion.identity);
        yield return new WaitForSeconds(2);
        Instantiate(spawnObject, spawnLocations[Random.Range(0, spawnLocations.Count)], Quaternion.identity);
        yield return new WaitForSeconds(2);
        AkSoundEngine.PostEvent("Stop_Music", gameObject);
        GameObject.FindWithTag("DogEmitter").GetComponent<DogEmitter>().gamesPlayed++;
        hasPlayed = true;
    }
    
    //Movement of instantiated objects, set inactive after specified value on Y axis reached
    void Update()
    {
        transform.position += Vector3.down * Time.deltaTime;

        if (gameObject.transform.position.y < 0.5)
        {
            AkSoundEngine.PostEvent(loseSound, gameObject);
            gameObject.SetActive(false);
        }
    }
