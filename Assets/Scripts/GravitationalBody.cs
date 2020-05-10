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

    public void UpdateVelocity(GravitationalBody[] bodies, float timeStep) {
        foreach (GravitationalBody body in bodies) {
            if (body != this) {
                float distance_magnitude = (body.transform.position - transform.position).sqrMagnitude;
                Vector3 distance_direction = (body.transform.position - transform.position).normalized;
                Vector3 acceleration = (Universe.gravitationalConstant * body.mass / distance_magnitude) * distance_direction;
                velocity += acceleration * timeStep;
            }
        }
    }

    public void UpdatePosition(float timeStep) {
        transform.position += velocity * timeStep;
    }
}
