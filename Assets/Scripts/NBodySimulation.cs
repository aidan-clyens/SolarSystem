using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NBodySimulation : MonoBehaviour {
    public int timeMultiplier;

    GravitationalBody[] bodies;

    void Awake() {
        bodies = FindObjectsOfType<GravitationalBody>();
        Time.fixedDeltaTime = (1f / timeMultiplier) *Universe.timeStep;
    }

    void FixedUpdate() {
        foreach (GravitationalBody body in bodies) {
            body.UpdateVelocity(bodies, Universe.timeStep);
        }

        foreach (GravitationalBody body in bodies) {
            body.UpdatePosition(Universe.timeStep);
        }
    }
}
