using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [Tooltip("Player")]
    [SerializeField] GameObject _player;
    [Tooltip("�G�̒e")]
    [SerializeField] GameObject _enemyBullet;
    [Tooltip("�e�̊Ԋu")]
    float _bulletTime = 1.0f;
    [Tooltip("���o�̃J�E���g")]
    float _bulletValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        _bulletTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //�e����b���Ƃɂ���
        _bulletValue += Time.deltaTime;
        if(_bulletValue > _bulletTime)
        {
            //�����̍��W
            Vector3 _pos = gameObject.transform.position;
            //�e�̃v���n�u�̍쐬
            GameObject _bullet = Instantiate(_enemyBullet);
            //�ʒu����
            _bullet.transform.position = _pos;
            //�v���C���[�Ɍ����킹��i�͂�������j
            Vector2 _vec2 = _player.transform.position-_pos;
            _bullet.GetComponent<Rigidbody2D>().velocity = _vec2;
            _bulletTime = 0;
        }
    }
}
