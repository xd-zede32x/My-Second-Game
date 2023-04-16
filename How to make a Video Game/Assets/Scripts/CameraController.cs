using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform players;
    public Vector3 vector3;
    private void Update()
    {
        transform.position = players.position  + vector3;
    }


}
