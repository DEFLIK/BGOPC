using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.0f;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float leftLimit;
    [SerializeField]
    private float rightLimit;
    [SerializeField]
    private float bottomLimit;
    [SerializeField]
    private float upperLimit;

    //private void Awake()
    //{
    //    if (!target) target = FindObjectOfType<>().Transform;
    //}

    private void Update()
    {
        Vector3 position = target.position;  position.z = -10.0f;  
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);

        transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
            Mathf.Clamp(transform.position.y, bottomLimit, upperLimit),
            transform.position.z
            );


    }


}
