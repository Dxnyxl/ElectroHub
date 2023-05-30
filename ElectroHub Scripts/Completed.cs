using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Completed : MonoBehaviour
{
    public GameObject tick;

    public void CompletedTopic()
    {
        tick.SetActive(true);
    }
}
