using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public CameraClearFlags clearFlags;
    void Start()
    {
        clearFlags = CameraClearFlags.Nothing;
    }
    void Update()
    {
    }
}
