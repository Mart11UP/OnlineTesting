using Mirror;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SyncAttributes : NetworkBehaviour
{
    SpriteRenderer spriteRenderer;
    TextMeshPro text;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        text = GetComponentInChildren<TextMeshPro>();
    }

    void OnColorChange(Color lastColor, Color newColor)
    {
        spriteRenderer.color = newColor;
    }

    void OnPlayerTypeChange(string lastText, string newText)
    {
        if (isLocalPlayer) newText = "Local player";
        text.text = newText;
    }



    #region Server
    [SyncVar(hook = nameof(OnColorChange))] Color color;
    [SyncVar(hook = nameof(OnPlayerTypeChange))] string playerType;

    [Server] public void SetPlayerColor(Color color)
    {
        this.color = color;
    }

    [Server] public void SetPlayerType(string playerType)
    {
        this.playerType = playerType;
    }
    #endregion
}
