using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableControls : MonoBehaviour
{
    private SC_FPSController fpsController;
    IEnumerator Start()
    {
        fpsController = GetComponent<SC_FPSController>();
        //wait 10 seconds before enabling controls
        yield return new WaitForSeconds(10);
        //enable controls
        fpsController.enabled = true;
    }


}
