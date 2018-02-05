﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollerObject : MonoBehaviour {

    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start ()
    {
        if(gameController.instance.isAlive)
        {
            rb2d = GetComponent<Rigidbody2D>();
            rb2d.velocity = new Vector2(0, gameController.instance.scrollSpeed);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!gameController.instance.isAlive)
        {
            rb2d.velocity = Vector2.zero;
        }
	}
}
