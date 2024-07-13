using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] GameObject[] _moveTargetPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = _moveTargetPos[0].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = _moveTargetPos[1].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = _moveTargetPos[2].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = _moveTargetPos[3].transform.position;
        }
    }
}
