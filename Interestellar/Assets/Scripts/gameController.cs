using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour {

    public static gameController instance;

    public float scrollSpeed = -1.5f;

    public float seconds = 7.5f;

    [HideInInspector] public int score = 0;
    [HideInInspector] public int scoreToAdd = 0;
    private float Timer;
    public Text text;

    public GameObject gameOverText;
    public GameObject gameOverSubText;

    public bool isAlive = true;

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
        if(isAlive)
        {
            StartCoroutine(SpeedIncrease());
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(isAlive)
        {
            Timer += Time.deltaTime;
            score = Mathf.RoundToInt(Timer);
            score += scoreToAdd;
            text.text = "Score: " + score;
   
        }
        else
        {
           gameOverText.SetActive(true);
           gameOverSubText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
	}

    IEnumerator SpeedIncrease()
    {
        if (scrollSpeed >= 5 && isAlive)
        {
            yield return new WaitForSeconds(seconds);
            scrollSpeed = scrollSpeed - 0.2f;
        }
    }
}
