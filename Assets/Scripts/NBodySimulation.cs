using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NBodySimulation : MonoBehaviour {
    GravitationalBody[] bodies;

    void Awake() {
        bodies = FindObjectsOfType<GravitationalBody>();
        Time.fixedDeltaTime = Universe.timeStep;
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
