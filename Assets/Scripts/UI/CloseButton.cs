using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public void Close(GameObject objectToClose)
    {
        objectToClose.SetActive(false);
    }
}
