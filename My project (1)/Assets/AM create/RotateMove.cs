using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMove : MonoBehaviour
{
    private Vector3 target = new Vector3(0.0f, 0.0f, 0.0f);
    float angle = 50;

    void Update()
    {
        //RotateAround(���S�̏ꏊ,��,��]�p�x)
        transform.RotateAround(target, Vector3.up, angle * Time.deltaTime);
    }
}