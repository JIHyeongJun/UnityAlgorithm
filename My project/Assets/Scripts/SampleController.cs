using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleController : MonoBehaviour
{
    void Start()
    {
        Singleton.Instance.InscreaseScore(10);
        GameManager.instance.InscreaseScore(15);
    }
}
