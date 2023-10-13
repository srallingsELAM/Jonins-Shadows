using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    GameObject player;
    Renderer rend;

    float playerStartPos;
    public float speed = 0.5f;

    private void Start()
    {
        player = GameObject.Find("Player");
        playerStartPos = player.transform.position.x;
    }

    private void Update()
    {
        float offset = (player.transform.position.x - playerStartPos) * speed;

        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
    }
}