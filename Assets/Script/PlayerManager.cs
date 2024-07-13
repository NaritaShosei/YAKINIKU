using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] GameObject[] _moveTargetPos;
    [SerializeField] float _hp;
    bool _smokeStart;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Damage();
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
    void Damage()
    {
        if (_smokeStart)
        {
            _hp -= Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Smoke")
        {
            _smokeStart = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Smoke")
        {
            _smokeStart = false;
        }
    }
}
