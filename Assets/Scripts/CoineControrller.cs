using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoineControrller : ItemB
{
    [Tooltip("コインのスコア")]
    [SerializeField] int _score = 100;
    [Tooltip("落ちる速度")]
    float _speed = 0.01f;

    private void Update()
    {
        transform.Translate(Vector2.down * _speed);
    }
    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddScore(_score);
    }
}
