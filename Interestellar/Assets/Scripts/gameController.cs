using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

    public static gameController instance;

    public float scrollSpeed = -1.5f;

    public float seconds = 7.5f;

	// Use this for initialization
	void Awake ()
    {
		if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
	}

    void Start()
    {
        StartCoroutine(SpeedIncrease());
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    IEnumerator SpeedIncrease()
    {
        if (scrollSpeed >= 5)
        {
            yield return new WaitForSeconds(seconds);
            scrollSpeed = scrollSpeed - 0.2f;
        }
    }
}
