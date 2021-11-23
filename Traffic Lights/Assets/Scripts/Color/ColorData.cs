using System;

using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "new Color Data", menuName = "ColorData")]
public class ColorData : ScriptableObject
{
    [SerializeField]
    private Color _color;

    public Color Color => _color;
}
