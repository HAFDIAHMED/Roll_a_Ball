using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    /* Late Update is called once per frame but after when all 
    the other objects have been proceeded
    */

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
 