using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphPlotter : MonoBehaviour
{
    [SerializeField] private GameObject _pointAsset;
    [Range(10,100)]
    [SerializeField] private int _resolution = 10;

    // Start is called before the first frame update
    void Awake()
    {       
        var pos = Vector3.zero;
        float step = 2f / _resolution;
        var scale = Vector3.one * step;
        for (var i = 0; i < _resolution; i++)
        {
            var point = Instantiate(_pointAsset);
            point.transform.SetParent(transform, false); 

            pos.x = GetXPosition(i , step);
            pos.y = pos.x * pos.x * pos.x;

            point.transform.localPosition = pos;
            point.transform.localScale = scale;
        }
    }

    private float GetXPosition(int index, float step){
        return ((index + 0.5f) * step - 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
