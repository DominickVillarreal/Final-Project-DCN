using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamage : MonoBehaviour
{

    public int damage;
    public playerHealth playerhealth;
    private void Awake()
    {
        playerhealth = GameObject.FindGameObjectWithTag("Player").GetComponent<playerHealth>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerhealth.Takedamage(damage);
            
        }
    }
}
