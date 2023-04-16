using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public bool EndDialog;
    public GameObject Dialog1;
    public GameObject Dialog2;
    public QuestEvent questfirst;
    public bool Finel_dialog;
    private void Update()
    {
        if (EndDialog == true)
        {
            questfirst.Quest1 = true;
            Time.timeScale = 1;
            Dialog1.SetActive(false);
        }
        if (Finel_dialog == true)
        {
            Time.timeScale = 1;
            questfirst.Quest1 = false;
            Dialog1.SetActive(false);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 0;
            if (questfirst.end_Quest1 == false) { 
                Dialog1.SetActive(true); 
            }
            else
            {
                Dialog2.SetActive(true);
            }
           
        }
    }
}
