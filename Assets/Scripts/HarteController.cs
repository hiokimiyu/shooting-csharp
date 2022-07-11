using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarteController : ItemB
{
    [SerializeField] int _recoverLife = 10;
    [Tooltip("—Ž‚¿‚é‘¬“x")]
    float _speed = 0.01f;

    private void Update()
    {
        transform.Translate(Vector2.down * _speed);
    }
    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddLife(_recoverLife);
        //Debug.Log("supana");
    }
}
