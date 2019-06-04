using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAttackController : MonoBehaviour
{

    public float attackInterval;
    public float lerpSpeed;
    
    private Animator animator;
    private float timer;
    private bool attacking = false;

    void Start()
    {
        animator = GetComponent<Animator>();

        CalmDown();
    }

    void Update()
    {
        if (!attacking)
        {
            if (timer <= 0)
                StartCoroutine(Attack());    
            else
                timer -= Time.deltaTime;
        }
    }

    public void CalmDown()
    {
        attacking = false;
        animator.SetInteger("animation", 1);
        timer = attackInterval;
    }

    IEnumerator Attack() {
        attacking = true;
        animator.SetInteger("animation", 7);
        yield return new WaitForSeconds(1.5f);
        CalmDown();
        yield break;
    }

}
