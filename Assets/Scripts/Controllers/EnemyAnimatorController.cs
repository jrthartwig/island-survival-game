using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimatorController : MonoBehaviour
{
    public EnemyController enemyController;

    public void CheckAttack()
    {
        enemyController.CheckAttack();
    }

    public void EndAttack()
    {
        enemyController.EndAttack();
    }

}
