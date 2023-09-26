using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueSystem : MonoBehaviour
{
    private GameObject[] clues;
    private int currentClue = 0;
    public Animation door;

    private void Start()
    {
        clues = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            clues[i] = transform.GetChild(i).gameObject;
        }
        foreach (var clue in clues)
        {
            print(clue.name);
        }
        for (int i = 0; i < clues.Length; i++)
        {
            clues[i].SetActive(false);
        }
        StartCoroutine(ActivateLate());
    }

    public void ActivateNextClue()
    {
        if (clues[currentClue].activeSelf)
        {
            //deactivate current clue
            clues[currentClue].SetActive(false);
            //activate next clue
            currentClue++;
            if(currentClue != clues.Length - 1)
                clues[currentClue].SetActive(true);
            OpenDoor();
        }
    }

    private IEnumerator ActivateLate()
    {
        yield return new WaitForSeconds(10);
        clues[0].SetActive(true);
    }

    //if all clues are found, open door
    public void OpenDoor()
    {
        if (currentClue == clues.Length - 1)
        {
            door.Play("Open Door Animation");
        }
    }
}