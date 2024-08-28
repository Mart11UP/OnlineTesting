using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EpicTransport;

public class DevAuthNameChanger : MonoBehaviour
{
    EOSSDKComponent EOSSDK;
    public static string devAuthName;

    // Start is called before the first frame update
    void Start()
    {
        EOSSDK = GetComponent<EOSSDKComponent>();
    }

    public void Initialize()
    {
        EOSSDK.devAuthToolCredentialName = devAuthName;
        EOSSDKComponent.Initialize();
    }
}
