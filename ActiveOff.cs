using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveOff : MonoBehaviour
{
    Player Player;
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Player>();
    }
    void FixedUpdate()
    {
        if (Player.Resetmap == true)
        {
            gameObject.SetActive(false);
        }
    }
}
