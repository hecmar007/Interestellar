using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    #region Variables

    public float speed = 10000f;
    private Rigidbody2D rbg;

    #endregion

    void Start()
    {
        rbg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(gameController.instance.isAlive)
        {
            transform.Translate((transform.up * Input.GetAxisRaw("Vertical") + transform.right * Input.GetAxisRaw("Horizontal")).normalized * speed * Time.deltaTime);
        }
    }
}
