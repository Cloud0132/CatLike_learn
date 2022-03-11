using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ClockManager : MonoBehaviour
{
    [SerializeField]
    Transform hour_arm;
    
    [SerializeField]
    Transform minute_arm;
    
    [SerializeField]
    Transform second_arm;

    private float hour_speed = -30f;

    private float minute_speed = -6f;

    private float second_speed = -6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var time = DateTime.Now.TimeOfDay;
        hour_arm.localRotation = Quaternion.Euler(0, 0, hour_speed * (float)time.TotalHours);
        
        minute_arm.localRotation = Quaternion.Euler(0, 0, minute_speed * (float)time.TotalMinutes);
        
        second_arm.localRotation = Quaternion.Euler(0, 0, second_speed * (float)time.TotalSeconds);
    }
}
