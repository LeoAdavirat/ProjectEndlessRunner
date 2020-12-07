using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Map : MonoBehaviour
{
    Player Player;
    public Vector3 StartOfMap;
    public Vector3 EndofMap;
    private int Freme;
    void Start()
    {
        Freme = GameObject.Find("Map").GetComponent<MapChanger>().mapCounter;
        Player = GameObject.Find("Player").GetComponent<Player>();
        StartCoroutine(ClearRubbish());
    }
    IEnumerator ClearRubbish()
    {
        int FieldOfView = GameObject.Find("Map").GetComponent<MapChanger>().Field_Of_View;
        yield return new WaitUntil(() => GameObject.Find("Map").GetComponent<MapChanger>().mapCounter >= Freme + FieldOfView);
        Debug.Log("Deleted");
        Destroy(gameObject);
    }
}
