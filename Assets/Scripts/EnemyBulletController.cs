using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : ItemB
{
    [Tooltip("“–‚½‚Á‚½Žž‚ÌŒ¸‚éƒXƒRƒA")]
    [SerializeField] int _score = -5;
    [Tooltip("“–‚½‚Á‚½Žž‚ÉŒ¸‚é‘Ì—Í")]
    [SerializeField] int _recoverLife = -15;

    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddScore(_score);
        FindObjectOfType<GameManager>().AddLife(_recoverLife);
    }
}
