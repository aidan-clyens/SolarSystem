using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitationalBody : MonoBehaviour {
    public Vector3 velocity;
    public float density;
    public float mass;

    TrailRenderer trailRenderer;

    public void Awake() {
        float radius = transform.localScale.x;
        float volume = (4 / 3) * Mathf.PI * Mathf.Pow(radius, 3);
        mass = density * volume;

        trailRenderer = GetComponent<TrailRenderer>();
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

        trailRenderer.time = velocity.sqrMagnitude / (2f * mass);
    }

    public void UpdatePosition(float timeStep) {
        transform.position += velocity * timeStep;
    }
}
