using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float spd;

    private Rigidbody2D rigBody;
    void Start()
    {
        rigBody = gameObject.GetComponent<Rigidbody2D>();
        Debug.Log("스타트");

    }

    void Update()
    {

    }

    // private void FixedUpdate()
    // {
    //     if (Input.GetKey(KeyCode.LeftArrow))
    //     {
    //         rigBody.AddForce(Vector2.left * spd, ForceMode2D.Impulse);
    //         rigBody.velocity = new Vector2(-spd, rigBody.velocity.y);
    //         Debug.Log("!!");
    //     }
    // }

    private void FixedUpdate()
    {
        Debug.Log("Fixed Update 호출");
    }
}