using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateClue : MonoBehaviour
{
    private ClueSystem clueSystem;

    //get clue system from parent
    private void Start()
    {
        clueSystem = GetComponentInParent<ClueSystem>();
    }

    //check if the player has collided with the following clue and activate next clue
    private void OnTriggerEnter(Collider other)
    {
        //check if clue is active and if player has collided with it
        if (gameObject.activeSelf && other.CompareTag("Player"))
        {
            //activate next clue
            clueSystem.ActivateNextClue();
        }
    }
}
