using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class connectNetwork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startHost()
    {
        NetworkManager.Singleton.StartHost();
        Debug.Log("HOST IS STARTING!");
    }

    public void startClient()
    {
        NetworkManager.Singleton.StartClient();
        Debug.Log("CLIENT IS STARTING");
    }
}