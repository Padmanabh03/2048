using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TileStyle
{
    public int Number;
    public Color32 TileColor;
    public Color32 TextColor;
}

public class TileStyleFolder : MonoBehaviour
{

    public static TileStyleFolder Instance;

    public TileStyle[] TileStyles;

    private void Awake()
    {
        Instance = this;
    }
}
