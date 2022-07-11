using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [Tooltip("Player")]
    [SerializeField] GameObject _player;
    [Tooltip("敵の弾")]
    [SerializeField] GameObject _enemyBullet;
    [Tooltip("弾の間隔")]
    float _bulletTime = 1.0f;
    [Tooltip("感覚のカウント")]
    float _bulletValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        _bulletTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //弾を一秒ごとにする
        _bulletValue += Time.deltaTime;
        if(_bulletValue > _bulletTime)
        {
            //自分の座標
            Vector3 _pos = gameObject.transform.position;
            //弾のプレハブの作成
            GameObject _bullet = Instantiate(_enemyBullet);
            //位置決め
            _bullet.transform.position = _pos;
            //プレイヤーに向かわせる（力を加える）
            Vector2 _vec2 = _player.transform.position-_pos;
            _bullet.GetComponent<Rigidbody2D>().velocity = _vec2;
            _bulletTime = 0;
        }
    }
}
