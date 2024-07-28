using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] Vector2[] _moveTargetPos;
    [SerializeField] float _hp;
    [SerializeField] float _damageSize = 1;
    bool _smokeCollision;

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
            transform.position = _moveTargetPos[0];
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = _moveTargetPos[1];
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = _moveTargetPos[2];
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = _moveTargetPos[3];
        }
    }
    void Damage()
    {
        if (_smokeCollision)
        {
            _hp -= Time.deltaTime * _damageSize;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Smoke")
        {
            _smokeCollision = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Smoke")
        {
            _smokeCollision = false;
        }
    }
}
