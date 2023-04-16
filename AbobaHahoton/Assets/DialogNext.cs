using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNext : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    private bool isText1 = true;
    public DialogManager nPC_Task;
    public bool endDialog;
    public GameObject QuestObject;
    public GameObject DialogFinal;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isText1 == true)
            {
                isText1 = false;
            }
            else
            {
                if(endDialog == false)
                {
                    isText1 = true;
                    QuestObject.SetActive(true);
                    nPC_Task.EndDialog = true;
                    
                }
                else
                {
                    isText1 = true;
                    nPC_Task.Finel_dialog = true;
                    DialogFinal.SetActive(false);
                }
               
            }
            }   
        if (isText1 == true)
        {
            text1.SetActive(true);
            text2.SetActive(false);
        }
        else
        {
            text1.SetActive(false);
            text2.SetActive(true);
        }
    }
}
