using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeGenerator : MonoBehaviour
{
    [SerializeField] float _waitTime;
    [SerializeField] Vector3[] _direction;
    int _randomIndex;
    bool _yakinikuStart;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSmokeDirectionChange());
    }

    // Update is called once per frame
    void Update()
    {
        YakinikuStart();
    }
    void YakinikuStart()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !_yakinikuStart)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            _randomIndex = Random.Range(0, _direction.Length);
            transform.localRotation = Quaternion.Euler(_direction[_randomIndex]);
            _yakinikuStart = true;
        }
    }
    IEnumerator StartSmokeDirectionChange()
    {
        yield return new WaitForSeconds(_waitTime);
        _randomIndex = Random.Range(0, _direction.Length);
        transform.localRotation = Quaternion.Euler(_direction[_randomIndex]);
        StartCoroutine(StartSmokeDirectionChange());
    }
}
