using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[ExecuteInEditMode]
public class ProgressBar : MonoBehaviour
{

    
    #if UNITY_EDITOR
    void Update()
    {
        //mylogs Probably remove this later
        if (Debug.isDebugBuild) Debug.Log($"<color=purple>Test</color>");

    }
    
    #endif
    
    
    public Image fillAmount;
    public RectTransform parent;
    public RectTransform child;
    

    private void UpdateSize(float value)
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateSize(5f);
    }

    // Update is called once per frame
    
}
