using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Mouse  0 -> LMB 1 -> RMB 2 -> MWB
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Button pressed!");
        }
        if(Input.GetMouseButton(0)){
            Debug.Log("Button is pressed!");
        }
        if(Input.GetMouseButtonUp(0)){
            Debug.Log("Button released!");
        }

        // 2. Keybpard
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Space pressed");
        }
        // It is prefered to use this method over Keycode input. Go to Edit -> Proyect Settings -> Input Manager
        if(Input.GetButtonDown("Jump")){
            Debug.Log("Jump pressed");
        }
        // Get Axis for movement
        float horizontal = Input.GetAxis("Horizontal"); // -1 to 1
        float vertical = Input.GetAxis("Vertical"); // -1 to 1

        if(horizontal < 0f || horizontal > 0f){
            Debug.Log("Horizontal axis is: " + horizontal);
        }
        if(vertical < 0f || vertical > 0f){
            Debug.Log("Vertical axis is: " + vertical);
        }
    }
}
