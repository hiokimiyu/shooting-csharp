using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Tooltip("’e‚Ì‘¬‚³")]
    [SerializeField] float _bulletSpeed = 40f;
    [Tooltip("Á‚¦‚éŽžŠÔ")]
    [SerializeField] float _destroy = 1.5f;
    float _time;

    void Update()
    {
        transform.Translate(Vector2.up * _bulletSpeed);
        _time += Time.deltaTime;
        if(_time > _destroy)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "enemy")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
