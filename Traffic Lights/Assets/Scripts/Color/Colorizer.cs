
using UnityEngine;

public class Colorizer : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _renderer;

    [SerializeField]
    private SpriteRenderer _destination;

    [SerializeField]
    private ColorData _colorData;

    public ColorData ColorData => _colorData;

    private void Start()
    {
        if (_colorData != null)
        {
            Colorize();
        }
    }

    public void Colorize()
    {
        _renderer.color = _colorData.Color;
        if (_destination != null)
        {
            _destination.color = _colorData.Color;
        }
    }

    public void SetColorData(ColorData colorData)
    {
        _colorData = colorData;
        Colorize();
    }

    public void ChangeAlpha(float alpha)
    {
        _renderer.color = new Color(_colorData.Color.r, _colorData.Color.g, _colorData.Color.b, alpha);
    }

}
