using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    private Transform prefab;

    [SerializeField, Range(10, 100)]
    private int resolution;
    // Start is called before the first frame update
    void Start()
    {
        var time = Time.time;
        var position = Vector3.zero;
        float step = 2f / resolution;
        var scale = Vector3.one / 5f;
        for (int i = 0; i < resolution; i++)
        {
            Transform point = Instantiate(prefab);
            position.x = (i + 0.5f) * step - 1f;
            position.y = position.x * position.x;
            point.localPosition = position;
            point.localScale = scale;
            
            point.SetParent(transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
