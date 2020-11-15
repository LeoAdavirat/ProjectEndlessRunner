using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    private Vector3 pV;                            //playerVelocity
    CharacterController controller;
    private bool GroundedPlayer;
    public float speed;
    public float gravity;
    public bool Resetmap;
    private string[] losem = {"You lost, such a nub hahaha!", "Get rekt u idiot", "See the reason why u should delete this game?", "U can't even pass this ez thing", "U'd better die than bitter at me, DiO" };
    void Start()
    {
        gameObject.transform.position = new Vector3(0f, 2.5f, 0f);
        pV = new Vector3(0f, 0f, 0f);
        controller = gameObject.GetComponent<CharacterController>();
        StartCoroutine(Startsss());
        Resetmap = false;
    }
    void Update()
    {
        GroundedPlayer = controller.isGrounded;
        pV.y -= gravity;
        pV.z = speed;
        pV.x = Input.GetAxisRaw("Horizontal") * speed / 2;
        if (Input.GetButtonUp("Horizontal"))
        {
            pV.x = 0;
        }
        if (Input.GetButtonDown("Jump") && GroundedPlayer)
        {
            pV.y = speed/2;
        }
        Vector3 movin = (pV.x * transform.right + pV.y * transform.up + pV.z * transform.forward) * Time.deltaTime;
        controller.Move(movin);
        if (gameObject.transform.position.z >= 25)
        {
            Resetmap = true;
            gameObject.transform.position = new Vector3(0f, 2.5f, 0f);
        }
    }
    IEnumerator Startsss()
    {
        yield return new WaitUntil(() => GroundedPlayer);
        Debug.Log("Game Started.");
        gravity = gravity / 2;
        yield return new WaitUntil(() => !GroundedPlayer && gameObject.transform.position.y <= 0);
        Random.InitState(losem.Length);
        Debug.Log(losem[(int)Random.value]);
    }
}
