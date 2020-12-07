using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    private float Speedd;
    private Vector3 StartPoint;
    void Start()
    {
        gameObject.transform.position = GameObject.Find("Player").transform.position;
        int xchange = (int)Random.Range(6.000f, 20.000f);
        float ychange = Random.Range(-5 * xchange, 5 * xchange);
        gameObject.transform.position += new Vector3(ychange,0, xchange);
        StartPoint = gameObject.transform.position;
        Speedd = Random.Range(18, 100);

    }

    void Update()
    {
        gameObject.transform.position -= new Vector3(0, 0, Speedd * Time.deltaTime);
    }

    IEnumerator DestroyObj()
    {
        yield return new WaitUntil(() => gameObject.transform.position.x <= StartPoint.x - 130);
        Destroy(this);
    }
}
