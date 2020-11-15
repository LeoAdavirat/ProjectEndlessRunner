using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapChanger : MonoBehaviour
{
    Player Player;
    private int selectedmap;
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Player>();
    }
    void Update()
    {
        if (Player.Resetmap == true)
        {
            Random.InitState(gameObject.transform.childCount);
            selectedmap = (int)Random.value;
            Player.Resetmap = !Player.Resetmap;
            Debug.Log("Changed");
            gameObject.transform.GetChild(selectedmap).gameObject.SetActive(true);
        }
    }
}