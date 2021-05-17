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
    private Sprite background;

    [SerializeField]
    private float size;

    //private void Awake()
    //{
    //    if (!target) target = FindObjectOfType<>().Transform;
    //}

    private void Update()
    {
        Vector3 position = target.position;  position.z = -10.0f;  position.y += 2.0f; 
        //if (Mathf.Abs(transform.position.x) < 2.5 || Mathf.Abs(transform.position.y) < 1.5)
            transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
    }


}
