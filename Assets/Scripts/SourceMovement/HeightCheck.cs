using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightCheck : MonoBehaviour
{
    public Transform player;
    public Vector3 spawnpointPosition;
    public float height;

    public void FixedUpdate()
    {
        if (player.position.y < height)
        {
            player.position = spawnpointPosition;
        }
    }
}
