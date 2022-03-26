using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square_green_controller : MonoBehaviour
{
    public float speed;
    public Vector3 target_move;

    public Vector3 target_move_2;

    private Vector3 _startPos;
    private Vector3 _endPos;

    void Update()
    {   
        if((target_move.x != 0) && (target_move.y != 0))
        {
            target_move_2 = target_move;
            //_endPos=target_move_2;
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,0, Screen.width), transform.position.y, transform.position.z);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y,0,Screen.height),transform.position.z);
        
        transform.Translate(target_move_2*speed*Time.deltaTime);
        //Rigidbody rb = GetComponent<Rigidbody>();
        //Vector3 v3Velocity = rb.velocity;

        //float still_speed = Vector3.Distance(target_move, target_move_2)/(Time.deltaTime);
        
        //Debug.Log(GetComponent<Rigidbody>().velocity.magnitude);

        //var speed = rigidbody.velocity.magnitude*3.6f;
       // transform.position = Vector3.Lerp(_startPos, _endPos, Time.time);
    }
}
