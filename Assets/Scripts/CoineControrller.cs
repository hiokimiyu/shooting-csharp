using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoineControrller : ItemB
{
    [Tooltip("�R�C���̃X�R�A")]
    [SerializeField] int _score = 100;
    [Tooltip("�����鑬�x")]
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
