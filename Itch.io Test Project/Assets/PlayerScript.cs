using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public Material Mat;
    // Start is called before the first frame update
    void Start()
    {
        print("Working");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Blue(InputAction.CallbackContext ctx)
    {
        if (ctx.phase == InputActionPhase.Performed)
        {
            Mat.color = Color.blue;
        } 
    }

    public void Red(InputAction.CallbackContext ctx)
    {
        if (ctx.phase == InputActionPhase.Performed)
        {
            Mat.color = Color.red;
        }
    }

    public void Green(InputAction.CallbackContext ctx)
    {
        if (ctx.phase == InputActionPhase.Performed)
        {
            Mat.color = Color.green;
        }
    }
}
