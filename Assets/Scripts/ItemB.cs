using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemB : MonoBehaviour
{
    [Tooltip("‚¢‚ÂŽg‚¤‚Ì‚©")]
    //[SerializeField] ActivateTiming _whenActivate = ActivateTiming.Get;
    public abstract void Activate();

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Activate();
            Destroy(gameObject);
        }
    }
}
