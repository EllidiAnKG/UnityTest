using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public QuestEvent qevent;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            qevent.end_Quest1 = true;
            Destroy(gameObject);
        }
    }
}
