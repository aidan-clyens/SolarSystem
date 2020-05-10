using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NBodySimulation : MonoBehaviour {
    public float timeStep;

    GravitationalBody[] bodies;

    void Start() {
        bodies = FindObjectsOfType<GravitationalBody>();
        Time.fixedDeltaTime = timeStep;
    }

    void FixedUpdate() {
        foreach (GravitationalBody body in bodies) {
            body.UpdatePosition(timeStep);
        }
    }
}
