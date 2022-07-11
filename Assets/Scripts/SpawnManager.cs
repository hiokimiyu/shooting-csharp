using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Tooltip("�G�̃��X�g")]
    [SerializeField] List<GameObject> _enemyPrefabs;
    [Tooltip("�X�|�[���ʒu�w")]
    [SerializeField] float _spawnX = 7;
    [Tooltip("�X�|�[���ʒu�x")]
    [SerializeField] float _spawnY = 20;
    [Tooltip("�X�|�[������^�C�~���O")]
    [SerializeField] float _spawnInterval = 4.0f;
    [Tooltip("�X�|�[���^�C��")]
    [SerializeField] float _spawnTime = -2.0f;
    [Tooltip("�X�R�A")]
    [SerializeField]GameManager _gm;

    // Update is called once per frame
    void Update()
    {
        if(_gm.Scoer == 500)
        {
            _spawnInterval = 3f;
            Debug.Log("500");
        }
        if (_gm.Scoer == 1000)
        {
            _spawnInterval = 2f;
            Debug.Log("1000");
        }
        if (_gm.Scoer == 1500)
        {
            _spawnInterval = 2f;
            Debug.Log("1500");
        }
        if (_gm.Scoer == 2000)
        {
            _spawnInterval = 1f;
        }

        _spawnTime += Time.deltaTime;
        if(_spawnTime > _spawnInterval)
        {
            Vector2 _spawnPos = new Vector2(Random.Range(-_spawnX, _spawnX), Random.Range(0,_spawnY));
            int _enemyCount = Random.Range(0, _enemyPrefabs.Count);
            GameObject _enemy = _enemyPrefabs[_enemyCount];
            Instantiate(_enemy, _spawnPos, _enemy.transform.rotation);
            _spawnTime = 0;

            //Debug.Log(_spawnPos);
        }
    }
}
