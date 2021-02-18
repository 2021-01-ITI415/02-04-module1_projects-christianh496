using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + 4, player.transform.position.y + 12f, player.transform.position.z + 0f);
    }


}
