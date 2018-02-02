using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    #region Variables

    public float speed = 10000f;
    private Rigidbody2D rbg;

	#endregion

	void Start ()
	{
        rbg = GetComponent<Rigidbody2D>();
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.A))
        {
            rbg.velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rbg.velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
