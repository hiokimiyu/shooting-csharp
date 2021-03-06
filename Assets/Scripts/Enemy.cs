using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Tooltip("あてる数")]
    [SerializeField] int _hit = 3;
    [Tooltip("敵の弾")]
    [SerializeField] GameObject _enemyBullet;
    [Tooltip("弾の間隔")]
    float _bulletTime = 2;
    [Tooltip("感覚のカウント")]
    float _bulletValue = 0;
    [Tooltip("Enemy銃口")]
    [SerializeField] Transform _muzzle;
    [Tooltip("コインのスコア")]
    [SerializeField] int _score = 10;
    [Tooltip("koinn")]
    [SerializeField] GameObject _coine;
    [Tooltip("kaifuku")]
    [SerializeField] GameObject _harte;
    
    void Start()
    {
        _bulletValue = 0;
    }

    private void Update()
    {
        //弾を一秒ごとにする
        _bulletValue += Time.deltaTime;
        if(_bulletValue > _bulletTime)
        {
            Instantiate(_enemyBullet, _muzzle.position, Quaternion.identity);
            _bulletValue = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "tama")
        { 
            _hit--;
            if (_hit == 0)
            {
                int _drop = Random.Range(0,6);
                FindObjectOfType<GameManager>().AddScore(_score);
                if(_drop < 2)
                {
                    Instantiate(_coine, gameObject.transform.position, Quaternion.identity);
                }
                else if (_drop < 4)
                {
                    Instantiate(_harte, gameObject.transform.position, Quaternion.identity);
                }
                else if(_drop <= 5)
                {

                }
                Destroy(gameObject);
            }
        }
    }
}
