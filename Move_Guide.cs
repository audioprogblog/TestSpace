    //Move player's guide based on their score
    void FixedUpdate()
    {
        //Determine speed of guide GameObject
        //Get ShapeModule of guide GameObject ParticleSystem
        float step = (speed * Time.deltaTime);
        ParticleSystem.ShapeModule editableShape = particles.shape;

        if (localScore == 0)
        {

        }

        if (localScore == 1)
        {
            //Change target position
            //Move ParticleSystem ShapeModule position
            target = GameObject.FindWithTag("TargetOne");
            editableShape.position = Vector3.MoveTowards(editableShape.position, target.transform.position, step);
        }

        if (localScore == 2)
        {
            target = GameObject.FindWithTag("TargetTwo");
            editableShape.position = Vector3.MoveTowards(editableShape.position, target.transform.position, step);
        }

        if (localScore == 3)
        {
            target = GameObject.FindWithTag("TargetOne");
            editableShape.position = Vector3.MoveTowards(editableShape.position, target.transform.position, step);
        }

        if (localScore == 4)
        {
            target = GameObject.FindWithTag("TargetTwo");
            editableShape.position = Vector3.MoveTowards(editableShape.position, target.transform.position, step);
        }

        if (localScore == 5)
        {
            target = GameObject.FindWithTag("CentreSpace");
            editableShape.position = Vector3.MoveTowards(editableShape.position, target.transform.position, step);
        }

        if (localScore == 6)
        {
            target = GameObject.FindWithTag("TargetThree");
            editableShape.position = Vector3.MoveTowards(editableShape.position, target.transform.position, step);
        }
    }
