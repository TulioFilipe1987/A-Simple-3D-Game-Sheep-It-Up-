
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;

    private float daming = 2f;
    private float height = 10f;

    private Vector3 startPos;

    private bool can_Follow;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        startPos = transform.position;
        can_Follow = true;
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }

    void Follow(){

        if (can_Follow){

           /* transform.position = Vector3.Lerp(
                new Vector3(player.position.x + 10f, player.transform.position.y + height,
                player.transform.z - 10f));*/

        }
        
    }

    public bool CanFollow
    {
        get
        {
            return can_Follow;
        }
        set
        {
            can_Follow = value;
        }
    }


}// CLASS
