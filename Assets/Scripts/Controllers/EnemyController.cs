using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : CharController
{
    public Animator anim;

    public Transform player;
    public float chaseRange;
    public float attackRange;
    public float damageRange;

    public float speed;
    public float rotationSpeed;

    private Vector3 targetPoint;
    private Quaternion targetRotation;

    public Transform attackBox;

    bool chasing;
    bool attacking;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (!chasing) 
        { 
            if (distance < chaseRange)
            {
                chasing = true;
                anim.SetBool("chasing", true);
            }
        }
        if (chasing)
        {
            targetPoint = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z) - transform.position;
            targetRotation = Quaternion.LookRotation(targetPoint, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
            if (distance > attackRange)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }
            else
            {
                Attack();
            }

        }
    }

    void Attack()
    {
        chasing = false;
        attacking = true;
        anim.SetBool("attacking", true);
    }

    public void CheckAttack()
    {
        if (Vector3.Distance(player.position, attackBox.position) <= damageRange)
        {
            //Damage Player
            Debug.Log("Hurt Player");
        }
    }

    public void EndAttack()
    {
        anim.SetBool("attacking", false);
        attacking = false;
        chasing = true;
    }
}
