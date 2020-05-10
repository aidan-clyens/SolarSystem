using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitationalBody : MonoBehaviour {
    public Vector3 velocity;
    public float mass;
    
    float radius;

    public void Awake() {
        radius = transform.localScale.x;
    }

    public void UpdatePosition(float timeStep) {
        transform.position += velocity * timeStep;
    }
}
