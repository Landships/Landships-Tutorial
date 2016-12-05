using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EndTrigger : MonoBehaviour {
    public Text message;
    private void Start() {
        message.text = "Your Mission: Follow the Red Path And Collect the Yellow Ball";
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Tank")) {
            message.text = "Mission Completed! Nice Job";
        }
    }
}
