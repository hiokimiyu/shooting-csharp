using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Tooltip("‚ ‚Ä‚é”")]
    [SerializeField] int _hit = 3;
    [Tooltip("“G‚Ì’e")]
    [SerializeField] GameObject _enemyBullet;
    [Tooltip("’e‚ÌŠÔŠu")]
    float _bulletTime = 2;
    [Tooltip("Š´Šo‚ÌƒJƒEƒ“ƒg")]
    float _bulletValue = 0;
    [Tooltip("EnemyeŒû")]
    [SerializeField] Transform _muzzle;
    [Tooltip("ƒRƒCƒ“‚ÌƒXƒRƒA")]
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
        //’e‚ðˆê•b‚²‚Æ‚É‚·‚é
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
