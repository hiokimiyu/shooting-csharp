using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : ItemB
{
    [Tooltip("�����������̌���X�R�A")]
    [SerializeField] int _score = -5;
    [Tooltip("�����������Ɍ���̗�")]
    [SerializeField] int _recoverLife = -15;

    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddScore(_score);
        FindObjectOfType<GameManager>().AddLife(_recoverLife);
    }
}
