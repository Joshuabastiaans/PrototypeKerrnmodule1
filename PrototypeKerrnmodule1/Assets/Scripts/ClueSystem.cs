using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueSystem : MonoBehaviour
{
    public GameObject[] clues;
    public int currentClue = 0;

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
        for (int i = 1; i < clues.Length; i++)
        {
            clues[i].SetActive(false);
        }
        clues[0].SetActive(true);
    }

    public void ActivateNextClue()
    {
        if (clues[currentClue].activeSelf)
        {
            //deactivate current clue
            clues[currentClue].SetActive(false);
            //activate next clue
            currentClue++;
            clues[currentClue].SetActive(true);

        }
    }



}
