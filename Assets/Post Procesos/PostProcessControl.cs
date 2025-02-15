using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostProcessControl : MonoBehaviour
{
    [SerializeField] private Material _PPInkMaterial;
    [SerializeField] private bool _IsOnInk;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            TurnOnOffInk();
        }
    }

    public void TurnOnOffInk()
    {
        if (_IsOnInk)
        {
            _PPInkMaterial.SetFloat("_Alpha", 0f);
            
            _IsOnInk = false;
        }
        else
        {
            _PPInkMaterial.SetFloat("_Alpha", 1);
            _IsOnInk = true;
        }
    }
}
