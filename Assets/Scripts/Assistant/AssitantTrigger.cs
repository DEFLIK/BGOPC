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

    private void Start()
    {
        pointer.SetActive(false);
        assistant.SetActive(false);
        isActive = false;
        assAnim = assistant.GetComponent<Animator>();
        pointAnim = pointer.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pointer.SetActive(true);
            pointAnim.Play("PointerAppear");

            if (Input.GetButtonDown("Submit"))
            {
                if (!isActive)
                {
                    assistant.SetActive(true);

                    assAnim.Play("Appearance");
                    isActive = true;
                }
                else
                {
                    Disappearance();
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pointAnim.Play("PointerDisappear");
        }
    }

    IEnumerator Disappearance()
    {
        assAnim.Play("Disappearance");
        yield return new WaitForSeconds(1f);
        assistant.SetActive(false);
        isActive = false;
    }

    IEnumerator PointerDisappear()
    {
        pointAnim.Play("PointerDisappear");
        yield return new WaitForSeconds(1f);
        pointer.SetActive(false);
    }
}
