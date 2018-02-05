using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayerOnContact : MonoBehaviour {

    #region Variables

	#endregion

	void Start ()
	{
	}

	void Update ()
	{
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            gameController.instance.isAlive = false;
        }
    }
}
