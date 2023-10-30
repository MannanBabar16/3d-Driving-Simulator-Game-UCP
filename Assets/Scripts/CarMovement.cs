using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    //[SerializeField]
    //private float movingSpeed = 10f;


    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //    if (Input.GetKey("w"))
    //    {
    //        transform.Translate(0f, 0f, movingSpeed * Time.deltaTime);
    //        //transform.Translate(Vector3.forward * movingSpeed * Time.deltaTime);
    //    }

    //    if (Input.GetKey("s"))
    //    {
    //        transform.Translate(0f, 0f, -movingSpeed * Time.deltaTime);

    //    }

    //    if (Input.GetKey("a"))
    //    {
    //        transform.Translate(-movingSpeed * Time.deltaTime, 0f, 0f);
    //    }

    //    if (Input.GetKey("d"))
    //    {
    //        transform.Translate(movingSpeed * Time.deltaTime, 0f, 0f);
    //        //Vector3 newRotation = new Vector3(0, 50, 0);
    //        //transform.eulerAngles = newRotation;
    //    }
    //}

    public float TurnSpeed = 2f;
    public float MoveSpeed = 10f;

    private float leftRight = 0f;
    private float forward = 0f;

    // Use this for initialization
    void Awake()
    {

    }

    void ProcessInput()
    {
        leftRight = Input.GetAxis("Horizontal");
        forward = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();

        transform.RotateAroundLocal(Vector3.up, leftRight * TurnSpeed * Time.deltaTime);

        transform.Translate(0, 0, forward * MoveSpeed * Time.deltaTime);
    }


}

