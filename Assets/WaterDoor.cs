using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDoor : MonoBehaviour
{
    public bool isActivated = false;
    public void Activate()
    {
        isActivated = true;
    }
    public void Deactivate()
    {
        isActivated = false;
    }

}
