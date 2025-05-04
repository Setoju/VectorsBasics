﻿using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    public float speed = 1f;

    void Start() {

    }

    private void LateUpdate() {
        direction = goal.transform.position - this.transform.position;
        this.transform.LookAt(goal.transform.position);
        if (direction.magnitude < 0.1f) {
            return;
        }
        Vector3 velocity = direction.normalized * speed * Time.deltaTime;
        this.transform.position = this.transform.position + velocity;
    }
}
