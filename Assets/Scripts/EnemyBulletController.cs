using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : ItemB
{
    [Tooltip("当たった時の減るスコア")]
    [SerializeField] int _score = -5;
    [Tooltip("当たった時に減る体力")]
    [SerializeField] int _recoverLife = -15;

    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddScore(_score);
        FindObjectOfType<GameManager>().AddLife(_recoverLife);
    }
}
