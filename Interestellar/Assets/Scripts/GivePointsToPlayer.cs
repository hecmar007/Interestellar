using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivePointsToPlayer : MonoBehaviour {

    #region Variables

    public int pointsToAdd = 10;
    private bool hasAlreadyTouch = false;

	#endregion

	void Start ()
	{
		
	}

	void Update ()
	{
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(!hasAlreadyTouch && other.tag == "Player")
        {
            gameController.instance.scoreToAdd += pointsToAdd;
            hasAlreadyTouch = true;
        }
    }
}
