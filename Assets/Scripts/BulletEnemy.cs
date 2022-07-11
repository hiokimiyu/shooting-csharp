using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    [Tooltip("弾の速さ")]
    [SerializeField] float _bulletSpeed = 0.5f;
    [Tooltip("消える時間")]
    [SerializeField] float _destroy = 1.5f;
    //[Tooltip("Playerの場所")]
    //[SerializeField] Transform _player;
    [Tooltip("tamaリジットボディ")]
    Rigidbody2D _rb;
    //[Tooltip("弾のスピード")]
    //[SerializeField] float _speed = 0.5f;
    float _time;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //_player = GetComponent<Transform>();
        //Vector2 _vec2 = _player.position - gameObject.transform.position;
        transform.Translate(Vector2.down * _bulletSpeed);

        _time += Time.deltaTime;
        if (_time > _destroy)
        {
            Destroy(gameObject);
        }
    }
}
