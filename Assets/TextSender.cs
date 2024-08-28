using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextSender : MonoBehaviour
{
    void Update()
    {
        DevAuthNameChanger.devAuthName = GetComponent<TMP_InputField>().text;
    }
}
