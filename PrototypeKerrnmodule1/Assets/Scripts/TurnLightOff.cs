using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightOff : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(10);
        gameObject.SetActive(false);
    }

}
