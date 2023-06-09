using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemylayers;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Attack();
        }
    }

    void Attack()
    {
        //play an attack animation
        animator.SetTrigger("Attack");


        //Detect ememies in range of attack
        Collider2D[]hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemylayers);

        //damage
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit" + enemy.name);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}


 
