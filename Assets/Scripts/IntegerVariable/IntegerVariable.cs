using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "IntegerVariable", menuName = "IntegerVariable", order = 0)]
public class IntegerVariable : ScriptableObject {
    public int value;
    public int defaultValue = 0;
    public int minValue = 0;
    public int maxValue = 100;
    public List<IntegerVariableListener> listeners = new List<IntegerVariableListener>();
    private void OnEnable() {
        value = defaultValue;
        listeners.Clear();
    }

    public void SetValue(int value) {
        this.value = Mathf.Clamp(value, minValue, maxValue);
        NotifyListeners();
    }

    public void RegisterListener(IntegerVariableListener listener) {
        listeners.Add(listener);
    }

    private void NotifyListeners() {
        foreach (IntegerVariableListener listener in listeners) {
            listener.OnChange(value);
        }
    }

}

public abstract class IntegerVariableListener : MonoBehaviour {
    public IntegerVariable variable;
    public abstract void OnChange(int value);
}
