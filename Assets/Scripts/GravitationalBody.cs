using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitationalBody : MonoBehaviour {
    public Vector3 velocity;
    public float mass;
    public float radius;

    public void UpdatePosition(float timeStep) {
        GetComponent<RigidBody>().position += velocity * timeStep;
    }
}
