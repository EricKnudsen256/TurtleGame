using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    private DialogueManager dm; 

    


    public void TriggerDialogue()
    {
        if(!dm)
        {
            dm = DialogueManager.GetManager();

            dm.StartDialogue(dialogue);
        }
    }
}
