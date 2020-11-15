using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.parent.position -= new Vector3(0, -3f, 7f);
    }
}
