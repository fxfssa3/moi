using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelaaja : MonoBehaviour
{
    public float moveSpeed = 5.5f;
    public CharacterController controller;
    Vector3 moveDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = input.GetAxis("vertical")

        moveDir = new Vector3(horizontal,0,0);

        controller.SimpleMove(moveDir * moveSpeed);
    }
        
    }
