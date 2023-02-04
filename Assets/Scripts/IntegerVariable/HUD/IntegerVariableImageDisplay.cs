using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class IntegerVariableImageDisplay : IntegerVariableListener {
    [SerializeField] public GameObject prefab;
    [SerializeField] public GameObject emptyPrefab;
    [SerializeField] public float spaceBetweenPrefabs = 10f;
    [SerializeField] public RectTransform container;
    [SerializeField] public Vector2 imageSize = new Vector2(30, 30);
    [SerializeField] public int maxPerRow = 5;
    private List<GameObject> prefabInstances = new List<GameObject>();

    private void Start() {
        variable.RegisterListener(this);
        OnChange(variable.value);
    }

    public override void OnChange(int value)
    {
        // Destroy previous prefab instances
        foreach (var instance in prefabInstances)
        {
            Destroy(instance);
        }

        // Create new prefab instances based on the current value
        for (int i = 0; i < variable.maxValue; i++)
        {
            GameObject instance = i < value ? Instantiate(prefab, container) : Instantiate(emptyPrefab, container);
            instance.GetComponent<RectTransform>().sizeDelta = imageSize;
            int row = i / maxPerRow;
            int col = i % maxPerRow;
            instance.transform.localPosition = new Vector3(col * (imageSize.x + spaceBetweenPrefabs) - container.sizeDelta.x / 2 + imageSize.x / 2,
                                                        -row * (imageSize.y + spaceBetweenPrefabs) + container.sizeDelta.y / 2 - imageSize.y / 2, 0);
            prefabInstances.Add(instance);
        }
    }
}
