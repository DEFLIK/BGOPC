using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighting : MonoBehaviour
{
    [SerializeField]
    private GameObject attackHitBox;

    private bool isAttacking;

    private void Start()
    {
        attackHitBox.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isAttacking)
        {
            isAttacking = true;
            StartCoroutine(DoAttack());
        }
    }

    IEnumerator DoAttack()
    {
        attackHitBox.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        attackHitBox.SetActive(false);

        isAttacking = false;
    }
}
