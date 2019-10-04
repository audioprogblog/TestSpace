        if (rayCasting == true)
        {
            //Draw ray 
            Ray ray = new Ray(gameObject.transform.position, transform.forward);
            RaycastHit hit;
            Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward * 20, Color.green);
            
            //If ray collision tag == "ParticleMan" do this
            if (Physics.Raycast(ray, out hit, 50))
            {
                if (hit.collider.tag == "ParticleMan")
                {
                    Debug.Log("Raycast Hit");
                    AkSoundEngine.PostEvent(firstEvent, GameObject.FindWithTag("ParticleMan"));
                    AkSoundEngine.PostEvent(secondEvent, GameObject.FindWithTag("ParticleMan"));
                    timeRunning = true;
                    rayCasting = false;
                }
            }

            //If ray collision tag == "DogEmitter" do this
            if(Physics.Raycast(ray, out hit, 50))
            {
                if (hit.collider.tag == "DogEmitter" && isPlaying == false)
                {
                    AkSoundEngine.PostEvent(wwiseEvent, location);
                    isPlaying = true;
                    rayCasting = false;
                }              
            }
        }
    }
