using UnityEngine;
using System.Collections;

public class TargetManager : MonoBehaviour {

    // This script keeps track of the number of unhit targets.
    // Once this number drops to 0, it displays the ending message
    // and opens the next scene.

    int numTargets;

    // Use this for initialization
    void Start() {

        numTargets = 3;

    }

    // Called from TargetHitDetection
    public void decreaseCount() {
        numTargets -= 1;
        if (numTargets <= 0) {
            allTargetsHit();

        }
    }

    void allTargetsHit() {

        print("All targets hit");
        
        // Display message


        //Switch scenes
    }
	


}
