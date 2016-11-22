using UnityEngine;
using System.Collections;

public class StageSelectBtnController : MonoBehaviour {

    public GameObject Camera;

    private int max_stage_num = 4;
    private int select_now;
	
    // Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        select_now = ((int)(Camera.transform.position.x) / 15) + 1;
        if (this.name == "Right_btn") {
            select_now++;
            if (select_now > max_stage_num) {
                select_now = max_stage_num;
            }
        } else if (this.name == "Left_btn") {
            select_now--;
            if (select_now < 1) {
                select_now = 1;
            }
        }
        Camera.SendMessage("MovingCamera", new Vector3(15 * (select_now - 1), 0, -10));
    }
}
