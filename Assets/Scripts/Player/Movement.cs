using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator Animator;
    public bool Grounded;

    private Vector3 directionVector = new Vector3();
    private float inputAxis;
    private Vector3 currentScale;

    public AudioClip jump;
    public AudioSource audio1;

    private void Start()
    {
        audio1 = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Grounded && Input.GetButtonDown("Jump"))
        {
            Grounded = false;
            Jump();
            audio1.PlayOneShot(jump);
        }

        inputAxis = Input.GetAxis("Horizontal");
        Animator.SetFloat("Horizontal", inputAxis);
        directionVector.x = inputAxis;
        if (inputAxis > 0 && transform.localScale.x < 0 || inputAxis < 0 && transform.localScale.x > 0)
            DoSpriteMirroring();

        transform.position += directionVector * Math.Abs(gameObject.transform.localScale.x) * Time.deltaTime;
    }

    private void Jump() => gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);

    private void DoSpriteMirroring()
    {
        currentScale = transform.localScale;
        currentScale.Set(currentScale.x * -1, currentScale.y, currentScale.z);
        transform.localScale = currentScale;
    }
}
