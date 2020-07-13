﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        getInput();
        base.Update();
    }

    

    private void getInput()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
        }
    }
}
