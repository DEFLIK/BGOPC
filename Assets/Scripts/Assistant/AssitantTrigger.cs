using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssitantTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject assistant;
    [SerializeField]
    private GameObject pointer;

    private Animator assAnim;
    private Animator pointAnim;

    private bool isActive;

    public AudioClip open;
    private AudioSource audio1;

    private void Start()
    {
        pointer.SetActive(false);
        assistant.SetActive(true);
        isActive = true;
        //audio1.PlayOneShot(open);
        assAnim = assistant.GetComponent<Animator>();
        pointAnim = pointer.GetComponent<Animator>();
        audio1 = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //assistant.SetActive(true);
            pointer.SetActive(true);
            pointAnim.Play("PointerAppear");
            //assAnim.Play("Appearance");
        }
    }

   

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pointAnim.Play("PointerDisappear");
            //assAnim.Play("Disappearance");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isActive)
            {
                assAnim.Play("Disappearance");
                isActive = false;
                audio1.PlayOneShot(open);
            }
            else
            {
                assistant.SetActive(true);

                assAnim.Play("Appearance");
                isActive = true;
                audio1.PlayOneShot(open);
            }
        }
    }
}
