using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoritePull : MonoBehaviour {

    #region Variables

    public SpawnObjects meteoriteScript;

	#endregion

	void Start ()
	{
		
	}

	void Update ()
	{
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "meteorite")
        {
            meteoriteScript.respawn();
        }
    }
}
