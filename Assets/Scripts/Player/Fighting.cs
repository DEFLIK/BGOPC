using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighting : MonoBehaviour
{
    public enum Punches
    {
        Weak,
        Heavy,
        FarAttack
    }

    [SerializeField]
    private GameObject attackHitBox;

    private bool isAttacking;
    public Punches HitType;

    private void Start()
    {
        attackHitBox.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isAttacking)
        {
            isAttacking = true;
            StartCoroutine(DoWeakPunch());
        }

        if (Input.GetButtonDown("Fire2") && !isAttacking)
        {
            isAttacking = true;
            StartCoroutine(DoHeavyPunch());
        }

        if (Input.GetButtonDown("Fire3") && !isAttacking)
        {
            isAttacking = true;
            StartCoroutine(DoFarAttack());
            
        }
    }

    IEnumerator DoWeakPunch()
    {
        HitType = Punches.Weak;
        attackHitBox.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        attackHitBox.SetActive(false);

        isAttacking = false;
    }

    IEnumerator DoHeavyPunch()
    {
        HitType = Punches.Heavy;
        attackHitBox.SetActive(true);
        yield return new WaitForSeconds(1f);
        attackHitBox.SetActive(false);

        isAttacking = false;
    }

    IEnumerator DoFarAttack()
    {

        HitType = Punches.FarAttack;
        attackHitBox.SetActive(true);
        yield return new WaitForSeconds(3f);
        attackHitBox.SetActive(false);

        isAttacking = false;
    }
}
