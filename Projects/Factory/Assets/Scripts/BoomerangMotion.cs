using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerangMotion : MonoBehaviour
{
    [SerializeField] private float Speed = 5.0f;
    [SerializeField] private float timeBeforeReturn = 2.0f;
    private Vector3 direction = new Vector3(0, 0, 1);

    void Update()
    {
        var pos = this.transform.position;
        if (this.timeBeforeReturn > 0)
        {
            pos += this.Speed * Time.deltaTime * direction;
        }
        else
        {
            pos += this.Speed * Time.deltaTime * -direction;
        }
        this.transform.position = pos;
        this.timeBeforeReturn -= Time.deltaTime;
        this.transform.Rotate(0f, 1f, 0f, Space.Self);
    }
}
