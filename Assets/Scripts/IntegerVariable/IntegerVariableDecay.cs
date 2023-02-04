using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntegerVariableDecay : IntegerVariableListener
{
    public float decayTime = 1f;
    public int decayAmount = 1;
    private void Start()
    {
        StartCoroutine(DecayVariable());
    }
    private IEnumerator DecayVariable()
    {
        while (true)
        {
            yield return new WaitForSeconds(decayTime);
            variable.SetValue(variable.value - decayAmount);
        }
    }
    public override void OnChange(int value)
    {
        // This method can be left empty or used for additional logic if desired.
    }
}