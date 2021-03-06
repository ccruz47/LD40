﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingCandle : MonoBehaviour {

    private Vector3 position;
    private float randomSpeed;
    [SerializeField]
    private float magnitude = 0.5f;
	// Use this for initialization
	void Awake () {
        position = transform.position;
        randomSpeed = Random.Range(0.5f, 2f) - 1f;
    }
	
	// Update is called once per frame
	void Update () {
        float Offset = Mathf.Sin(Time.time);
        transform.position = position + new Vector3(Mathf.Sin(Time.time + randomSpeed) * randomSpeed * magnitude, Offset * randomSpeed * magnitude, 0f);
	}
}
