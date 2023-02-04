using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntegerVariableBarDisplay : IntegerVariableListener
{
    [SerializeField] private RectTransform barDisplay;
    private float barDisplayLength = 0f;
    public Image bar;
    private void Start()
    {
        barDisplayLength = barDisplay.rect.width;
        bar.rectTransform.sizeDelta = new Vector2(barDisplayLength * variable.value / variable.maxValue, bar.rectTransform.sizeDelta.y);
        variable.RegisterListener(this);
        OnChange(variable.value);
    }
    public override void OnChange(int value)
    {
        bar.rectTransform.sizeDelta = new Vector2(barDisplayLength * value / variable.maxValue, bar.rectTransform.sizeDelta.y);
    }
}

