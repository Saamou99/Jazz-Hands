using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class networkPlayer : NetworkBehaviour
{
    [SerializeField] private Transform root;
    [SerializeField] private Transform head;
    [SerializeField] private Transform leftHand;
    [SerializeField] private Transform rightHand;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsOwner)
        {
            root.position = VRrigReferences.Singleton.root.position;
            root.rotation = VRrigReferences.Singleton.root.rotation;

            head.position = VRrigReferences.Singleton.head.position;
            head.rotation = VRrigReferences.Singleton.head.rotation;

            leftHand.position = VRrigReferences.Singleton.leftHand.position;
            leftHand.rotation = VRrigReferences.Singleton.leftHand.rotation;

            rightHand.position = VRrigReferences.Singleton.rightHand.position;
            rightHand.rotation = VRrigReferences.Singleton.rightHand.rotation;

        }
    }
}