using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapChanger : MonoBehaviour
{
    public int Field_Of_View;
    public bool ResetMap;
    GameObject Player;
    private int selectedmap;
    public int mapCounter = 0;
    public Vector3 EndLastMap;
    void Start()
    {
        Player = GameObject.Find("Player");
        EndLastMap = new Vector3(0.1f, 1f, 9f);
        CreateMap();
        CreateMap();
    }
    void Update()
    {
//        Debug.Log(EndLastMap);
//       CreateMap();
        if (Player.transform.position.z >= EndLastMap.z - 20)
        {
            CreateMap();
            ResetMap = !ResetMap;
            Debug.Log("Added");
        }
        Instantiate(GameObject.Find("Speed"));
    }
    void CreateMap()
    {
        selectedmap = (int)Random.Range(0, gameObject.transform.childCount);
        Map Map = gameObject.transform.GetChild(selectedmap).gameObject.GetComponent<Map>();
        mapCounter++;
        GameObject NextMap = Instantiate(gameObject.transform.GetChild(selectedmap).gameObject, EndLastMap, Quaternion.identity);
        NextMap.SetActive(true);
        EndLastMap += Map.EndofMap - Map.StartOfMap;
    }
}