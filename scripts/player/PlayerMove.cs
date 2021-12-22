using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script class
public class PlayerMove : MonoBehaviour
{
    //variable for player speed
    public float moveSpeed = 3;

    // Update is called once per frame
    void Update()
    {
        //moves the player object forward relative to the game speed
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
    }
}
