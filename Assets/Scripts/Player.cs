using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Tooltip("à⁄ìÆë¨ìx")]
    [SerializeField] float _moveSpeed = 3f;
    [Tooltip("íe")]
    [SerializeField] GameObject _bulletPrefab;
    [Tooltip("èeå˚")]
    [SerializeField] Transform _muzzle;
    Rigidbody2D _rb = default;
    [Tooltip("âΩâÒ")]
    float _count = 0;
    [Tooltip("ïbêî")]
    float _time = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float _h = Input.GetAxis("Horizontal");
        Vector2 _velocity = _rb.velocity;
        float _v = Input.GetAxis("Vertical");

        //â°à⁄ìÆ
        if(_h != 0)
        {
            _velocity.x = _h * _moveSpeed;
        }
        if(_v != 0)
        {
            _velocity.y = _v * _moveSpeed;
        }
        _rb.velocity = _velocity;
        if (Input.GetKey(KeyCode.Space))
        {
            _count += Time.deltaTime;
            if (_count > _time)
            {
                Instantiate(_bulletPrefab, _muzzle.position, Quaternion.identity);
                _count = 0;
            }
        }
    }
}
