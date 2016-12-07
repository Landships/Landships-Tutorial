using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TargetManager : MonoBehaviour {

    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public Text message;
    private bool timeStarted;
    private float time;

    private void setMessage() {
        if (time > 30 && time < 40) {
            message.text = "Target Has Moved!";
        }
        else if (time > 60 && time < 70) {
            message.text = "Target Has Moved!";
        }
        else if (time < 90)
            message.text = "Shoot the Target";
        else
            message.text = "Nice job";

    } 
    void Start () {
        timeStarted = true;
        time = 0;
        target2.SetActive(false);
        target3.SetActive(false);
        message.text = "Shoot the Target";
	}
	
	// Update is called once per frame
	void Update () {
	    if (timeStarted) {
            time += Time.deltaTime;
        }
        setMessage();
        if (time > 30 && time < 60) {
            target1.SetActive(false);
            target2.SetActive(true);
        }
        if (time > 60 && time < 90) {
            target2.SetActive(false);
            target3.SetActive(true);
        }

	}
}
