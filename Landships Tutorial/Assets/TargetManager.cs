using UnityEngine;
using System.Collections;

public class TargetManager : MonoBehaviour {

    // This script keeps track of the number of unhit targets.
    // Once this number drops to 0, it displays the ending message
    // and opens the next scene.

    int numTargets;
    public float waitTime = 3f;

    // Use this for initialization
    void Start() {
        numTargets = 3;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Application.LoadLevel("GameScene");
        }
    }

    // Called from TargetHitDetection
    public void decreaseCount() {
        numTargets -= 1;
        if (numTargets <= 0) {
            allTargetsHit();

        }
    }

    void allTargetsHit() {

        print("All targets hit, starting countdown to scene switch");

        // Display message

        StartCoroutine(switchScenes());
    }

    IEnumerator switchScenes()
    {
        yield return new WaitForSeconds(waitTime);
        Application.LoadLevel("GameScene");

    }



}
