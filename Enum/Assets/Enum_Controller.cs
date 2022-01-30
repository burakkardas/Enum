using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum_Controller : MonoBehaviour
{
    
    [SerializeField] private SpriteRenderer _spriteRenderer;

    [Header("Colors")]
    [SerializeField] private Color _colorRed;
    [SerializeField] private Color _colorBlue;
    [SerializeField] private Color _colorYellow;
    [SerializeField] private Color _colorGreen;
    [SerializeField] private Color _colorPurple;

    [SerializeField] private enum Colors {
        Red,
        Blue,
        Yellow,
        Green,
        Purple,
    }

    [SerializeField] private Colors _color;
    [SerializeField] private float _lerpTime;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {
        switch(_color) {
            case Colors.Red : _spriteRenderer.color = Color.Lerp(_spriteRenderer.color, _colorRed, _lerpTime * Time.deltaTime);
                              break;
            case Colors.Yellow : _spriteRenderer.color = Color.Lerp(_spriteRenderer.color, _colorYellow, _lerpTime * Time.deltaTime);
                              break;
            case Colors.Blue : _spriteRenderer.color = Color.Lerp(_spriteRenderer.color, _colorBlue, _lerpTime * Time.deltaTime);
                              break;
            case Colors.Green : _spriteRenderer.color = Color.Lerp(_spriteRenderer.color, _colorGreen, _lerpTime * Time.deltaTime);
                              break;
            case Colors.Purple : _spriteRenderer.color = Color.Lerp(_spriteRenderer.color, _colorPurple, _lerpTime * Time.deltaTime);
                              break;                              
        }
    }
}
