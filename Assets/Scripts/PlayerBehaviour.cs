using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    private float jumpForce = 10.0f;

    [SerializeField]
    private Transform playerStartPos;


    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(playerStartPos.position);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        bool canJump = y > 0;

        Vector3 pos = new Vector3( x * speed * Time.deltaTime, 0, 0);
        if(canJump)
            pos = new Vector3(pos.x, y * jumpForce * Time.deltaTime, 0);
         
        transform.Translate(pos);
    }
}
