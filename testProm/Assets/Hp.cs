using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : Die
{
    public int hp;
    private void Update()
    {
        Debug.Log(hp);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hp -= 2;
        if (hp <= 0)
        {
            HzKakNazvatDieNeProkaet();
        }
    
}

}
   
