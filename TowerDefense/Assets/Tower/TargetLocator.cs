using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
    void Update()
    {
        AimAtEnemy();
    }
    void AimAtEnemy()
    {
        Transform target = FindObjectOfType<EnemyMover>().transform;
        weapon.LookAt(target);
    }
}
