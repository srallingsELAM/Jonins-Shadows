using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D playerObject;
    }


    playerObject = GetComponent<Rigidbody2D>();
    // Update is called once per frame
    void Update()
    {
        float movementValueX = Input.GetAxis("Horizontal");
    }

    playerObject.velocity = new Vector2 (movementValueX, playerObject.velocity.y);
}










