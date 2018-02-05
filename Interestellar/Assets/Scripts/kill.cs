using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour {

    #region Variables

    public string target;
    public string target2;

	#endregion

	void Start ()
	{
		
	}

	void Update ()
	{
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == target || other.tag == target2)
        {
            Destroy(other.gameObject);
        }
    }
}
