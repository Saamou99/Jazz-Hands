using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimationController : MonoBehaviour
{
    public InputActionProperty pinchAnimation;
    public InputActionProperty fistAnimation;
    public Animator handAnimation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pinchValue = pinchAnimation.action.ReadValue<float>();
        Debug.Log("pinch Value: " +  pinchValue);
        handAnimation.SetFloat("Pinch", pinchValue);


        float fistValue = fistAnimation.action.ReadValue<float>();
        Debug.Log("fistValue " +  fistValue);
        handAnimation.SetFloat("Fist", fistValue);
    }

}